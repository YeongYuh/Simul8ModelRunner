/*
 * Created by SharpDevelop.
 * User: tm300
 * Date: 17/06/2011
 * Time: 15:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using System.Data;

using GenericSimulationComponents;

namespace Simul8ModelComponents
{
	/// <summary>
	/// Description of SheetView.
	/// </summary>
	public partial class SheetView : UserControl, IVariableDetailsView
	{
		
		private Variable selected;
		private DataTable dataSheet;
		private const string TABLE_NAME = "Sheet";
		
		public SheetView()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			dataSheet = new DataTable(TABLE_NAME);
			dataSheet.RowChanged += DataRowUpdated;
			this.dataGrid1.AllowSorting = false;
			

		}
		
		
		
		public bool HasUpdates{get;set;}
		
		public Variable SelectedVariable{
			get{
				return this.selected;
			}set{
				this.selected = value;
			}
		}
	
		
		public void VariableSelectedEvent(object sender, VariableGridEventArgs args){
			
			if(this.HasUpdates)
				this.UpdateCells();
			
			ClearDataSource();
			
			if(args.SelectedVariable.PackageVariableType == VariableType.Spreadsheet){
				this.SelectedVariable = args.SelectedVariable;
				this.ShowVariableDetails();
				this.Enabled = true;
			}else{
				this.Enabled = false;
			}
		}
		
		
		
		
		public void UpdateCells(){
			
			int row = 0;
			S8Spreadsheet sheet = (S8Spreadsheet)this.SelectedVariable.Value;
			
			foreach(DataRow dRow in this.dataSheet.Rows){
				
				for(int col=0; col<dataSheet.Columns.Count; col++){
					sheet.GetCell(row+1, col+1).Value = dRow[col].ToString();
				}
				
				row++;
			}
			
			this.HasUpdates = false;
			
		}

		void ClearDataSource()
		{
			this.dataSheet.Clear();
			this.dataSheet.Columns.Clear();
			this.dataSheet.Rows.Clear();
			if(this.dataGrid1.TableStyles.Count > 0){
				this.dataGrid1.TableStyles[TABLE_NAME].GridColumnStyles.Clear();
				this.dataGrid1.TableStyles.Clear();
			}
			
		}
		
		public void ShowVariableDetails(){
			S8Spreadsheet sheet = (S8Spreadsheet)this.SelectedVariable.Value;
			
			DataGridTableStyle style = new DataGridTableStyle();
			style.MappingName = TABLE_NAME;
			style.AllowSorting = false;
			
			
			CreateTableCols(ref dataSheet, ref style);
			CreateTableRows(ref dataSheet);
			TransposeSheet(ref dataSheet);
			BindToDataSource();
			
			this.dataGrid1.TableStyles.Add(style);
			
			this.HasUpdates = false;
			
			
		}


		
		public void DataRowUpdated(object sender, DataRowChangeEventArgs args){
			if(args.Action == DataRowAction.Change){
				this.HasUpdates = true;
			}
		}
		
		void CreateTableCols(ref DataTable dataSheet, ref DataGridTableStyle style)
		{
			S8Spreadsheet sheet = (S8Spreadsheet)this.SelectedVariable.Value;
			int maxCol = sheet.LastColContainingData();
			
			style.GridColumnStyles.Clear();
		
			for (int i = 1; i <= maxCol; i++) {
				dataSheet.Columns.Add("column" + i.ToString(), typeof(string));
				DataGridColumnStyle c = new DataGridTextBoxColumn();
				c.MappingName = "column" + i.ToString();
				c.NullText = "";

				if(null == style.GridColumnStyles[c.MappingName]){
					style.GridColumnStyles.Add(c);
				}
				
				
			}
		}

		void CreateTableRows(ref DataTable dataSheet)
		{
			S8Spreadsheet sheet = (S8Spreadsheet)this.SelectedVariable.Value;
			
			for (int i = 1; i <= sheet.RowCount; i++) {
				dataSheet.Rows.Add(dataSheet.NewRow());
			}
		}

		void TransposeSheet(ref DataTable dataSheet)
		{
			S8Spreadsheet sheet = (S8Spreadsheet)this.SelectedVariable.Value;
			
			foreach (var cell in sheet.Cells) {
				dataSheet.Rows[cell.Row - 1][cell.Col - 1] = cell.Value.ToString();
			}
		}
		
		
		void BindToDataSource()
		{
			this.dataView1.Table = dataSheet;
			this.dataGrid1.DataSource = this.dataView1;
		}
		
		

		//public void ExternalUpdateOfCells(object sender, 
		
	}
}
