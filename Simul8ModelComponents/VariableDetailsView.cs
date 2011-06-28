/*
 * Created by SharpDevelop.
 * User: tm300
 * Date: 17/06/2011
 * Time: 16:59
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
	/// Description of VariableDetailsView.
	/// </summary>
	public partial class VariableDetailsView : UserControl, IVariableDetailsView 
	{
		public VariableDetailsView()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
		}
		
		public Variable SelectedVariable{get;set;}
		
		public void ShowVariableDetails(){
			this.bindingSource1.Clear();
			this.bindingSource1.Add(this.SelectedVariable);
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		
		public void VariableSelectedEvent(object sender, VariableGridEventArgs args){
			
			this.SelectedVariable = args.SelectedVariable;
			this.SetupGridForVariable();
			this.ShowVariableDetails();
			this.dataGridView1.AutoResizeColumns();
			
		}
		
		void SetupGridForVariable(){
			if(this.SelectedVariable.PackageVariableType == VariableType.Spreadsheet){
				this.dataGridView1.Columns[1].Visible = false;
				this.dataGridView1.Columns[2].Visible = false;
			}else{
				this.dataGridView1.Columns[1].Visible = true;
				this.dataGridView1.Columns[2].Visible = true;
			}
		}
	}
}
