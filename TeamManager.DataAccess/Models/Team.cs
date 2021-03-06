﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace TeamManager.DataAccess.Models
{
    public class Team
    {
        [Key]
        public int ID { get; set; }
        public string TeamName { get; set; }
        public byte [] Image { get; set; }
        public int City { get; set; } 
        public string WebSite { get; set; }

        public virtual ICollection<Player> Players { get; set; }
        public virtual ICollection<Game> HomeGames { get; set; }
        public virtual ICollection<Game> GuestGames { get; set; }
		public virtual ICollection<Point> Points { get; set; }
    }
}