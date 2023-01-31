﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppChat.Models
{
    public class Message
    {
        public int Id { get; set; }
      
        public string UserName { get; set; }

        public string Text { get; set; }

        public DateTime When { get; set; }
    }
}