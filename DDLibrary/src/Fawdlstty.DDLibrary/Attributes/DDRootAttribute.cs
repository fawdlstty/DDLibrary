using System;
using System.Collections.Generic;
using System.Text;

namespace Fawdlstty.DDLibrary.Attributes {
	public class DDRootAttribute: Attribute {
		public bool RecordHistory { get; set; } = false;
	}
}
