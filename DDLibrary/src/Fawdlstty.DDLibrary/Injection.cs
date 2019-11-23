using Fawdlstty.DDLibrary.Attributes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Reflection;

namespace Fawdlstty.DDLibrary {
	public static class Injection {
		public static void UseDDLibrary (this IServiceCollection services, Assembly executing_library) {
			var _entitys = (from p in executing_library.GetTypes () let q = p.GetCustomAttributes (typeof (DDRootAttribute), true) where (q?.Length ?? 0) > 0 select Tuple.Create ((DDRootAttribute) q [0], p)).ToList ();
			foreach (var (_attr, _entity) in _entitys) {

			}
		}
	}
}
