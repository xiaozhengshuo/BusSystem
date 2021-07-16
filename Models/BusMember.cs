using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BusMember
    {
        #region 成员变量
        private int number;
        private string line;
        private string deleteflag;
        
        #endregion

        #region 成员属性
        public string Deleteflag
        {
            get { return deleteflag; }
            set { deleteflag = value; }
        }
        public string Line
        {
            get { return line; }
            set { line = value; }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        
        #endregion

    }
}
