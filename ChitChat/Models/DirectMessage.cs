
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChitChat.Models
{
    public class DirectMessage
    {
        public int ID { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Text { get; set; }
        public DateTime When { get; set; }

        public string UserId { get; set; }
        public string Sender { get; set; }
        public virtual ChatUser Reciever { get; set; }
        public DirectMessage()
        {
            When = DateTime.Now;
        }
    }
}
