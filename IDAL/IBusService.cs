using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Models;
namespace IDAL
{
    public interface IBusService
    {
        //获取所有公交路线信息
        DataTable GetAllMembers();
        //根据车辆编号获得路线信息
        BusMember GetMemberByID(string id);
        //添加信息
        bool AddMember(BusMember member);
        //修改信息
        bool UpdateMember(BusMember member);
        //根据编号删除信息
        bool DeleteMember(string id);
    }
}
