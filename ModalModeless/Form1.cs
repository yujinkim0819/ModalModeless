using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModalModeless
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안뇽하세요~");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("안녕하세요~", "비 오는 날 아침 인사");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안녕하세요~", "비 오는 날 아침 인사",
                MessageBoxButtons.YesNoCancel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안녕하세요~", "비 오는 날 아침 인사",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CustomForm frm = new CustomForm();
            frm.ShowDialog(); // 모달창 : 창이 뜨고 작업 안끝내면 다른 작업 못 함
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CustomForm frm = new CustomForm();
            frm.MdiParent = this; // this : From1
            frm.Show(); // 모달리스 : 자유롭게 동작
        }

       
    }
}
