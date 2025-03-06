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
    public partial class FrmHomework2 : Form
    {
        public FrmHomework2()
        {
            InitializeComponent();
        }
        private void FrmHomework2_Load(object sender, EventArgs e)
        {

        }
        private void btClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการออกจากโปรแกรมใช่มั้ย", "ยืนยัน",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //btNext====================================================
        private void btNext_Click(object sender, EventArgs e)
        {
            FrmHomework3 frmHomework3 = new FrmHomework3();
            frmHomework3.Show();
            Hide();
        }
        //btBack====================================================
        private void btBack_Click(object sender, EventArgs e)
        {
            FrmHomework1 frmHomework1 = new FrmHomework1();
            frmHomework1.Show();
            Hide();
        }
        //btCal====================================================
        private void btCal_Click(object sender, EventArgs e)
        {
            //Validate
            if (tbStuID.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("ป้อนรหัสประจำตัวด้วย");
            }
            else if (tbFullname.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("ป้อนชื่อ-สกุลด้วย");
            }
            else if (tbMidterm.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("ป้อนคะแนนสอบกลางภาคด้วย");
                
            }
            else if (tbFinal.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("ป้อนคะแนนสอบปลายภาคด้วย");

            }
            else if (tbCollect.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("ป้อนคะแนนเก็บด้วย");

            }
            else
            {
                lbShowID.Text = tbStuID.Text.Trim();
                lbShowFullname.Text = tbFullname.Text.Trim();
                int totalPoint = Convert.ToInt32(tbMidterm.Text.Trim()) +
                    Convert.ToInt32(tbFinal.Text.Trim()) + 
                    Convert.ToInt32(tbCollect.Text.Trim());
                lbShowPoint.Text = totalPoint.ToString("0");
                string grade;
                if (totalPoint >= 80)
                    grade = "A";
                else if (totalPoint >= 70)
                    grade = "B";
                else if (totalPoint >= 60)
                    grade = "C";
                else if (totalPoint >= 50)
                    grade = "D";
                else
                    grade = "F";
                lbShowGrade.Text = grade;
            }
        }
        //btCancel=================================================
        private void btCancel_Click(object sender, EventArgs e)
        {
            tbStuID.Clear();
            tbFullname.Clear();
            tbMidterm.Clear();
            tbFinal.Clear();    
            tbCollect.Clear();
            lbShowID.Text = "XXXXXXXXX";
            lbShowFullname.Text = "XXXXXXXX";
            lbShowPoint.Text = "XXXXXXXX";
            lbShowGrade.Text = "XXXXXXXX";
        }
        //Keypress==================================================================
        private void tbStuID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // ป้องกันไม่ให้ป้อนอักขระที่ไม่ใช่ตัวเลข
            }
        }

        private void tbMidterm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // ป้องกันไม่ให้ป้อนอักขระที่ไม่ใช่ตัวเลข
            }
        }

        private void tbFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // ป้องกันไม่ให้ป้อนอักขระที่ไม่ใช่ตัวเลข
            }
        }

        private void tbCollect_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // ป้องกันไม่ให้ป้อนอักขระที่ไม่ใช่ตัวเลข
            }
        }
    }
}
