﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAL;
using Model;
using Microsoft.AspNetCore.Cors;

namespace WMS_API.Controllers
{
    [EnableCors("wms")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        UserManagement Users = new UserManagement();
        [HttpGet]
        public PageInfo Get(int currentPage = 1, int pageSize = 5)
        {
            var list = Users.UserShow();
            var p = new PageInfo
            {
                //总记录数
                totalCount = list.Count()
            };
            //计算总页数
            if (p.totalCount == 0)
            {
                p.totalPage = 1;
            }
            else if (p.totalCount % pageSize == 0)
            {
                p.totalPage = p.totalCount / pageSize;
            }
            else
            {
                p.totalPage = (p.totalCount / pageSize) + 1;
            }
            //纠正当前页不正确的值
            if (currentPage < 1)
            {
                currentPage = 1;
            }
            if (currentPage > p.totalPage)
            {
                currentPage = p.totalPage;
            }
            p.users = list.Skip(pageSize * (currentPage - 1)).Take(pageSize).ToList();
            p.currentPage = currentPage;
            return p;
        }

        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/User
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // 修改状态
        [HttpPut("{id}")]
        public int PutUser([FromBody] UserInfo u)
        {
            return Users.UptUser(u);
        }
        [HttpPut("{id}")]
        public int PutUser1([FromBody] UserInfo u)
        {
            return Users.UptUser1(u);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
