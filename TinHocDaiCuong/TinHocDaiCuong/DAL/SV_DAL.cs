using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinHocDaiCuong.DTO;

namespace TinHocDaiCuong.DAL
{
    
    public class SV_DAL
    {

        public DataHelper dh { get; set; }
        public SV_DAL()
        {
            this.dh = new DataHelper("Data Source=DESKTOP-DB97OO9;Initial Catalog=CuoiKi;Integrated Security=True");
        }


        public int checkSV_DAL(SV s)
        {
            if (s.MatKhau == s.MSSV)
            {
                string que = "select count (*) from SV where MSSV = '" + s.MSSV + "'";
                int a = dh.ExecuteScalar(que);
                if (a == 1) return 1;
                else return 0;
            }
            else return 0;
        }
       
        public SV getSV_DAL(string s)
        {
            string que = "Select * from SV where MSSV = '"+s+"'";
            SV sv = new SV();
            DataTable dt = dh.getTable(que);
            foreach (DataRow r in dt.Rows)
            {
                sv.MSSV = r["MSSV"].ToString();
                sv.Ten = r["Tên SV"].ToString();
                sv.Lop = r["Lớp"].ToString();
            }

            return sv;
        }
    }
}
