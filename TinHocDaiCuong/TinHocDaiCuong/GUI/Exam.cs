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
    public partial class Exam : Form
    {
        public SV_BLL bll { get; set; }

        public delegate void DD(string Message);
        public DD d;

        public Exam()
        {
            InitializeComponent();
            bll = new SV_BLL();
            d = new DD(LoadLabel);
        }

        

        private void btnNopBai_Click(object sender, EventArgs e)
        {

        }
        
        public void LoadLabel(string s)
        {
            SV sv = bll.getSV_BLL(s);
            lblMSSV_E.Text = sv.MSSV;
            lblTen_E.Text = sv.Ten;
            lblLop_E.Text = sv.Lop;
        }


    }
}
