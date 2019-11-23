using System;
using System.Collections.Generic;
using System.Text;

namespace Fawdlstty.DDLibrary.Attributes {
	public class DDGroupItemAttribute: Attribute {
		public string UniqueGroup { get; set; } = "";
	}
}
