using ChitChat.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChitChat.Models
{
    public class ViewModel
    {
        public IEnumerable<Message> Messages { get; set; }
        public IEnumerable<ChatUser> User { get; set; }
    }
}
