using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using PHANQUYENADMIN.DAO;

namespace PHANQUYENADMIN
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private Form activeform = null;
        void callForm(Form childForm)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelCallForm.Controls.Add(childForm);
            panelCallForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private Button currentButton;
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#65628A");
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(63, 61, 86);
                    previousBtn.ForeColor = Color.Gainsboro;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            callForm(new fTableDeAn());
            ActivateButton(sender);

        }

        private void btnDSNV_Click(object sender, EventArgs e)
        {
            callForm(new fTableNhanVien());
            ActivateButton(sender);
        }

        private void btnThongtin_Click(object sender, EventArgs e)
        {
            callForm(new fInformation());
            ActivateButton(sender);
        }

        private void btnDSPB_Click(object sender, EventArgs e)
        {
            callForm(new fTablePhongBan());
            ActivateButton(sender);
        }

        private void btnDSPC_Click(object sender, EventArgs e)
        {
            callForm(new fTablePhanCong());
            ActivateButton(sender);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            switch (fLogin.ROLE)
            {
                case "Ban giam doc":
                    lbNV.Text = "GIÁM ĐỐC";
                    break;
                case "Truong phong":
                    lbNV.Text = "TRƯỞNG PHÒNG";
                    break;
                case "Tai chinh":
                    lbNV.Text = "TÀI CHÍNH";
                    break;
                case "Truong de an":
                    lbNV.Text = "TRƯỞNG ĐỀ ÁN";
                    break;
                case "Nhan su":
                    lbNV.Text = "NHÂN SỰ";
                    break;
                case "QL truc tiep":
                    lbNV.Text = "QL TRỰC TIẾP";
                    break;
                case "Nhan vien":
                    lbNV.Text = "NHÂN VIÊN";
                    break;
            }
            int x = lbNV.Size.Width/2;
            int y = lbNV.Size.Height/2;
            lbNV.Location = new Point(94-x, 18-y);
            label2.Text = fLogin.user;
        }

        private void btnDX_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnThongbao_Click(object sender, EventArgs e)
        {
            callForm(new fTableThongBao());
            ActivateButton(sender);
        }
    }
}
