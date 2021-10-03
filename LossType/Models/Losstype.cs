using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LossType.Models
{
    public class Losstype
    {
        public int LossTypeId { get; set; }
        public string LossTypeCode { get; set; }
        public string LossTypeDescription { get; set; }
        public bool Active { get; set; }
        public string LastUpdatedDate { get; set; }
        public int LastUpdatedId { get; set; }
        public string CreatedDate { get; set; }
        public int CreatedId { get; set; }
    }
}