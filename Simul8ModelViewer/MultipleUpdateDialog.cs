/*
 * Created by SharpDevelop.
 * User: tm300
 * Date: 04/08/2011
 * Time: 13:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

using GenericSimulationComponents;
using Simul8ModelComponents;

namespace Simul8ModelViewer
{
	/// <summary>
	/// Description of MultipleUpdateDialog.
	/// </summary>
	public partial class MultipleUpdateDialog : Form
	{
		private Variable selected;
		
		public CommonVariableFinder Common{get;set;}
		
		
		public Variable SelectedVariable{
			get{
				return selected;
			}set{
				this.selected = value;

				BroadcastSelectionEvent(value);
			}
		}

		void BroadcastSelectionEvent(Variable value)
		{
			if (null != this.OnVariableSelected) {
				this.OnVariableSelected(this, new VariableGridEventArgs { SelectedVariable = value });
			}
		}
		
		
		public VariableSelectedHandler OnVariableSelected;
		
		public MultipleUpdateDialog()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			HookupComponents();
		}
		
		void HookupComponents()
		{
			this.OnVariableSelected += this.variableDetailsView1.VariableSelectedEvent;
			this.OnVariableSelected += this.sheetView1.VariableSelectedEvent;
		
		}
		
		void VariableSelected(object sender, VariableGridEventArgs args){
			this.SelectedVariable = args.SelectedVariable;
		}
		
		void UpdateAllClick(object sender, EventArgs e)
		{
			if(this.sheetView1.HasUpdates){
				this.sheetView1.UpdateCells();
			}
			
			this.Common.UpdateCommonVariables(SelectedVariable);
			MessageBox.Show("Update complete");
			this.Close();
		}
	}
}
