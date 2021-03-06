﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace dal
{
    public class CarrierDal
    {
        //显示承运商
        public List<Carrier> CarrierShow()
        {
            string str = "select * from Carrier  where IsDel=0";
            return DBHelper.GetToList<Carrier>(str);
        }

        //反填承运商
        public Carrier Find(int id)
        {
            string str = $"select * from Carrier  where CarrierId={id}";
            return DBHelper.GetToList<Carrier>(str)[0];
        }


        //修改承运商(删除操作)
        public int DelCarrier(Carrier c)
        {
            string str = $"update Carrier set IsDel=1 ,ModifiedBy='{c.ModifiedBy}', ModifiedDate=getdate()  where CarrierId in ({c.CarrierId})";
            return DBHelper.ExecuteNonQuery(str);
        }

        //修改承运商信息
        public int UptCarrier(Carrier c)
        {
            string str = $"update Carrier set CarrierName='{c.CarrierName}',[Address]='{c.Address}',Tel='{c.Tel}',CarrierPerson='{c.CarrierPerson}',Email='{c.Email}',Remark='{c.Remark}',ModifiedBy='{c.ModifiedBy}',ModifiedDate=GETDATE() where CarrierId={c.CarrierId}";
            return DBHelper.ExecuteNonQuery(str);
        }

        //新增承运商
        public int AddCarrier(Carrier c)
        {
            string str = $"insert into Carrier values('{c.CarrierName}','{c.Address}','{c.Tel}','{c.CarrierPerson}',{c.CarrierLevel},'{c.Email}',0,'{c.Remark}','{c.ModifiedBy}',getdate(),'{c.ModifiedBy}',getdate())";
            return DBHelper.ExecuteNonQuery(str);
        }

        //查看删除记录
        public List<Carrier> DelShow()
        {
            string str = "select * from Carrier where IsDel=1";
            return DBHelper.GetToList<Carrier>(str);
        }
    }
}
