/*
 * Created by SharpDevelop.
 * User: tm300
 * Date: 23/06/2011
 * Time: 15:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;

using GenericSimulationComponents;

namespace Simul8ModelComponents
{
	/// <summary>
	/// Represents a Simul8 Variable in XML
	/// </summary>
	public class VariableXMLWriter
	{
		public Variable ToWrite{get;set;}
		
		public VariableXMLWriter()
		{
		}
		

		/// <summary>
		/// Return the Simul8 variable as XML
		/// </summary>
		/// <returns></returns>
		public XElement Write()
		{
			if(ToWrite.PackageVariableType == VariableType.Spreadsheet){
				return this.WriteSpreadsheet();
			}else{
				return this.WriteStandardVariable();
			}

		}
		
		
		protected XElement WriteStandardVariable(){
			XElement xVar = new XElement("Variable", 
			                              new XAttribute("ID", ToWrite.ID.ToString()), 
			                              new XAttribute("Name", ToWrite.Name), 
			                              new XAttribute("Type", ((int)ToWrite.PackageVariableType).ToString()),
			                              new XElement("Notes", ToWrite.Notes), 
			                              new XElement("Value", ToWrite.Value.ToString()),
			                              new XElement("ResetValue", ToWrite.ResetValue.ToString()));
		
					
			return xVar;
		}
		
		
		/// <summary>
		/// This should probably be encapsulated out
		/// </summary>
		/// <returns></returns>
		protected XElement WriteSpreadsheet()
		{
			S8Spreadsheet sheet = (S8Spreadsheet)ToWrite.Value;
			
			XElement xVar = new XElement("Variable", 
			                              new XAttribute("ID", ToWrite.ID.ToString()), 
			                              new XAttribute("Name", ToWrite.Name), 
			                              new XAttribute("Type", ((int)ToWrite.PackageVariableType).ToString()),
			                              new XElement("Notes", ToWrite.Notes), 
			                              new XElement("Cols", sheet.ColCount.ToString()),
			                              new XElement("Rows", sheet.RowCount.ToString()));
		
					
	
			xVar.Add(WriteCells().Select(s => s));
			return xVar;

		}
		
		
		
		protected IEnumerable<XElement> WriteCells(){
			S8Spreadsheet sheet = (S8Spreadsheet)ToWrite.Value;
			
			var cells = from cell in sheet.Cells 
				select new XElement("Cell", 
				                    new XAttribute("Type", ((int)cell.CellType).ToString()),
				                    new XAttribute("Row", cell.Row.ToString()),
				                    new XAttribute("Col", cell.Col.ToString()),
				                    cell.Value);
			
			return cells;
			
		}
		
		
	}
}
