/*
 * Created by SharpDevelop.
 * User: tm300
 * Date: 20/06/2011
 * Time: 10:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using SIMUL8;

namespace GenericSimulationComponents
{
	public delegate void SimulationCompleteHandler(object sender, EventArgs e);

	public interface IModelRunner
	{
		SimulationCompleteHandler OnSimulationComplete{get;set;}
		void RunMultipleReplications(string fileName, int replications);
		void Run(string fileName);
	}
}
