/*
 * Created by SharpDevelop.
 * User: tm300
 * Date: 23/06/2011
 * Time: 10:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Simul8ModelComponents
{
	/// <summary>
	/// Description of ModelSummaryView.
	/// </summary>
	public partial class ModelSummaryView : UserControl
	{
		public ModelSummaryView()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

		}
		
		public void ModelSelected(object sender, ModelSelectedEventArgs args){
			
			this.FileName.Text = args.SelectedModel.ModelName;
			this.FullPath.Text = args.SelectedModel.FileName;
			this.VariableCount.Text = string.Concat(args.SelectedModel.Variables.Count.ToString(), " Variables");
			this.Replications.Text = string.Concat(args.SelectedModel.Replications.ToString(), " Replications");
			this.RunLength.Text = string.Concat("Run length: ", args.SelectedModel.RunLength.ToString());
			//this.pictureType.Image = 
		}
	}
}
