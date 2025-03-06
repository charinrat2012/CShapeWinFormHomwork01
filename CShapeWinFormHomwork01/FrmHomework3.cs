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
    public partial class FrmHomework3 : Form
    {
        public FrmHomework3()
        {
            InitializeComponent();
        }

        private void FrmHomework3_Load(object sender, EventArgs e)
        {

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            FrmHomework2 frmHomework2 = new FrmHomework2();
            frmHomework2.Show();
            Hide();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            FrmHomework4 frmHomework4 = new FrmHomework4();
            frmHomework4.Show();
            Hide();
        }
        private void btCal_Click(object sender, EventArgs e)
        {
            if (tbAmountMoney.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("ป้อนจำนวนเงินด้วย");
            } 
            else if (tbAmountPeople.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("ป้อนจำนวนคนด้วย");
            }
            else
            {
                double money = Convert.ToDouble(tbAmountMoney.Text.Trim());
                int people = Convert.ToInt32(tbAmountPeople.Text.Trim());
                double result = money / people;
                lbShowResult.Text = result.ToString("0.00");
            }
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการออกจากโปรแกรมใช่มั้ย", "ยืนยัน",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //Keypress================================================================
        private void tbAmountMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            // ตรวจสอบว่าคีย์ที่ป้อนเป็นตัวเลขหรือจุด 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // ไม่อนุญาตให้ป้อนคีย์นี้ 
            }
            // ตรวจสอบว่ามีจุดอยู่แล้วในข้อความหรือไม่ 
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true; // ไม่อนุญาตให้ป้อนจุดอีก 
            }
        }
        private void tbAmountPeople_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ตรวจสอบว่าเป็นตัวเลข หรือปุ่มควบคุม เช่น Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // ป้องกันไม่ให้ป้อนอักขระที่ไม่ใช่ตัวเลข
            }
        }

        
    }
}
