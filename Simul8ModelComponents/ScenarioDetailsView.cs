/*
 * Created by SharpDevelop.
 * User: tm300
 * Date: 15/07/2011
 * Time: 09:27
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
	/// <summary>
	/// Description of ScenarioDetailsView.
	/// </summary>
	public partial class ScenarioDetailsView : UserControl
	{
		
		public Scenario SelectedScenario{get;set;}
		
		
		public ScenarioDetailsView()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void ScenarioSelected(object sender, ScenarioEventArgs args){
			this.SelectedScenario = args.SelectedScenario;
			this.txtName.Text = this.SelectedScenario.Name;
			this.lblOutPath.Text = this.SelectedScenario.OutputDirectory;
			this.lblInPath.Text = this.SelectedScenario.InputDirectory;
			this.lblPrefix.Text = this.SelectedScenario.FilePrefix;
		}
		
		
		
		void BtSetOutputPathClick(object sender, EventArgs e)
		{
			if(DialogResult.OK == this.folderBrowserDialog1.ShowDialog()){
				this.lblOutPath.Text = this.folderBrowserDialog1.SelectedPath;

				this.SelectedScenario.OutputDirectory = this.folderBrowserDialog1.SelectedPath;
			}
		}
		
		void LblPrefixTextChanged(object sender, EventArgs e)
		{
			this.SelectedScenario.FilePrefix = this.lblPrefix.Text;
		}
		
		void TxtNameTextChanged(object sender, EventArgs e)
		{
			this.SelectedScenario.Name = this.txtName.Text;
		}
	}
}
