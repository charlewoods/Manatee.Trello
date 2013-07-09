/***************************************************************************************

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
 
	File Name:		InnerJsonToken.cs
	Namespace:		Manatee.Trello.Internal.Json
	Class Name:		InnerJsonToken
	Purpose:		PURPOSE

***************************************************************************************/
using System;
using System.Collections.Generic;
using Manatee.Trello.Json;

namespace Manatee.Trello.Internal.Json
{
	internal class InnerJsonToken : IJsonToken
	{
		public string Id { get; set; }
		public string Identifier { get; set; }
		public string IdMember { get; set; }
		public DateTime? DateCreated { get; set; }
		public DateTime? DateExpires { get; set; }
		public List<IJsonTokenPermission> Permissions { get; set; }
	}
}