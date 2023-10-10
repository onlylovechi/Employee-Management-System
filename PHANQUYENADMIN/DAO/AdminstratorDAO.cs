using PHANQUYENADMIN.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANQUYENADMIN.DAO
{
    internal class AdminstratorDAO
    {
        public static bool changeUserPassword(String user,String password, String confirmpasword)
        {
            if(password==null && confirmpasword == null)
            {
                return false;
                
            }
            if (password.Equals(confirmpasword)&& password!="")
            {
                String query = "ALTER USER "+user+" IDENTIFIED BY " + confirmpasword;
                DataProvider.Instance.ExecuteNonQuery(query);
                return true;
            }
            else
            {
                return false;
            }
        }
        
       
        //form nhan su

        public static DataTable readPHONGBAN()
        {
            String query = "SELECT * FROM ADMIN01.PHONGBAN";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
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
                query = "Select * from ADMIN01.NHANVIEN";
            }
            else if (fLogin.ROLE == "Nhan vien"  || fLogin.ROLE =="Truong de an" )
            {
                query = "SELECT * FROM ADMIN01.vw_NHANVIEN_XemThongTinCaNhan";
            }
            else if (fLogin.ROLE == "QL truc tiep")
            {
                query = "SELECT * FROM ADMIN01.vw_QLTRUCTIEP_XemThongTinNhanVien";
            }
            else if (fLogin.ROLE == "Tai chinh")
            {
                query = "SELECT * FROM ADMIN01.NHANVIEN";
            }
            else if (fLogin.ROLE == "Ban giam doc")
            {
                query = "SELECT * FROM ADMIN01.NHANVIEN";
            }
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static int checkMaPHONGBAN(string MAPB)
        {
            String query = "SELECT count(*) FROM ADMIN01.PHONGBAN WHERE MAPB='"+MAPB+"'";
            int result = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return result;
        }
        public static int checkMaNHANVIEN(string MANV)
        {
            String query = "SELECT count(*) FROM ADMIN01.VIEW_NHANVIEN_NS WHERE MANV='" + MANV + "'";
            int result = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return result;
        }
        public static int updatePHONGBAN(string MAPB,string TENPB,string TRPHG)
        {
            String query = "UPDATE ADMIN01.PHONGBAN SET TENPB='"+ TENPB + "', TRPHG='"+ TRPHG + "' WHERE MAPB='"+ MAPB + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result;

        }
        public static int createPHONGBAN(string MAPB, string TENPB, string TRPHG)
        {
            String query = "INSERT INTO ADMIN01.PHONGBAN(MAPB,TENPB,TRPHG) VALUES ('"+ MAPB + "','"+ TENPB + "','"+ TRPHG + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result;

        }
        public static int updateNHANVIEN(string MANV, string TENNV, string PHAI, string NGAYSINH, string DIACHI, string SODT, string VAITRO, string MANQL, string PHG)
        {
            String query = "UPDATE ADMIN01.VIEW_NHANVIEN_NS SET TENNV='"+ TENNV + "', PHAI='"+ PHAI + "', NGAYSINH=TO_DATE('"+ NGAYSINH + "', 'YYYY-MM-DD'), DIACHI='" + DIACHI + "', SODT='"+ SODT + "', VAITRO='"+ VAITRO + "', MANQL='"+ MANQL + "', PHG='"+ PHG + "' WHERE MANV='" + MANV + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result;

        }
        public static int createNHANVIEN(string MANV, string TENNV, string PHAI, string NGAYSINH, string DIACHI, string SODT, string VAITRO, string MANQL, string PHG)
        {
            String query = "INSERT INTO ADMIN01.VIEW_NHANVIEN_NS (MANV, TENNV, PHAI, NGAYSINH, DIACHI, PHUCAP, VAITRO, MANQL, PHG)  VALUES ('"+ MANV + "', '"+ TENNV + "', '"+ PHAI + "', TO_DATE('"+ NGAYSINH + "', 'YYYY-MM-DD'), '"+ DIACHI + "', '"+SODT+"',  '"+VAITRO+"', '"+MANQL+"', '"+PHG+"')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result;

        }
        //end
        public static int updateNHANVIENnv(string NGAYSINH, string DIACHI, string SODT)
        {
            String query = "ADMIN01.usp_NHANVIEN_SuaThongTin('"+NGAYSINH+"','"+DIACHI+"','"+SODT+"')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result;

        }
        public static DataTable readUsersys()
        {
            String query = "SELECT * FROM DBA_users where default_tablespace='MY_TABLESPACE'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable readSYSprivs(string name)
        {
            String query = "SELECT * FROM DBA_SYS_PRIVS WHERE GRANTEE = '" + name + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable readTABprivs(string name)
        {
            String query = "SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE = '" + name + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable readROLEprivs(string name)
        {
            String query = "SELECT * FROM DBA_ROLE_PRIVS WHERE GRANTEE = '" + name + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static void dropUser(string username)
        {
            String query = "alter session set \"_ORACLE_SCRIPT\" = TRUE";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            query = "drop user " + username;
            result = DataProvider.Instance.ExecuteNonQuery(query);
        }
        public static void dropRole(string rolename)
        {
            String query = "alter session set \"_ORACLE_SCRIPT\" = TRUE";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            query = "drop role " + rolename;
            result = DataProvider.Instance.ExecuteNonQuery(query);

        }
        public static int checkUserName(string username)
        {

            String query = "SELECT count(username) FROM all_users where username = '" + username + "'";
            int result = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return result;
        }
        public static void createUser(string username, string pw)
        {
            String query = "alter session set \"_ORACLE_SCRIPT\" = TRUE";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            query = " create user " + username + " IDENTIFIED BY " + pw + " DEFAULT TABLESPACE my_tablespace";
            result = DataProvider.Instance.ExecuteNonQuery(query);
        }
        public static int checkRoleName(string rolename)
        {
            String query = "select count(ROLE) from DBA_ROLES where ROLE = '" + rolename + "'";
            int result = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return result;
        }
        public static void createRole(string rolename)
        {
            String query = "alter session set \"_ORACLE_SCRIPT\" = TRUE";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            query = " create role " + rolename;
            result = DataProvider.Instance.ExecuteNonQuery(query);
        }
        public static DataTable loadUser()
        {
            String query = "SELECT username FROM dba_users where default_tablespace='MY_TABLESPACE'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable loadUserRole()
        {
            String query = "SELECT ROLE R FROM DBA_ROLES where ROLE LIKE 'R%' ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable loadUserPrivilege()
        {
            String query = "SELECT distinct(PRIVILEGE) FROM DBA_SYS_PRIVS";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable loadTable()
        {
            String query = "SELECT TABLE_NAME FROM DBA_TABLES WHERE TABLESPACE_NAME='MY_TABLESPACE'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static void Role2User(String user,List<GrantRoleForm> grantRoles)
        {
            foreach (GrantRoleForm item in grantRoles)
            {
                try
                {
                    if (item.Grant == true)
                    {
                        String query = "grant " + item.RoleName.ToString() + " to " + user;
                        if (item.AdminOption == false)
                        {
                            DataProvider.Instance.ExecuteNonQuery(query);
                        }
                        else
                        {
                            query += "with admin option";
                            DataProvider.Instance.ExecuteNonQuery(query);
                        }
                    }
                    else if (item.Revoke == true)
                    {
                        String query = "revoke " + item.RoleName + " from " + user;
                    }
                }
                catch (Exception e)
                {
                   
                }
            }
        }
        public static void Privilege2User(String user,List<GrantRoleForm> grantRoles)
        {
            foreach (GrantRoleForm item in grantRoles)
            {
                try
                {
                    if (item.Grant == true)
                    {
                        String query = "grant " + item.RoleName + " to " + user;
                        if (item.AdminOption == false)
                        {
                            DataProvider.Instance.ExecuteNonQuery(query);
                        }
                        else
                        {
                            query += "with admin option";
                            DataProvider.Instance.ExecuteNonQuery(query);
                        }
                    }
                    else if (item.Revoke == true)
                    {
                        String query = "revoke " + item.RoleName + " from " + user;
                    }
                }
                catch (Exception e)
                {
                    
                }
            }
        }
        public static void Table2User(String user,List<GrantTableForm> grantTables)
        {
            foreach(GrantTableForm item in grantTables)
            {
                try { 
                String revoke = "revoke";
                String query = "grant ";
                String select = " select ";
                String update = " update ";
                String insert = " insert ";
                String delete = " delete ";


                    if (item.revoke != true)
                    {
                        String table = " on " + item.TableName + " to " + user;
                        if (item.Select == true)
                        {
                            
                            DataProvider.Instance.ExecuteNonQuery(query + select + table);
                        }
                        if (item.Update == true)
                        {
                            DataProvider.Instance.ExecuteNonQuery(query + update + table);
                        }
                        if (item.Insert == true)
                        {
                            DataProvider.Instance.ExecuteNonQuery(query + insert + table);
                        }
                        if (item.Delete == true)
                        {
                            DataProvider.Instance.ExecuteNonQuery(query + delete + table);
                        }
                    }
                    else if (item.revoke == true)
                    {
                        String table = " on " + item.TableName + " from " + user;
                        if (item.Select == true)
                        {
                            
                            DataProvider.Instance.ExecuteNonQuery(revoke + select + table);
                        }
                        if (item.Update == true)
                        {
                            
                            DataProvider.Instance.ExecuteNonQuery(revoke + update + table);
                        }
                        if (item.Insert == true)
                        {
                            DataProvider.Instance.ExecuteNonQuery(revoke + insert + table);
                        }
                        if (item.Delete == true)
                        {
                            DataProvider.Instance.ExecuteNonQuery(revoke + delete + table);
                        }
                    }
                   
                }
                catch (Exception e)
                {
                    
                }
            }
        }
        public static void Role2Role(String role, List<GrantRoleForm> grantRoles)
        {
            foreach (GrantRoleForm item in grantRoles)
            {
                try
                {
                    if (item.Grant == true)
                    {
                        String query = "grant " + item.RoleName.ToString() + " to " + role;

                        if (item.AdminOption == false)
                        {
                            DataProvider.Instance.ExecuteNonQuery(query);
                        }
                        else
                        {
                            query += " with admin option";
                            DataProvider.Instance.ExecuteNonQuery(query);
                        }
                    }
                    else if (item.Revoke == true)
                    {
                        String query = "revoke " + item.RoleName + " from " + role;
                        DataProvider.Instance.ExecuteNonQuery(query);
                    }
                }
                catch (Exception e)
                {
                    
                }
            }
        }
        public static void Privilege2Role(String role, List<GrantRoleForm> grantRoles)
        {
            foreach (GrantRoleForm item in grantRoles)
            {
                try
                {
                    if (item.Grant == true)
                    {
                        String query = "grant " + item.RoleName + " to " + role;
                        if (item.AdminOption == false)
                        {
                            DataProvider.Instance.ExecuteNonQuery(query);
                        }
                        else
                        {
                            query += "with admin option";
                            DataProvider.Instance.ExecuteNonQuery(query);
                        }
                    }
                    else if (item.Revoke == true)
                    {
                        String query = "revoke " + item.RoleName + " from " + role;
                        DataProvider.Instance.ExecuteNonQuery(query);
                    }
                }
                catch (Exception e)
                {
                    
                }
            }
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

        public static DataTable TAICHINH_select_NHANVIEN()
        {
            String query = "select * from ADMIN01.vw_TAICHINH_Xem_NHANVIEN;";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public static DataTable TAICHINH_select_PHANCONG()
        {
            String query = "select * from ADMIN01.PHANCONG";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public static int updateNHANVIEN(string MANV, string LUONG, string PHUCAP)
        {
            String query = "UPDATE ADMIN01.vw_TAICHINH_Xem_NHANVIEN SET LUONG=" + LUONG + ", PHUCAP=" + PHUCAP + " WHERE MANV='" + MANV + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result;

        }

        public static DataTable TRUONGDEAN_select_DEAN()
        {
            String query = "select * from ADMIN01.DEAN";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        internal static int updateDEAN(string MADA, string TENDA, string NGAYBD, string PHONG)
        {
            String query = "UPDATE ADMIN01.DEAN SET TENDA='" + TENDA + "', NGAYBD= TO_DATE('" + NGAYBD + "', 'YYYY-MM-DD'), PHONG = '" + PHONG + "' WHERE MADA='" + MADA + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result;
        }

        internal static int checkMaDEAN(string MADA)
        {
            String query = "SELECT count(*) FROM ADMIN01.DEAN WHERE MADA='" + MADA + "'";
            int result = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return result;
        }

        internal static void TRUONGDEAN_add_DEAN(string MADA, string TENDA, string NGAYBD, string PHONG)
        {
            String query = "INSERT INTO ADMIN01.DEAN(MADA,TENDA,NGAYBD,PHONG) VALUES ('" + MADA + "','" + TENDA + "',TO_DATE('" + NGAYBD + "','YYYY-MM-DD'),'" + PHONG + "')";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
        }

        internal static void TRUONGDEAN_remove_DEAN(string MADA, string TENDA, string NGAYBD, string PHONG)
        {
            String query = "DELETE FROM ADMIN01.DEAN WHERE DEAN.MADA = '" + MADA + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
