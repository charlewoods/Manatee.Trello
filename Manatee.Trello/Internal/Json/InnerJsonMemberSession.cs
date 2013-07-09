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
 
	File Name:		InnerJsonMemberSession.cs
	Namespace:		Manatee.Trello.Internal.Json
	Class Name:		InnerJsonMemberSession
	Purpose:		Internal implementation for IJsonMemberSession.

***************************************************************************************/
using System;
using Manatee.Trello.Json;

namespace Manatee.Trello.Internal.Json
{
	internal class InnerJsonMemberSession : IJsonMemberSession
	{
		public bool? IsCurrent { get; set; }
		public bool? IsRecent { get; set; }
		public string Id { get; set; }
		public DateTime? DateCreated { get; set; }
		public DateTime? DateExpires { get; set; }
		public DateTime? DateLastUsed { get; set; }
		public string IpAddress { get; set; }
		public string Type { get; set; }
		public string UserAgent { get; set; }
	}
}