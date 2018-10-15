using System;
using System.Collections.Generic;
using System.Text;

namespace ZHCG.Data.Entity
{
    public class Users : IPrivilege
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public long CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public long UpdateUserId { get; set; }
    }
}
