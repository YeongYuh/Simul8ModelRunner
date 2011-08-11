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
	
		public IVariableUpdater Updater{get;set;}
		
		public Variable()
		{
			
		}
		
		public void Update(Variable value){
			this.Updater.Update(value, this);
		}
		
		#region Equals 
		
		/// <summary>
		/// I chose not to use ID here.
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public override bool Equals(object obj)
		{
			Variable other = obj as Variable;
			if (other == null)
				return false;
			
			if(this.Name == other.Name &&  this.PackageVariableType == other.PackageVariableType){
				return true;
			}
			
			return false;
		}
		
		
		public override int GetHashCode()
		{
			int hashCode = 0;
			return hashCode;
		}
		
		public static bool operator ==(Variable lhs, Variable rhs)
		{
			if (ReferenceEquals(lhs, rhs))
				return true;
			if (ReferenceEquals(lhs, null) || ReferenceEquals(rhs, null))
				return false;
			return lhs.Equals(rhs);
		}
		
		public static bool operator !=(Variable lhs, Variable rhs)
		{
			return !(lhs == rhs);
		}
				

		#endregion

	}
}
