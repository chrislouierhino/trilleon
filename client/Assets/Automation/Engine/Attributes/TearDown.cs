/* 
+   This file is part of Trilleon.  Trilleon is a client automation framework.
+  
+   Copyright (C) 2017 Disruptor Beam
+  
+   Trilleon is free software: you can redistribute it and/or modify
+   it under the terms of the GNU Lesser General Public License as published by
+   the Free Software Foundation, either version 3 of the License, or
+   (at your option) any later version.
+
+   This program is distributed in the hope that it will be useful,
+   but WITHOUT ANY WARRANTY; without even the implied warranty of
+   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
+   GNU Lesser General Public License for more details.
+
+   You should have received a copy of the GNU Lesser General Public License
+   along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace TrilleonAutomation {

	//Run AFTER GlobalTearDown (defined in GameMaster) but BEFORE current test's TearDown (if one exists).
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public class TearDownClass : Attribute {

		//Should the Class SetUp be run again if its tests are deferred until the end of a run?
		public bool RunAgainForDeferredTests { get; private set; }

		public TearDownClass(bool RunAgainForDeferredTests = false) {

			this.RunAgainForDeferredTests = RunAgainForDeferredTests;

		}

	}

	//Run AFTER GlobalTearDown (defined in GameMaster) but then AFTER current test's TearDownClass (if one exists).
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public class TearDown : Attribute {}

}