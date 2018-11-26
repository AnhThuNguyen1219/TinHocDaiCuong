using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinHocDaiCuong.BLL;
using TinHocDaiCuong.DAL;
using TinHocDaiCuong.DTO;

namespace TinHocDaiCuong.GUI
{
    public partial class LogIn : Form
    {
        public SV_BLL bll { get; set; }

        

        public LogIn()
        {
            this.bll = new SV_BLL();
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SV s = new SV();
            s.MSSV = txtMSSV_LI.Text;
            s.MatKhau = txtMatKhau_LI.Text;
            
            if (bll.checkSV_BLL(s) == 1)
            {
                
                this.Hide();
                MainForm mf = new MainForm();
                mf.d(s.MSSV);
                mf.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai, vui lòng nhập lại");
                txtMSSV_LI.Text = "";
                txtMatKhau_LI.Text = "";
            }
        }

       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtMatKhau_LI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                SV s = new SV();
                s.MSSV = txtMSSV_LI.Text;
                s.MatKhau = txtMatKhau_LI.Text;
                
                if (bll.checkSV_BLL(s) == 1)
                {
                    
                    this.Hide();
                    MainForm mf = new MainForm();
                    mf.d(s.MSSV);
                    mf.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bạn đã nhập sai, vui lòng nhập lại");
                    txtMSSV_LI.Text = "";
                    txtMatKhau_LI.Text = "";
                }
            }
        }
    }
}
