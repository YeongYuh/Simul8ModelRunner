﻿/*
 * Created by SharpDevelop.
 * User: tm300
 * Date: 16/06/2011
 * Time: 10:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

using GenericSimulationComponents;

using Simul8ModelComponents;

namespace Simul8ModelViewer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		

		
		
		public VariableSelectedHandler OnVariableSelected;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			HookupComponents();
			
		}

		void HookupComponents()
		{
			this.variableGrid1.OnVariableSelectedEvent += this.variableDetailsView1.VariableSelectedEvent;
			this.variableGrid1.OnVariableSelectedEvent += this.sheetView1.VariableSelectedEvent;
			this.modelRunList1.OnModelSelected += this.variableGrid1.ModelSelected;
			this.modelRunList1.OnModelSelected += this.modelSummaryView1.ModelSelected;
			this.modelRunList1.OnModelRunComplete += this.Update;
		
			this.modelRunList1.OnModelRemoved += this.scenarioList1.ModelRemoved;
			
			this.scenarioList1.OnScenarioSelected += this.modelRunList1.NewScenarioSelected;
			this.scenarioList1.OnRunScenario += this.modelRunList1.RunScenario;
			
			this.OnVariableSelected += this.sheetView1.VariableSelectedEvent;
			
		}
		
		void BtRunModelClick(object sender, EventArgs e)
		{
			this.btRunModel.Enabled = false;
			
			//use bkgrnd worker as application will freeze while 
			//opening initial Simul8 model.
			//this.backgroundWorker1.RunWorkerAsync();
			this.modelRunList1.RunModels();			
		}
		
		void BackgroundWorker1RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			
		}
		
		void BackgroundWorker1ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			
		}
		
		void BackgroundWorker1DoWork(object sender, DoWorkEventArgs e)
		{
			this.modelRunList1.RunModels();
		}
		
		public void RunComplete(object sender, EventArgs args){
			this.btRunModel.Enabled = true;
		}
		
		
		public void Update(object sender, EventArgs args){
			//UpdateEventArgs e = (UpdateEventArgs)args;
			//this.toolStripStatusLabel1.Text = e.Message;
			//this.toolStripProgressBar1.Value = (int)e.PercentageComplete;
			
		}
		
		void RunAllToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.btRunModel.Enabled = false;
			
			//use bkgrnd worker as application will freeze while 
			//opening initial Simul8 model.
			this.backgroundWorker1.RunWorkerAsync();	
		}
		
		
		void OpenToolStripMenuItemClick(object sender, EventArgs e)
		{
			
			this.openFileDialog1.Multiselect = false;
			this.openFileDialog1.Filter = "Scenario list *.scl | *.scl";
			this.openFileDialog1.Title = "Select scenario list file";
			
			if(DialogResult.OK == this.openFileDialog1.ShowDialog()){
				this.scenarioList1.Open(this.openFileDialog1.FileName);
			}
		
					
		}
		
		void SaveStripMenuItemClick(object sender, EventArgs e)
		{
			this.saveFileDialog1.Filter = "Scenario list *.scl | *.scl";
			this.saveFileDialog1.Title = "Save scenario list to file";
			
			if(DialogResult.OK == this.saveFileDialog1.ShowDialog()){
				this.scenarioList1.SaveAs(saveFileDialog1.FileName);
			}
			
		}
		
		void UpdateAcrossAllModelsInScenarioToolStripMenuItemClick(object sender, EventArgs e)
		{
			CommonVariableFinder common = new CommonVariableFinder{SelectedScenario = this.scenarioList1.SelectedScenario};
			common.GetCommonVariables();

			MultipleUpdateDialog dialog = new MultipleUpdateDialog();
			dialog.SelectedVariable = this.variableDetailsView1.SelectedVariable;
			dialog.Common = common;
			dialog.Closed += this.MultipleUpdateDialogClose;

			dialog.ShowDialog();
		}
		
		public void MultipleUpdateDialogClose(object sender, EventArgs args){
			this.BroadcastSelectionEvent(this.variableDetailsView1.SelectedVariable);
		}
		
		void BroadcastSelectionEvent(Variable value)
		{
			if (null != this.OnVariableSelected) {
				this.OnVariableSelected(this, new VariableGridEventArgs { SelectedVariable = value });
			}
		}
	}
}
