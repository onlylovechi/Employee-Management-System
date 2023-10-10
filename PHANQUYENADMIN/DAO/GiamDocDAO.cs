using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PHANQUYENADMIN.DAO
{
    internal class GiamDocDAO
    {
        public static int createThongBao(string matb, string doituong, string noidung)
        {
            string query = "INSERT INTO ADMIN01.THONGBAO (MaTB,DOITUONG, NOIDUNG) VALUES ('" + matb + "','" + doituong + "', '" + noidung + "')";
             int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result;
        }
        public static int checkMaTB(string matb)
        {
            string query = "select count(*) from ADMIN01.THONGBAO where MATB = '"+matb+"'";
            int result = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return result;
        }
    }
    
}
