﻿using BrightLine.CMS.Service;
using BrightLine.CMS.Services;
using BrightLine.Common.Framework;
using BrightLine.Common.Models;
using BrightLine.Common.Models.Lookups;
using BrightLine.Common.Utility;
using BrightLine.Common.Utility.Authentication;
using BrightLine.Common.ViewModels;
using BrightLine.Common.ViewModels.Models;
using BrightLine.Core;
using BrightLine.Tests.Component.CMS.Validator_Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BrightLine.Tests.Common.Mocks
{
	public partial class MockEntities
	{
		public static List<Blueprint> CreateBlueprints()
		{
			var blueprints = new List<Blueprint>();
			blueprints.Add(new Blueprint { Id = 1, Name = "blueprint1" });

			return blueprints;
		}

	}

}