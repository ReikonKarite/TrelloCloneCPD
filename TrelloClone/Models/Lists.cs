using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrelloClone.Models
{
    public class Lists
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }

        public Boards Boards { get; set; }
        public int BoardID { get; set; }

    }
}