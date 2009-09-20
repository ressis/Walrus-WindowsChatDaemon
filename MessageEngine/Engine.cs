using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChatGlue;

namespace MessageEngine
{
	public class Engine
	{
		private Dictionary<string, WalrusStructures.CircularQueue<Message>> roomMessages;
		private int capacity;

		public Engine(int capacity)
		{
			this.capacity = capacity;
			roomMessages = new Dictionary<string, WalrusStructures.CircularQueue<Message>>();
		}

		public void addRoom(string roomID){
			if (roomMessages.ContainsKey(roomID))
				return;
			roomMessages.Add(roomID, new WalrusStructures.CircularQueue<Message>(capacity));
		}

		public Int64 addMessage(string roomID, Message message)
		{
			if (roomMessages.ContainsKey(roomID))
				return roomMessages[roomID].push(message);
			throw new NoRoomException("No room found with the ID: " + roomID);
		}

		public Message[] getMessages(string roomID, Int64 lastIndex)
		{
			if (roomMessages.ContainsKey(roomID))
				return roomMessages[roomID].peekFrom(lastIndex);
			throw new NoRoomException("No room found with the ID: " + roomID);
		}
	}
}
