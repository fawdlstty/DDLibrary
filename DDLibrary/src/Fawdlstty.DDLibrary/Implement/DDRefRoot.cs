using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fawdlstty.DDLibrary.Implement {
	public class DDRefRoot<T> where T : class {
		private T t = null;
		public T get_object () {
			return t;
		}
		public bool insert () {
			return false;
		}
		public async Task<bool> insert_async () {
			return false;
		}
		public bool update () {
			return false;
		}
		public async Task<bool> update_async () {
			return false;
		}
	}
}
