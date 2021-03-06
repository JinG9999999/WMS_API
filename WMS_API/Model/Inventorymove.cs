﻿using System;
using System.Collections.Generic;

namespace Model
{
    public partial class Inventorymove
    {
        public int InventorymoveId { get; set; }
        public int SourceStoragerackId { get; set; }
        public int AimStoragerackId { get; set; }
        public int Status { get; set; }
        public bool IsDel { get; set; }
        public string Remark { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string StorageRackName { get; set; }
    }
    public class PageInventorymove
    {
        public List<Inventorymove> Inventorymoves { get; set; }

        public int TotalCount { get; set; }//总记录数

        public int TotalPage { get; set; }//总页数

        public int CurrentPage { get; set; }//当前页
    }
}
