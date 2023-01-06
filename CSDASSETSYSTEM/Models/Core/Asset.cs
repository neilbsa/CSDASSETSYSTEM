using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSDASSETSYSTEM.Models.Core
{
    public class Asset
    {
        public int Id { get; set; }
        public string AssetCode { get; set; }
        public string AssetName { get; set; }
        public string AssetType { get; set; }
        public string Serial { get; set; }
        public string model { get; set; }
        public double price { get; set; }
        public DateTime DatePurchased { get; set; }
        public int Warranty { get; set; }
    }
}