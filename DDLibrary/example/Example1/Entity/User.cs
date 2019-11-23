using Fawdlstty.DDLibrary.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example1.Entity {
	[DDRoot]
	public class User {
		[DDRootItem (Increment = true)]
		public long id { get; set; }
	}
}
