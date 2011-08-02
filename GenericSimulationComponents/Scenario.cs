/*
 * Created by SharpDevelop.
 * User: tm300
 * Date: 14/07/2011
 * Time: 15:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericSimulationComponents
{
	public delegate void ScenarioSelectedHandler(object sender, ScenarioEventArgs args);
	 
	
	public class ScenarioEventArgs : EventArgs
	{
		public Scenario SelectedScenario{get;set;}
		
		public ScenarioEventArgs(){
			
		}
	}
	
	/// <summary>
	/// A particular configuration of a model.  May consist of multiple models
	/// </summary>
	public class Scenario : IEnumerable
	{
		public List<ModelMetaClass> Models{get;set;}
		public string InputDirectory{get;set;}
		
		public string Description{get;set;}
		
		private string outputdir;
		private string filePrefix;
		private string name;
		
		private int runningIndex;
		
		public SimulationCompleteHandler OnAllSimulationsComplete;
		public SimulationCompleteHandler OnModelRunComplete;
		
		
		public ScenarioSelectedHandler OnScenarioSelected;
		
		public Scenario()
		{
			this.Models = new List<ModelMetaClass>();
		}
		
		public string OutputDirectory{
			get{
				return outputdir;
			}set{
				this.outputdir = value;

				UpdateModelOutputPaths();
			}
		}
		
		public string FilePrefix{
			get{
				return this.filePrefix;
			}set{
				this.filePrefix = value;
				UpdateModelOutputPaths();
				
			}
		}
		
		public string Name{
			get{
				return this.name;
			}set{
				this.name = value;
				UpdateModelOutputPaths();
			}
		}

		void UpdateModelOutputPaths()
		{
			foreach (ModelMetaClass model in this.Models) {
				SetOutputFileName(model);
			}
		}
		
		

		public void EnsureModelsAreLoaded()
		{
			foreach (ModelMetaClass model in Models) {
				if (!model.IsLoaded) {
					model.Load();
				}
			}
		}
		



		/// <summary>
		/// Iterator pattern for simulation models
		/// </summary>
		/// <returns></returns>
		public IEnumerator GetEnumerator(){
			
			foreach(ModelMetaClass model in this.Models){
				yield return model;
			}
		}
		
		
		public void AddModel(ModelMetaClass toAdd){
			this.Models.Add(toAdd);
			SetOutputFileName(toAdd);
		}

		void SetOutputFileName(ModelMetaClass toUpdate)
		{
			string output = string.Concat(this.OutputDirectory, "\\", this.FilePrefix, "_");
			string name = toUpdate.FileName.Substring(toUpdate.FileName.LastIndexOf("\\") + 1);
			toUpdate.OutputFileName = string.Concat(output, name);
		}
		
		public void RemoveModel(ModelMetaClass toRemove){
			this.Models.Remove(toRemove);
		}
		
		
		/// <summary>
		/// Runs the simulation models in the scenario
		/// </summary>
		public void RunModels(){
			runningIndex = -1;
			
			try {
				RunNextModel();
			} catch (ArgumentOutOfRangeException e) {
				
				Console.WriteLine("There are no models present in the run list");
				throw new ArgumentOutOfRangeException("There are no models present in the run list", e);
			}
			
		}
		
		
		private void RunNextModel(){
			runningIndex++;
			ModelMetaClass modelToRun = this.Models[runningIndex];
			modelToRun.OnSimulationComplete += this.SimulationComplete;
			modelToRun.Write();
			modelToRun.Run();
		}
		
		
		public void SimulationComplete(object sender,EventArgs args){
			if(runningIndex < this.Models.Count - 1){
				BroadCastUpdate();
				RunNextModel();
			}else{
				Console.WriteLine("All models have been run successfully");
				BroadcastCompleteEvent();
			}
		}

		void BroadCastUpdate()
		{
			if (null != this.OnModelRunComplete) {
				
				double perComp = ((runningIndex + 1) / this.Models.Count)*100;
				string message = "Running simulation models...";
				//this.OnModelRunComplete(this, new UpdateEventArgs(){Message = message, PercentageComplete = perComp});
			}
		}

		void BroadcastCompleteEvent()
		{
			if (null != this.OnAllSimulationsComplete) {
				this.OnAllSimulationsComplete(this, new EventArgs());
			}
		}
		
	
	}
}
