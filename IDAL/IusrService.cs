using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace IDAL
{
    public interface IusrService
    {
        User GetUserByNameAndPwd(string uname, string pwd);
    }
}
