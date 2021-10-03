using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LossType.Models
{
    public class User
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public  string password { get; set; }
        public string displayName { get; set; }
        public bool active { get; set; }
    }
}