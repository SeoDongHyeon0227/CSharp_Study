using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Checked 상태로 초기화 하기 ( 체크박스 1번 )
            checkBox1.Checked = true;
            //Unchecked 상태로 초기화하기 ( 체크박스 2번 )
            checkBox2.Checked = false;
            // Intermediate 상태로 초기화하기 ( 체크박스 3번 )

            // Intermediate에 속한 4번 체크박스 Checked 상태로 초기화
            checkBox4.Checked = true;
            // Intermediate에 속한 5번 체크박스 Unchecked 상태로 초기화
            checkBox5.Checked = false;

            //checkBox6의 상태가 바뀔 때마다 checkBox6_CheckedChanged 함수 호출
            checkBox6.CheckStateChanged += checkBox6_CheckedChanged;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox1.Text += " 변경! ";
        }
    }
}
