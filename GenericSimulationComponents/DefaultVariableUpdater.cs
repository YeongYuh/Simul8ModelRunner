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
	/// DefaultVariableUpdater: Encapsulates the updating of a standard variable.
	/// </summary>
	public class DefaultVariableUpdater : IVariableUpdater
	{
		public DefaultVariableUpdater()
		{
		}

		public void Update(Variable source, Variable destination)
		{
			destination.Value = source.Value;
		}
	}
}
