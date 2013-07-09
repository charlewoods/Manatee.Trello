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
 
	File Name:		MakeNormalMemberOfOrganizationAction.cs
	Namespace:		Manatee.Trello
	Class Name:		MakeNormalMemberOfOrganizationAction
	Purpose:		Indicates a member was made an normal member of an organization.

***************************************************************************************/
using System.Diagnostics;

namespace Manatee.Trello
{
	/// <summary>
	/// Indicates a member was made an normal member of an organization.
	/// </summary>
	public class MakeNormalMemberOfOrganizationAction : Action
	{
		/// <summary>
		/// Creates a new instance of the MakeNormalMemberOfOrganizationAction class.
		/// </summary>
		/// <param name="action"></param>
		public MakeNormalMemberOfOrganizationAction(Action action)
		{
			Debug.Assert(false, string.Format(
				"{0} is not yet configured.  Please post the JSON returned by http://api.trello.com/actions/{1} to https://trello.com/c/k5q97GRf",
				GetType().Name, action.Id));
			VerifyNotExpired();
		}
	}
}