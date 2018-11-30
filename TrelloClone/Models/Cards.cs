using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrelloClone.Models
{
    public class Cards
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }

        public Lists Lists { get; set; }
        public int ListID { get; set; }
    }
}