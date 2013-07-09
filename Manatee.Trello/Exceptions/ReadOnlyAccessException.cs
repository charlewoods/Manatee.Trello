﻿/***************************************************************************************

	Copyright 2013 Little Crab Solutions

	   Licensed under the Apache License, Version 2.0 (the "License");
	   you may not use this file except in compliance with the License.
	   You may obtain a copy of the License at

		 http://www.apache.org/licenses/LICENSE-2.0

	   Unless required by applicable law or agreed to in writing, software
	   distributed under the License is distributed on an "AS IS" BASIS,
	   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
	   See the License for the specific language governing permissions and
	   limitations under the License.
 
	File Name:		ReadOnlyAccessException.cs
	Namespace:		Manatee.Trello.Exceptions
	Class Name:		ReadOnlyAccessException<T>
	Purpose:		Thrown when attempting to access write operations without a
					valid UserToken.

***************************************************************************************/
using System;

namespace Manatee.Trello.Exceptions
{
	/// <summary>
	/// Thrown when attempting to access write operations without a valid UserToken.
	/// </summary>
	public class ReadOnlyAccessException : Exception
	{
		/// <summary>
		/// Creates a new instance of the ReadOnlyAccessException class.
		/// </summary>
		public ReadOnlyAccessException()
			: base("A valid user token must be supplied to perform write operations.") {}
		/// <summary>
		/// Creates a new instance of the ReadOnlyAccessException class with a custom message.
		/// </summary>
		/// <param name="message">A message.</param>
		public ReadOnlyAccessException(string message)
			: base(message) { }
	}
}
