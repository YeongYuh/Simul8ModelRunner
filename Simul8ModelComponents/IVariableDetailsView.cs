/*
 * Created by SharpDevelop.
 * User: tm300
 * Date: 17/06/2011
 * Time: 15:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using GenericSimulationComponents;

namespace Simul8ModelComponents
{
	/// <summary>
	/// Description of IVariableDetailsView.
	/// </summary>
	public interface IVariableDetailsView
	{
		Variable SelectedVariable{get;set;}
		void ShowVariableDetails();
		
		void VariableSelectedEvent(object sender, VariableGridEventArgs args);
		
	}
}
