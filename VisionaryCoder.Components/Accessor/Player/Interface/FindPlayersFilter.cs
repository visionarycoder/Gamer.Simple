﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionaryCoder.Components.Accessor.Player.Interface
{
	public class FindPlayersFilter
	{
		public List<Guid> PlayerIds { get; set; } = new List<Guid>();
	}
}