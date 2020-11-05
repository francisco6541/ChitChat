﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChitChat.Models
{
    public interface IMessage
    {
        IQueryable<ChatUser> User { get; }
    }
}
