using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
using System.Data;

namespace BLL
{
   public class BusManage
    {
       public DataTable GetAllMembers()
       {
           try
           {
               BusService memberdal = new BusService();
               return memberdal.GetAllMembers();
           }
           catch (Exception ex)
           {
               throw new Exception(ex.ToString());
           }
       }
        public DataTable AddBus()
       {
           try
           {
               BusService memberdal = new BusService();
               return memberdal.AddBus();
           }
           catch (Exception ex)
           {
               throw new Exception(ex.ToString());
               
           }
       }

        public DataTable DeletBus()
        {
            try
            {
                BusService deletdal = new BusService();
                return deletdal.DelteBus();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }
    }
}
