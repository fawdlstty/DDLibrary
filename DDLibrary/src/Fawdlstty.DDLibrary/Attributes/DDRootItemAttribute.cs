using System;
using System.Collections.Generic;
using System.Text;

namespace Fawdlstty.DDLibrary.Attributes {
	public class DDRootItemAttribute: Attribute {
		public bool Primary { get; set; } = false;
		public bool Increment { get; set; } = false;
	}
}
