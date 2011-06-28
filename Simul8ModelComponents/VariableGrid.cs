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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using GenericSimulationComponents;

namespace Simul8ModelComponents
{
	
	public delegate void VariableSelectedHandler(object sender, VariableGridEventArgs args);
	
	public class VariableGridEventArgs : EventArgs{
		public Variable SelectedVariable{get;set;}
		
		public VariableGridEventArgs(){}
	}
	
	/// <summary>
	/// A simple method for displaying all variables in a simulation model
	/// </summary>
	public partial class VariableGrid : UserControl
	{
		public IVariableDetailsView LinkedVariableDetailsView{get;set;}
		
		public VariableSelectedHandler OnVariableSelectedEvent;
		
		public VariableGrid()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
		}
		
		public void AddVariable(Variable toAdd){
			this.bindingSource1.Add(toAdd);
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex >= 0){
				
				var v = (Variable)this.bindingSource1[e.RowIndex];
				BroadcastVariableSelected(v);
				CheckXML(v);
			}
			
		}
		
		
		private void CheckXML(Variable toCheck){
			VariableXMLWriter writer = new VariableXMLWriter(){ToWrite = toCheck};
				
			Console.WriteLine(writer.Write().Value.ToString());
		}

		void BroadcastVariableSelected(Variable v)
		{
			if (null != this.OnVariableSelectedEvent) {
				this.OnVariableSelectedEvent(this, new VariableGridEventArgs { SelectedVariable = v });
			}
		}
		
		public void ModelSelected(object sender, ModelSelectedEventArgs args){
			
			LoadModel(args);
			AddModelVariablesToBindingSource(args);
			
		}


		void LoadModel(ModelSelectedEventArgs args)
		{
			ModelMetaClass selectedModel = args.SelectedModel;
			if (!selectedModel.IsLoaded)
				args.SelectedModel.Load();
		}
		
		void AddModelVariablesToBindingSource(ModelSelectedEventArgs args)
		{
			this.bindingSource1.Clear();
			foreach (Variable toAdd in args.SelectedModel) {
				this.AddVariable(toAdd);
			}
		}



		
		void DataGridView1CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			var currentVariable = (Variable)this.bindingSource1[e.RowIndex];
			if(currentVariable.PackageVariableType == VariableType.Spreadsheet){
				e.CellStyle.BackColor = Color.LightGreen;
			}else if(currentVariable.PackageVariableType == VariableType.Number){
				e.CellStyle.BackColor = Color.LightSkyBlue;
			}else{
				e.CellStyle.BackColor = Color.LightCyan;
			}
		}
	}
}