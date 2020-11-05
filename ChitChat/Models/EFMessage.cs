using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChitChat.Data;

namespace ChitChat.Models
{
    public class EFMessage : IMessage
    {
        private ChitChatContext context;

        public EFMessage(ChitChatContext ctx)
        {
            context = ctx;
        }
        public IQueryable<ChatUser> User => context.Users;
    }
}
