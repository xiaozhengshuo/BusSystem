using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
   public class BusService
    {
        #region 查看数据库中公交线路信息
        public DataTable GetAllMembers()
       {
           StringBuilder sbsql = new StringBuilder();
           sbsql.Append("Select  ");
           sbsql.Append("*  ");
           sbsql.Append("From  ");
           sbsql.Append("bus_Message    ");
           sbsql.Append("Where    bus_Message.deleteflag=0");
           DataSet ds = new DataSet();
           SqlConnection con = null;
           try
           {

               con = new SqlConnection(UserService.ConnectionString);
               con.Open();
               SqlCommand cmd = new SqlCommand(sbsql.ToString(), con);
               SqlDataAdapter da = new SqlDataAdapter();
               da.SelectCommand = cmd;
               da.Fill(ds, "Members");
               if (ds.Tables["Members"].Rows.Count > 0)
               {
                   return ds.Tables["Members"];
               }
           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message);
           }
           finally
           {
               if (con.State == ConnectionState.Open)
               {
                   con.Close();
               }
           }
           return null;
       }
        #endregion
        #region 插入数据库中公交线路信息

        public static int addid;
        public static string addro;
        public DataTable AddBus()
        {
                StringBuilder sbsql01 = new StringBuilder();
                sbsql01.Append("INSERT INTO   ");
                sbsql01.Append("bus_Message(number,line,deleteflag)    ");
                sbsql01.Append("values("+addid+",'"+addro+"',"+"0)   ");
                sbsql01.Append("Select  ");
                sbsql01.Append("*  ");
                sbsql01.Append("From  ");
                sbsql01.Append("bus_Message    ");
                sbsql01.Append("Where    bus_Message.deleteflag=0");
                DataSet ds = new DataSet();
                SqlConnection con = null;
                try
                {
                    con = new SqlConnection(UserService.ConnectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sbsql01.ToString(), con);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(ds, "Members");
                    if (ds.Tables["Members"].Rows.Count > 0)
                    {
                        return ds.Tables["Members"];
                    }
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
                return null;
        }
        #endregion
        #region 删除数据库中公交线路信息
        public static int deletId;
        public DataTable DelteBus()
        {
            StringBuilder sbsql02 = new StringBuilder();
            sbsql02.Append("DELETE  FROM  ");
            sbsql02.Append("bus_Message  ");
            sbsql02.Append("WHERE   number=" + deletId);
            sbsql02.Append("Select  ");
            sbsql02.Append("*  ");
            sbsql02.Append("From  ");
            sbsql02.Append("bus_Message    ");
            sbsql02.Append("Where    bus_Message.deleteflag=0");
            DataSet ds = new DataSet();
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(UserService.ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(sbsql02.ToString(), con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds, "Members");
                if (ds.Tables["Members"].Rows.Count > 0)
                {
                    return ds.Tables["Members"];
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return null;
        }
        #endregion
    }
}
