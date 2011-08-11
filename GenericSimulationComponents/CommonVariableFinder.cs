/*
 * Created by SharpDevelop.
 * User: tm300
 * Date: 03/08/2011
 * Time: 12:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

using System.Collections.Generic;

namespace GenericSimulationComponents
{
	/// <summary>
	/// For a given scenario returns a list of common variables
	/// </summary>
	public class CommonVariableFinder
	{
		
		public Scenario SelectedScenario{get;set;}
		public Dictionary<string, List<Variable>> Common{get;set;}
		
		public CommonVariableFinder()
		{
			this.Common = new Dictionary<string, List<Variable>>();
		}
		
		
		public void GetCommonVariables(){
					
			ModelMetaClass referenceModel = this.SelectedScenario[0];
			
			SearchUsingReferenceModel(referenceModel);
			
			
		}




		void SearchUsingReferenceModel(ModelMetaClass referenceModel)
		{
			foreach (Variable searchVariable in referenceModel) {
				//this.Common[searchVariable.Name].Add(searchVariable);
				this.Common.Add(searchVariable.Name, new List<Variable>());
				this.Common[searchVariable.Name].Add(searchVariable);
				SearchAllModels(referenceModel, searchVariable);
				RemoveIfNoneFound(searchVariable);
			}
		}




		void SearchAllModels(ModelMetaClass referenceModel, Variable searchVariable)
		{
			foreach (ModelMetaClass model in this.SelectedScenario) {
				if (!model.Equals(referenceModel)) {
					SearchWithinCurrentModel(searchVariable, model);
				}
			}
		}

		

		//quit loop for current model;
		void SearchWithinCurrentModel(Variable searchVariable, ModelMetaClass model)
		{
			foreach (Variable currentVariable in model) {
				if (currentVariable.Equals(searchVariable)) {
					this.Common[searchVariable.Name].Add(currentVariable);
					break;
				}
			}
		}

		//if none found;
		void RemoveIfNoneFound(Variable searchVariable)
		{
			if (this.Common[searchVariable.Name].Count == 1) {
				this.Common.Remove(searchVariable.Name);
			}
		}
		
		
		/// <summary>
		/// Set all variables with common name and type to the same value
		/// </summary>
		/// <param name="referenceVariable"></param>
		public void UpdateCommonVariables(Variable referenceVariable){
			
			foreach(var currentVariable in this.Common[referenceVariable.Name]){
				currentVariable.Update(referenceVariable);
			}
		}
		
	}
}
