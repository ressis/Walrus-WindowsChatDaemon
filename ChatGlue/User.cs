using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatGlue
{
	public class User : IEquatable<User>
	{
		private string id;
		private string nick;

		public string ID
		{
			get
			{
				return id;
			}
		}

		public string NickName
		{
			get
			{
				return nick;
			}
		}

		public User(string id, string nick)
		{
			this.id = id;
			this.nick = nick;
		}

		#region IEquatable<User> Members

		public bool Equals(User other)
		{
			return other.id == this.id;
		}

		#endregion
	}
}
