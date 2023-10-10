using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHANQUYENADMIN.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PHANQUYENADMIN
{
    public partial class fLogin : Form
    {
        public static String user;
        public static String ROLE;
        public fLogin()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            string username= textUsername.Text;
            string password= textPassword.Text;
            if(username!=null && password != null)
            {
                if (DataProvider.getInstance(username, password) != null)
                {
                    user = username;
                    ROLE = AdminstratorDAO.get_Logged_in_Role();
                    checkUser();
                    
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                }
            }
            else
            {
                MessageBox.Show("Empty!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        int checkUser()
        {
            String role=AdminstratorDAO.get_Logged_in_Role();
            ROLE = role;
            if (role == null)
            {
                MessageBox.Show("Có lỗi xảy ra. Xin thử lại sau ít phút");
                return 0;
            }
            else
            if (role == "Admin")
            {
                fAdministrator fAdmin = new fAdministrator();
                this.Hide();
                fAdmin.ShowDialog();
                DataProvider.close();
                this.Show();
            }
            else
            {
                Dashboard form = new Dashboard();
                this.Hide();
                form.ShowDialog();
                DataProvider.close();
                this.Show();
            }

            return 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
