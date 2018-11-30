using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrelloClone.Models
{
    public class Boards
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUser_Id { get; set; }
    }
}