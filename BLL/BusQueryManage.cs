using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
namespace BLL
{
   public class BusQueryManage
    {
        public BusMember Getnumber(int number)
        {
            UserQueryService uqs = new UserQueryService();
            return uqs.Getnumber(number);
        }

        public BusMember Getline(string line01,string line02)
        {
            UserQueryService uqs = new UserQueryService();
            return uqs.Getline(line01,line02);
        }
    }
}
