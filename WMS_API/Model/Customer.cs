﻿using System;
using System.Collections.Generic;

namespace Model
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string CarrierPerson { get; set; }
        public int? CarrierLevel { get; set; }
        public string Email { get; set; }
        public bool? IsDel { get; set; }
        public string Remark { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
    public class PageCustomer
    {
        public List<Customer> Customers { get; set; }

        public int TotalCount { get; set; }//总记录数

        public int TotalPage { get; set; }//总页数

        public int CurrentPage { get; set; }//当前页
    }
}
