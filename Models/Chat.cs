using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppChat.Models
{

    public class Chat
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Message> Messages { get; set; }
        
        public ICollection<AppUser> Users { get; set; }

        public ChatType  Type { get; set; }
       
    }
    

}
