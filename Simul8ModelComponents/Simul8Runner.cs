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

using GenericSimulationComponents;

using System.Runtime.InteropServices;

namespace Simul8ModelComponents
{
	/// <summary>
	/// Description of Simul8Runner.
	/// </summary>
	public class Simul8Runner : IModelRunner
	{
		public SimulationCompleteHandler OnSimulationComplete{get;set;}

		private S8SimulationClass s8;
		
		public Simul8Runner(){}

		public void RunMultipleReplications(string fileName, int replications)
		{
			s8 = new S8SimulationClass();
			s8.Visible = true;
			
			HookupDelegates(s8);
			
			Console.Write("Opening Simul8 model: {0}", fileName);
			s8.Open(fileName);
			s8.TrialSim(replications,false);
			
		}
		
		public void Run(string fileName){
			throw new NotImplementedException();
		}

		void HookupDelegates(S8SimulationClass s8)
		{
			s8.S8SimulationEndTrial += this.SimulationTrialEnded;
		}

		public void SimulationTrialEnded()
		{
			CloseSimul8COMServer();
			BroadcastEndOfTrial();
		}

		/// <summary>
		/// Use of COM is a bit volatile (windows XP crashes sometimes)
		/// This makes sure that the COM server is closed
		/// and the reference to the COM server is released.
		/// </summary>
		void CloseSimul8COMServer()
		{
			s8.Close();
			s8.Quit();

			Marshal.FinalReleaseComObject(s8);
			s8 = null;
		}
		
		
		void BroadcastEndOfTrial()
		{
			if (null != this.OnSimulationComplete) {
				this.OnSimulationComplete(this, new EventArgs());
			}
		}
		
	}
}
