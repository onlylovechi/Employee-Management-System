using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANQUYENADMIN.DAO
{
    internal class NhanVienDAO
    {
        public static DataTable loadTB()
        {
            String query = "SELECT * FROM ADMIN01.THONGBAO";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        //  NhanVien +PhanCong
        public static DataTable loadStaff()
        {
            String query = "SELECT * FROM ADMIN01.vw_NHANVIEN_XemThongTinCaNhan";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static String get_Logged_in_Role()
        {
            String query = "SELECT * FROM ADMIN01.vw_NHANVIEN_XemThongTinCaNhan";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count == 0)
            {
                return "Admin";
            }
            return dt.Rows[0]["VaiTro"].ToString();
        }
        public static int update_Inf(string date,string addr,string sodt)
        {
            
            String query = "BEGIN ADMIN01.usp_NHANVIEN_SuaThongTin("
                + "'"+date+"'" + "," + "'"+addr+"'" + "," + "'"+sodt+"'" + "); END;";     
            return DataProvider.Instance.ExecuteNonQuery(query);
            
        }
        public static DataTable loadTasks()
        {
            String query = "SELECT * FROM ADMIN01.PHANCONG";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable loadPB()
        {
            String query = "SELECT * FROM ADMIN01.vw_NHANVIEN_XemPhongBan";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable loadDA()
        {
            String query = "SELECT * FROM ADMIN01.DEAN";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        // Query cua quan ly truc tiep
        public static DataTable loadTasks(string manv)
        {
            String query = "SELECT * FROM ADMIN01.vw_QLTRUCTIEP_XemThongTinPhanCong where MANV='" + manv+"'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable loadStaffInf(string manv)
        {
            String query = "SELECT * FROM ADMIN01.vw_QLTRUCTIEP_XemThongTinNhanVien where MANV='" + manv+"'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable loadDanhSachNhanVien()
        {
            String query = "SELECT * FROM ADMIN01.vw_QLTRUCTIEP_XemThongTinNhanVien";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static string Execute_pr_CheckNhanVien(string manhanvien)
        {
            string query = "begin ADMIN01.pr_CheckNhanVien('" + manhanvien + "'); end;";
            string result = DataProvider.Instance.ExecuteScalar(query).ToString();
            return result;
        }
        public static DataTable readNHANVIEN()
        {
            String query = null;
            if (fLogin.ROLE == "Nhan su")
            {
                query = "SELECT * FROM ADMIN01.VIEW_NHANVIEN_NS";
            }
            else if (fLogin.ROLE == "Truong phong")
            {
                query = "Select * from ADMIN01.vw_TRUONGPHONG_Xem_NHANVIEN";
            }
            else if (fLogin.ROLE == "Nhan vien")
            {
                query = "SELECT * FROM ADMIN01.vw_NHANVIEN_XemThongTinCaNhan";
            }
            else if (fLogin.ROLE == "QL truc tiep")
            {
                query = "SELECT * FROM ADMIN01.vw_QLTRUCTIEP_XemThongTinNhanVien";
            }
            else if (fLogin.ROLE == "Tai chinh")
            {
                query = "select * from ADMIN01.vw_TAICHINH_Xem_NHANVIEN";
            }
            else if (fLogin.ROLE == "Truong de an")
            {
                query = "SELECT * FROM ADMIN01.vw_NHANVIEN_XemThongTinCaNhan";
            }
            else if (fLogin.ROLE == "Ban giam doc")
            {
                query = "select * from ADMIN01.vw_TAICHINH_Xem_NHANVIEN";
            }
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable filteredNHANVIEN(string manv)
        {
            String query = null;
            if (fLogin.ROLE == "Nhan su")
            {
                query = "SELECT * FROM ADMIN01.VIEW_NHANVIEN_NS where MANV = '"+manv+"'";
            }
            else if (fLogin.ROLE == "Truong phong")
            {
                query = "Select * from ADMIN01.vw_TRUONGPHONG_Xem_NHANVIEN where MANV = '" + manv + "'";
            }
            else if (fLogin.ROLE == "Nhan vien")
            {
                query = "SELECT * FROM ADMIN01.vw_NHANVIEN_XemThongTinCaNhan where MANV = '" + manv + "'";
            }
            else if (fLogin.ROLE == "QL truc tiep")
            {
                query = "SELECT * FROM ADMIN01.vw_QLTRUCTIEP_XemThongTinNhanVien where MANV = '" + manv + "'";
            }
            else if (fLogin.ROLE == "Tai chinh")
            {
                query = "select * from ADMIN01.vw_TAICHINH_Xem_NHANVIEN where MANV = '" + manv + "'";
            }
            else if (fLogin.ROLE == "Truong de an")
            {
                query = "SELECT * FROM ADMIN01.vw_NHANVIEN_XemThongTinCaNhan where MANV = '" + manv + "'";
            }
            else if (fLogin.ROLE == "Ban giam doc")
            {
                query = "select * from ADMIN01.vw_TAICHINH_Xem_NHANVIEN where MANV = '" + manv + "'";
            }
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
