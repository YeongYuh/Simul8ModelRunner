/*
 * Created by SharpDevelop.
 * User: tm300
 * Date: 21/06/2011
 * Time: 14:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Simul8ModelComponents
{
	/// <summary>
	/// Description of SpreadSheetRow.
	/// </summary>
	public class SpreadSheetRow
	{
		public List<string> Cells{get;set;}
		
		public SpreadSheetRow(int columnCount)
		{
			this.Cells = new List<string>();
			this.SetInitialCols(columnCount);
		}
		
		private void SetInitialCols(int count){
			for(int col = 1; col<=count; col++){
				this.Cells.Add("");
			}
		}
		
		public void AddColumn(){
			this.Cells.Add("");
		}
		
	}
}
