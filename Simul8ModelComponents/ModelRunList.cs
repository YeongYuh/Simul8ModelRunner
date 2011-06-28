/*
 * Created by SharpDevelop.
 * User: tm300
 * Date: 20/06/2011
 * Time: 11:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using GenericSimulationComponents;

namespace Simul8ModelComponents
{
	public delegate void ModelSelectedHandler(object sender, ModelSelectedEventArgs args);
	
	public class ModelSelectedEventArgs : EventArgs{
		public ModelMetaClass SelectedModel{get;set;}
		public ModelSelectedEventArgs(){}
	}
	
	public class UpdateEventArgs: EventArgs{
		public double PercentageComplete{get;set;}
		public string Message{get;set;}
		public UpdateEventArgs(){}
	}
	
	/// <summary>
	/// Contains a list of simulation models to run.
	/// User can add more, delete or reorder.
	/// </summary>
	public partial class ModelRunList : UserControl
	{
		
		private int runningIndex;
		public ModelSelectedHandler OnModelSelected;
		public SimulationCompleteHandler OnAllSimulationsComplete;
		public SimulationCompleteHandler OnModelRunComplete;
		
		public ModelRunList()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		
		/// <summary>
		/// Select a model to add to the run list
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void BtAddClick(object sender, EventArgs e)
		{
			this.openFileDialog1.Multiselect = true;
			this.openFileDialog1.Filter = "Simul8 XML Models | *.xs8";
			this.openFileDialog1.Title = "Select Simul8 xml files to run";
			
			if(DialogResult.OK == this.openFileDialog1.ShowDialog()){
				
				foreach(string fileName in this.openFileDialog1.FileNames){
					this.bindingSource1.Add(new ModelMetaClass{
					                        	FileName = fileName,
					                        	Runner = new Simul8Runner(),
					                        	Reader = new Simul8XMLReader(fileName),
					                        	Writer = new Simul8XMLWriter()});
				}
				
			}
		}
		
		
		/// <summary>
		/// Runs the simulation model
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
			ModelMetaClass modelToRun = (ModelMetaClass)this.bindingSource1[runningIndex];
			modelToRun.OnSimulationComplete += this.SimulationComplete;
			modelToRun.Write();
			modelToRun.Run();
		}
		
		
		public void SimulationComplete(object sender,EventArgs args){
			if(runningIndex < this.bindingSource1.Count - 1){
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
				
				double perComp = ((runningIndex + 1) / this.bindingSource1.Count)*100;
				string message = "Running simulation models...";
				this.OnModelRunComplete(this, new UpdateEventArgs(){Message = message, PercentageComplete = perComp});
			}
		}

		void BroadcastCompleteEvent()
		{
			if (null != this.OnAllSimulationsComplete) {
				this.OnAllSimulationsComplete(this, new EventArgs());
			}
		}
		
		
		void DataGridView1CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Console.WriteLine(e.RowIndex.ToString());
			if(e.RowIndex >= 0){
				var model = (ModelMetaClass)this.bindingSource1[e.RowIndex];
				BroadcastModelSelectedEvent(model);
			}
		}

		void BroadcastModelSelectedEvent(ModelMetaClass model)
		{
			if (null != this.OnModelSelected) {
				this.OnModelSelected(this, new ModelSelectedEventArgs { SelectedModel = model });
			}
		}
		
		void BtRemoveClick(object sender, EventArgs e)
		{
			if(this.dataGridView1.Rows.Count > 0){
				int index = RemoveSelectedModel();
				SelectNextModelInList(index);
			}
			
		}

		int RemoveSelectedModel()
		{
			int index = this.dataGridView1.SelectedCells[0].RowIndex;
			this.bindingSource1.RemoveAt(index);
			return index;
		}

		void SelectNextModelInList(int index)
		{
			if (index == this.bindingSource1.Count && this.bindingSource1.Count != 0) {
				this.dataGridView1.Rows[index - 1].Selected = true;
			} else if (index < this.bindingSource1.Count) {
				this.dataGridView1.Rows[index].Selected = true;
			}
		}
		
		void BtMoveUpClick(object sender, EventArgs e)
		{
			int index = this.dataGridView1.SelectedCells[0].RowIndex;
			
			if(index > 0){
				
				
				
				
			}
			
			
		}
		
		void ByMoveDownClick(object sender, EventArgs e)
		{
			
			int index = this.dataGridView1.SelectedCells[0].RowIndex;
			ModelMetaClass modelToWrite = (ModelMetaClass)this.bindingSource1[index];
			modelToWrite.Write();
		}
	}
}
