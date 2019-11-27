using Fawdlstty.DDLibrary.Attributes;
using Fawdlstty.DDLibrary.Implement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example1.Entity {
	/// <summary>
	/// 用户实体跟，根据这个建表
	/// </summary>
	[DDRoot]
	public class User {
		[DDRootItem (Increment = true)]
		public long id { get; set; }
	}

	/// <summary>
	/// 用户基本信息
	/// </summary>
	public class UserInfo: DDRefRoot<User> {
		public string name { get; set; }
		public int age { get; set; }
	}

	/// <summary>
	/// 用户班级
	/// </summary>
	public class UserClass: DDRefRoot<User> {
		public string class_name { get; set; }
		public int grade { get; set; }
	}

	/// <summary>
	/// 用户身份信息，name与类UserInfo的name是同一个字段
	/// </summary>
	public class UserAuth: DDRefRoot<User> {
		public string name { get; set; }
		public string idnum { get; set; }
	}
}
