/*
 * Created by SharpDevelop.
 * User: tm300
 * Date: 04/08/2011
 * Time: 13:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using GenericSimulationComponents;

namespace Simul8ModelComponents
{
	/// <summary>
	/// Description of SpreadsheetUpdater.
	/// </summary>
	public class SpreadsheetVariableUpdater : IVariableUpdater 
	{
		public SpreadsheetVariableUpdater()
		{
			
		}
		
		public void Update(Variable source, Variable destination){
			
			S8Spreadsheet sourceSheet = (S8Spreadsheet)source.Value;			
			S8Spreadsheet destinationSheet = (S8Spreadsheet)destination.Value;
			
			foreach(S8Spreadsheet.Cell cell in sourceSheet){
				
				try{
					S8Spreadsheet.Cell toUpdate = destinationSheet.GetCell(cell.Row, cell.Col);
					toUpdate.Value = cell.Value;
				}catch(ArgumentOutOfRangeException){
					destinationSheet.Cells.Add(new S8Spreadsheet.Cell(){Row = cell.Row, Col = cell.Col, Value = cell.Value});
				}
				
			}
			
			destination.Value = destinationSheet;

		}
	}
}
