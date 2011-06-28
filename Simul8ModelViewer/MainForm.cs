/*
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
	}
}
