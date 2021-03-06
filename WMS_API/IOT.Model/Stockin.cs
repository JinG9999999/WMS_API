﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IOT.Model
{
    public partial class Stockin
    {
        public int StockInId { get; set; }
        public string StockInType { get; set; }
        public int? SupplierId { get; set; }
        public int? OrderNo { get; set; }
        public bool? StockInStatus { get; set; }
        public bool? IsDel { get; set; }
        public string Remark { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
