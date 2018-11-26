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
using TinHocDaiCuong.DTO;

namespace TinHocDaiCuong.GUI
{
    public partial class MainForm : Form
    {
        public SV_BLL bll { get; set; }
        public delegate void DD(string Message);
        public DD d;

        public MainForm()
        {
            bll = new SV_BLL();
            InitializeComponent();
            d = new DD(LoadLabel);
        }
       

        private void btnThi_Click(object sender, EventArgs e)
        {
            //hien thi ExamForm
            SV sv = bll.getSV_BLL(lblMSSV_MF.Text);
            Exam ex = new Exam();
            ex.d(sv.MSSV);
            ex.ShowDialog();
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(//hien thi diem o trong nay)
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogIn li = new LogIn();
            this.Hide();
            li.ShowDialog();
            this.Dispose();
        }
        void LoadLabel(string s)
        {
            SV sv = bll.getSV_BLL(s);
            lblMSSV_MF.Text = sv.MSSV;
            lblTen_MF.Text = sv.Ten;
            lblLop_MF.Text = sv.Lop;
        }
    }
}
