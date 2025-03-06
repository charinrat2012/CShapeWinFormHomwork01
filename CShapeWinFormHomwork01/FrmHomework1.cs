using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CShapeWinFormHomwork01
{
    public partial class FrmHomework1 : Form
    {
        public FrmHomework1()
        {
            InitializeComponent();
        }
        private void btNext_Click(object sender, EventArgs e)
        {
            FrmHomework2 frmHomework2 = new FrmHomework2();
            frmHomework2.Show();
            Hide();
        }
        //btMonth===============================
        private void btMonth1_Click(object sender, EventArgs e)
        {
            ShareData.showDialogMSG("มกราคม");
        }

        private void btMonth2_Click(object sender, EventArgs e)
        {
            ShareData.showDialogMSG("กุมภาพันธ์");
        }

        private void btMonth3_Click(object sender, EventArgs e)
        {
            ShareData.showDialogMSG("มีนาคม");
        }

        private void btMonth4_Click(object sender, EventArgs e)
        {
            ShareData.showDialogMSG("เมษายน");
        }

        private void btMonth5_Click(object sender, EventArgs e)
        {
            ShareData.showDialogMSG("พฤษภาคม");
        }

        private void btMonth6_Click(object sender, EventArgs e)
        {
            ShareData.showDialogMSG("มิถุนายน");
        }

        private void btMonth7_Click(object sender, EventArgs e)
        {
            ShareData.showDialogMSG("กรกฎาคม");
        }

        private void btMonth8_Click(object sender, EventArgs e)
        {
            ShareData.showDialogMSG("สิงหาคม");
        }

        private void btMonth9_Click(object sender, EventArgs e)
        {
            ShareData.showDialogMSG("กันยายน");
        }

        private void btMonth10_Click(object sender, EventArgs e)
        {
            ShareData.showDialogMSG("ตุลาคม");
        }

        private void btMonth11_Click(object sender, EventArgs e)
        {
            ShareData.showDialogMSG("พฤศจิกายน");
        }

        private void btMonth12_Click(object sender, EventArgs e)
        {
            ShareData.showDialogMSG("ธันวาคม");
        }

        private void FrmHomework1_Load(object sender, EventArgs e)
        {

        }
    }
}
