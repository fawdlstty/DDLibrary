using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example1.Entity;
using Fawdlstty.DDLibrary.Implement;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Example1.Controllers {
	[ApiController]
	[Route ("api/[controller]/[action]")]
	public class UserController: ControllerBase {
		/// <summary>
		/// 新建用户
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		[HttpPost]
		public long create (string name, int age) {
			var _info = new UserInfo { name = name, age = age };
			_info.insert ();
			return _info.get_object ()?.id ?? 0;
		}

		[HttpGet]
		public string get_info (long uid) {
			var _info = DDFactory<UserInfo, User>.query ((_tmp) => _tmp.id == 0);
			return _info.ToString ();
		}
	}
}
