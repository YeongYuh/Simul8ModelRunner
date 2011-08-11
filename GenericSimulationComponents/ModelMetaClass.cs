/*
 * Created by SharpDevelop.
 * User: tm300
 * Date: 17/06/2011
 * Time: 09:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;

using System.Runtime.Serialization;

namespace GenericSimulationComponents
{
	/// <summary>
	/// Describes a simulation model and the variables contained within it.
	/// </summary>
	[Serializable]
	public class ModelMetaClass : IEnumerable, ISerializable
	{
		protected string fileName;
		protected bool loaded = false;
		public SimulationCompleteHandler OnSimulationComplete;
		
		public string ModelName{get;set;}
		public IModelReader Reader{get;set;}
		public IModelRunner Runner{get;set;}
		public IModelWriter Writer{get;set;}
		public List<Variable> Variables{get;set;}
		public int Replications{get;set;}
		public double RunLength{get;set;}
		
		public string FileName{
			get{
				return this.fileName;
			}set{
				this.fileName = value;
				ParseModelName();
			}
		}
		
		public string OutputFileName{
			get{
				return this.Writer.OutputFileName;
			}
			set{
				this.Writer.OutputFileName = value;
			}
		}
		
		public bool IsLoaded{
			get{
				return this.loaded;
			}
		}
		
		
		public ModelMetaClass()
		{
			
		}
		
		private void ParseModelName(){
			this.ModelName = this.fileName.Substring(fileName.LastIndexOf(@"\") + 1);
		}
		
		public void Load(){

			LoadVariables();
			LoadReplications();
			LoadRunLength();
			
			this.loaded = true;
		}

		void LoadVariables()
		{
			try {
				this.Variables = this.Reader.ReadVariables();
			} catch (NullReferenceException e) {
				Console.WriteLine("Reader could not return variables from model");
				Console.WriteLine(string.Concat(e.Message, e.StackTrace));
				this.Variables = new List<Variable>();
			}
		}

		void LoadReplications()
		{
			try {
				this.Replications = this.Reader.ReadReplications();
			} catch (NullReferenceException e) {
				Console.WriteLine("Reader could not return replications");
				Console.WriteLine(string.Concat(e.Message, e.StackTrace));
				this.Replications = 0;
			}
		}

		void LoadRunLength()
		{
			try {
				this.RunLength = this.Reader.ReadRunLength();
			} catch (NullReferenceException e) {
				Console.WriteLine("Reader could not return run length");
				Console.WriteLine(string.Concat(e.Message, e.StackTrace));
				this.RunLength = 0;
			}
		}
		
		/// <summary>
		/// Iterator pattern for simulation variables
		/// </summary>
		/// <returns></returns>
		public IEnumerator GetEnumerator(){
			
			if(!IsLoaded){
				this.Load();
			}
			
			foreach(Variable variable in this.Variables){
				yield return variable;
			}
		}
		
		/// <summary>
		/// Run the simulation model using the number of replications 
		/// </summary>
		public void Run(){
			this.Runner.OnSimulationComplete += this.SimulationComplete;
			Console.WriteLine("Now running {0}", this.ModelName);
			this.Runner.RunMultipleReplications(this.Writer.OutputFileName, this.Replications);
		}
		
		public void SimulationComplete(object sender, EventArgs args){
			Console.WriteLine("Simulation using model {0} complete.", this.FileName);
			if(null != this.OnSimulationComplete){
				this.OnSimulationComplete(sender, args);
			}
		}
		
		
		public void Write(){
			this.Writer.Model = this;
			this.Writer.Write();
		}
		
		#region Equals implementation
		public override bool Equals(object obj)
		{
			ModelMetaClass other = obj as ModelMetaClass;
			if (other == null)
				return false;
			return this.fileName == other.fileName;
		}
 		
		
		public override int GetHashCode()
		{
			int hashCode = 0;
			unchecked {
				if (fileName != null)
					hashCode += 1000000007 * fileName.GetHashCode();
				hashCode += 1000000009 * loaded.GetHashCode();
				if (OnSimulationComplete != null)
					hashCode += 1000000021 * OnSimulationComplete.GetHashCode();
			}
			return hashCode;
		}
		
		public static bool operator ==(ModelMetaClass lhs, ModelMetaClass rhs)
		{
			if (ReferenceEquals(lhs, rhs))
				return true;
			if (ReferenceEquals(lhs, null) || ReferenceEquals(rhs, null))
				return false;
			return lhs.Equals(rhs);
		}
		
		public static bool operator !=(ModelMetaClass lhs, ModelMetaClass rhs)
		{
			return !(lhs == rhs);
		}
		
		#endregion

		
		
				/// <summary>
		/// Called by serilalisation interface
		/// </summary>
		/// <param name="info"></param>
		/// <param name="ctxt"></param>
		public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
		{

		   
              
		}
		
		
		/// <summary>
		/// Searilization constructor
		/// </summary>
		/// <param name="info"></param>
		/// <param name="ctxt"></param>
		public ModelMetaClass(SerializationInfo info, StreamingContext ctxt)
		{
		    //Get the values from info and assign them to the appropriate properties
		
		    
		    
		    
		    
		}
		
		
	}
}
