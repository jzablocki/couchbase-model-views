﻿#region [ License information          ]
/* ************************************************************
 * 
 *    @author Couchbase <info@couchbase.com>
 *    @copyright 2012 Couchbase, Inc.
 *    
 *    Licensed under the Apache License, Version 2.0 (the "License");
 *    you may not use this file except in compliance with the License.
 *    You may obtain a copy of the License at
 *    
 *        http://www.apache.org/licenses/LICENSE-2.0
 *    
 *    Unless required by applicable law or agreed to in writing, software
 *    distributed under the License is distributed on an "AS IS" BASIS,
 *    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *    See the License for the specific language governing permissions and
 *    limitations under the License.
 *    
 * ************************************************************/
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CouchbaseModelViews.Framework
{
	public enum ReduceOptions { None, Count, Sum };

	public class ViewDefinition
	{
		/// <summary>
		/// Name of map function
		/// </summary>
		public string Name { get; set; }

		private List<string> _keyProperties = new List<string>();

		/// <summary>
		/// Key(s) to be included in index
		/// </summary>
		public IList<string> KeyProperties { get { return _keyProperties; } }

		/// <summary>
		/// A string representing a built in reduce function
		/// </summary>
		public ReduceOptions Reduce { get; set; }

		/// <summary>
		/// The value to emit in the index, defaults to null
		/// </summary>
		public string Value { get; set; }
	}
}
