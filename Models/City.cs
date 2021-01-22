﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sehir_Rehberi.API.Models
{
    public class City
    {   public City()
        {
            Photos = new List<photo>();
        }
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<photo> Photos { get; set; }
        public User User { get; set; }
    }
}