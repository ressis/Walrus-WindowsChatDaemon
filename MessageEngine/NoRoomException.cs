using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageEngine
{
	public class NoRoomException : Exception
	{
		public NoRoomException(string message) : base(message)
		{
		}
	}
}
