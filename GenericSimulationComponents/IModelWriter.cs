/*
 * Created by SharpDevelop.
 * User: tm300
 * Date: 24/06/2011
 * Time: 10:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace GenericSimulationComponents
{
	/// <summary>
	/// Writes a model to file
	/// </summary>
	public interface IModelWriter
	{
		ModelMetaClass Model{get;set;}
		string OutputFileName {get;}
		void Write();
	}
}
