/*
 * Created by SharpDevelop.
 * User: tm300
 * Date: 23/06/2011
 * Time: 14:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;

using System.IO;

using GenericSimulationComponents;

namespace Simul8ModelComponents
{
	/// <summary>
	/// Writes an XML file compatable with Simul8
	/// </summary>
	public class Simul8XMLWriter : IModelWriter
	{
		public ModelMetaClass Model{get;set;}
		public string OutputFileName{get;set;}
		private XElement modelXML;
		
		public Simul8XMLWriter()
		{
			
		}
		
		
		/// <summary>
		/// Converts the model to an XML file.
		/// </summary>
		public void Write(){
			
			LoadOriginalXML();
			UpdateVariables();
			SaveModifiedModel();
		}

		
		void LoadOriginalXML()
		{
			this.modelXML = XElement.Load(this.Model.FileName);
		}
		

		void UpdateVariables()
		{
			RemoveVariableXML();

			WriteVariables(this.modelXML.Descendants("LogicObjects").FirstOrDefault());
		}
		
		void RemoveVariableXML()
		{
			this.modelXML.Descendants("Variable").Remove();
		}


		/// <summary>
		/// Writes the variables as xml
		/// </summary>
		protected void WriteVariables(XElement varXML){
			
			VariableXMLWriter varWriter = new VariableXMLWriter();
			
			foreach(Variable v in this.Model){
				varWriter.ToWrite = v;
				varXML.AddFirst(varWriter.Write());
			}			
			
		}
		
		
		void SaveModifiedModel()
		{
			//string outputPath = Model.FileName.Substring(0, this.Model.FileName.LastIndexOf("\\"));
			//this.OutputFileName = string.Concat(outputPath, "\\modified_", Model.ModelName);
			this.modelXML.Save(this.OutputFileName);
			
		}

	}
}
