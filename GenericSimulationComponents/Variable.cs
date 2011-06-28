/*
 * Created by SharpDevelop.
 * User: tm300
 * Date: 16/06/2011
 * Time: 10:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace GenericSimulationComponents
{
	/// <summary>
	/// Represents a variable within the simulation package
	/// </summary>
	public class Variable
	{
		public string ID{get;set;}
		public string Name{get;set;}
		public object Value{get;set;}
		public object ResetValue{get;set;}
		public VariableType PackageVariableType{get;set;}
		public string Notes{get;set;}
	
		public Variable()
		{
			
		}
	}
}
