/*
 * Created by SharpDevelop.
 * User: tm300
 * Date: 04/08/2011
 * Time: 12:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace GenericSimulationComponents
{
	
	/// <summary>
	/// Encapsulates the updating of variable.  Useful as variable values may not be 
	/// a dotnet type e.g. it might be a spreadsheet.
	/// </summary>
	public interface IVariableUpdater
	{
		void Update(Variable source, Variable destination);
	}
}
