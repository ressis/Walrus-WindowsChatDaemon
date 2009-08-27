using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatSystem
{
    class ChatRoomUser : User
    {
        public ChatRoomUser(string id, string nick)
            : base(id,nick)
        {
        }
    }
}
