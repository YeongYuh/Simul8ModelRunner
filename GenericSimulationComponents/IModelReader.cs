/*
 * Created by SharpDevelop.
 * User: tm300
 * Date: 16/06/2011
 * Time: 10:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;

namespace GenericSimulationComponents
{
	public interface IModelReader
	{
		List<Variable> ReadVariables();
		int ReadReplications();
		double ReadRunLength();
		bool IsLoaded{get;}
			
	}
}
