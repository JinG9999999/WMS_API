﻿using System;
using System.Collections.Generic;

namespace Model
{
    public partial class StockoutDetail
    {
        public int StockInDetailId { get; set; }
        public int? StockOutId { get; set; }
        public int Status { get; set; }
        public int? PlanOutQty { get; set; }
        public int? ActOutQty { get; set; }
        public int? StoragerackId { get; set; }
        public string AuditinId { get; set; }
        public DateTime? AuditinTime { get; set; }
        public string Remark { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
