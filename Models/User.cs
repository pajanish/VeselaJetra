﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace JeeBerryHome3.Models
{
    public class User
    {
        public String Id { get; set; }
        public String ImageUrl { get; set; }
        public String Username { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Password { get; set; }
        public bool Validated { get; set; }
        public String Type { get; set; } //CLIENT, ADMIN
    }
}