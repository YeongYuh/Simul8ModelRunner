/*
 * Created by SharpDevelop.
 * User: tm300
 * Date: 16/06/2011
 * Time: 10:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;

using GenericSimulationComponents;

namespace Simul8ModelComponents
{
	
	/// <summary>
	/// Simul8 internal spreadsheets
	/// A very simple collection of strings organised by rows and cols
	/// </summary>
	public class S8Spreadsheet : IEnumerable
	{
		public int RowCount{get;set;}
		public int ColCount{get;set;}
				
		public List<Cell> Cells{get;set;}
		
		#region Cell class
		
		/// <summary>
		/// A cell within an S8Spreadsheet
		/// </summary>
		public class Cell{
			public VariableType CellType{get;set;}
			public int Row{get;set;}
			public int Col{get;set;}
			public string Value{get;set;}
			
			public Cell(){}
		}
		
		#endregion
		
		public S8Spreadsheet()
		{
			this.Cells = new List<S8Spreadsheet.Cell>();
		}
		
		/// <summary>
		/// cells are ordered by row and then col.
		/// Use binary sort.
		/// </summary>
		/// <param name="row"></param>
		/// <param name="col"></param>
		/// <returns></returns>
		public Cell GetCell(int row, int col){

			ValidateCellRequest(row, col);
			return SearchCells(row, col);			
		}



		void ValidateCellRequest(int row, int col)
		{
			if (row > this.RowCount) {
				throw new ArgumentOutOfRangeException(string.Concat("There are only ", this.RowCount, " rows in the spreadsheet"));
			} else if (col > this.ColCount) {
				throw new ArgumentOutOfRangeException(string.Concat("There are only ", this.ColCount, " cols in the spreadsheet"));
			}
		}
		
		
		Cell SearchCells(int row, int col)
		{
			Cell found = new Cell();
			foreach (Cell c in this.Cells) {
				if (c.Row == row) {
					if (c.Col == col) {
						found = c;
						break;
					}
				}
			}
			return found;
		}
		

		/// <summary>
		/// Returns the maximum row containing data
		/// </summary>
		/// <returns></returns>
		public int LastColContainingData(){
			int maxCol = 0;
			
			foreach(Cell cell in this.Cells){
				if(cell.Col > maxCol){
					maxCol = cell.Col;
				}
			}
			
			return maxCol;
		}
		
		
		/// <summary>
		/// Iterator pattern for spreadsheet cells
		/// </summary>
		/// <returns></returns>
		public IEnumerator GetEnumerator(){
			
			foreach(Cell cell in this.Cells){
				yield return cell;
			}
		}
		
		
	}
}
