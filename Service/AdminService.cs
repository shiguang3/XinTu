using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF;
using Common;

namespace Service
{
    public class AdminService
    {
        public void A()
        {
            using (MyDbContext ctx = new MyDbContext())
            {
                Admin admin = new Admin();
                admin.Name = "超级管理员";
                admin.PhoneNum = "17670618563";
                admin.Pwd = MD5Help.GetMd5String("123456");
                ctx.Admin.Add(admin);
                ctx.SaveChanges();
            }
        }
    }
}
