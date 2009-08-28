using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatSystem
{
	enum MessageType
	{
		Message,
		Emote,
		System,
		Enter,
		Exit
	}
	class Message
	{
		private User poster;
		private string content;
		private MessageType type;

		public Message(User poster, string content, MessageType type)
		{
			this.poster = poster;
			this.content = content;
			this.type = type;
		}

		public Message(User poster, MessageType type)
		{
			this.poster = poster;
			this.content = "";
			this.type = type;
		}

		public Message(string content)
		{
			this.poster = null;
			this.content = content;
			this.type = MessageType.System;
		}

		public string toString()
		{
			switch (type)
			{
				case MessageType.System:
					return content;
				case MessageType.Enter:
					return poster.NickName + " has entered the room.";
				case MessageType.Exit:
					return poster.NickName + " has exited the room.";
				case MessageType.Message:
					return "[" + poster + "] " + content;
				case MessageType.Emote:
					return poster.NickName + " " + content;
				default:
					throw new NotImplementedException("No string representation of the message type: " + type);
			}
		}
	}
}
