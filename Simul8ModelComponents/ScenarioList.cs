/*
 * Created by SharpDevelop.
 * User: tm300
 * Date: 15/07/2011
 * Time: 09:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using System.Collections.Generic;
using System.IO;

using GenericSimulationComponents;

namespace Simul8ModelComponents
{
	public delegate void RunScenarioEventHandler(object sender, ScenarioEventArgs args);
	public delegate void ScenarioCompleteEventHandler(object sender, EventArgs args);
	
	/// <summary>
	/// Displays a collection of scenario objects
	/// </summary>
	public partial class ScenarioList : UserControl
	{
		public ScenarioSelectedHandler OnScenarioSelected;
		public RunScenarioEventHandler OnRunScenario;
		
		private int runningIndex;
		
		public List<Scenario> Scenarios;
		
		
		public ScenarioList()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			this.Scenarios = new List<Scenario>();
			this.OnScenarioSelected += this.scenarioDetailsView1.ScenarioSelected;
			
		}
		

		

		
		void Button1Click(object sender, EventArgs e)
		{
			
			if(DialogResult.OK == this.folderBrowserDialog1.ShowDialog(this.Parent)){
				
				
				string[] files = Directory.GetFiles(this.folderBrowserDialog1.SelectedPath, "*.xs8");
				
				string ScenarioName = GetDefaultScenarioName(ref files);
				
				Scenario newScenario = CreateScenario(ref files, ScenarioName);
				
				AddModelsToScenario(files, newScenario);
				
				SelectFirstScenario();
				
			}
			
			
			
		}

		void SelectFirstScenario()
		{
			var selected = (Scenario)this.bindingSource1[0];
			BroadcastScenarioSelected(selected);
		}

		void BroadcastScenarioSelected(Scenario selected)
		{
			if (null != this.OnScenarioSelected) {
				
				this.OnScenarioSelected(this, new ScenarioEventArgs { SelectedScenario = selected });
			}
		}

		string GetDefaultScenarioName(ref string[] files)
		{
			string ScenarioName = this.folderBrowserDialog1.SelectedPath.Substring(this.folderBrowserDialog1.SelectedPath.LastIndexOf("\\") + 1);
			return ScenarioName;
		}

		Scenario CreateScenario(ref string[] files, string ScenarioName)
		{
			Scenario newScenario = new Scenario {
				Name = ScenarioName,
				FilePrefix = ScenarioName,
				OutputDirectory = this.folderBrowserDialog1.SelectedPath,
				InputDirectory = this.folderBrowserDialog1.SelectedPath
			};
			
			this.bindingSource1.Add(newScenario);
			return newScenario;
		}


		void AddModelsToScenario(string[] files, Scenario newScenario)
		{
			foreach (string fileName in files) {
				newScenario.AddModel(new ModelMetaClass {
				                     	FileName = fileName,
				                     	Runner = new Simul8Runner(),
				                     	Reader = new Simul8XMLReader(fileName),
				                     	Writer = new Simul8XMLWriter()
				                     });
			}
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		
		void DataGridView1CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Scenario selected = (Scenario)this.bindingSource1[e.RowIndex];
			BroadcastScenarioSelected(selected);
		}


		
		/// <summary>
		/// runs the selected scenario
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Button3Click(object sender, EventArgs e)
		{
			var selected = (Scenario)this.bindingSource1[this.dataGridView1.CurrentRow.Index];
			selected.EnsureModelsAreLoaded();
			this.BroadCastToRunners(selected);
		}
		
		void RunAllClick(object sender, EventArgs args)
		{
			runningIndex = -1;
			
			try {
				RunNextScenario();
			} catch (ArgumentOutOfRangeException e) {
				
				Console.WriteLine("There are no scenarios present in the run list");
				throw new ArgumentOutOfRangeException("There are no scenarios present in the run list", e);
			}
			
			
			
		}
		

		/// <summary>
		/// Broadcast to run the scenario...
		/// </summary>
		void BroadCastToRunners(Scenario toRun)
		{
			if (null != this.OnRunScenario) {
				this.OnRunScenario(this, new ScenarioEventArgs{SelectedScenario = toRun});
			}
		}

		
		public void ScenarioComplete(object sender, EventArgs e){
			
			if(runningIndex < this.bindingSource1.Count - 1){
				BroadCastUpdate();
				RunNextScenario();
			}else{
				Console.WriteLine("All scenarios have been run successfully");
				BroadcastCompleteEvent();
			}
			
		}
		
		void BroadCastUpdate()
		{
//			if (null != this.onscen) {
//
//				double perComp = ((runningIndex + 1) / this.bindingSource1.Count)*100;
//				string message = "Running simulation models...";
//				this.OnModelRunComplete(this, new UpdateEventArgs(){Message = message, PercentageComplete = perComp});
//			}
		}
		
		void RunNextScenario(){
			runningIndex++;
			var scenarioToRun = (Scenario)this.bindingSource1[runningIndex];
			Console.WriteLine(string.Concat("*** SCENARIO: ", scenarioToRun.Name, " ***"));
			scenarioToRun.OnAllSimulationsComplete += this.ScenarioComplete;
			
			//this.BroadcastScenarioSelected(scenarioToRun);
			
			scenarioToRun.EnsureModelsAreLoaded();
			Console.WriteLine("here");
			//this.BroadCastToRunners(scenarioToRun);
			scenarioToRun.RunModels();
			Console.WriteLine("here2");
		}
		
		void BroadcastCompleteEvent(){
			Console.WriteLine("All scenarios have been run successfully");
		}
		
		public void ModelRemoved(object sender, ModelSelectedEventArgs args){
			
			var selected = (Scenario)this.bindingSource1[this.dataGridView1.CurrentRow.Index];
			selected.RemoveModel(args.SelectedModel);
		}
		
	}
}
