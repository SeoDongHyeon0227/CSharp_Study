using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TextBox에 초기값 할당
            textBox1.Text = "서울특별시 영동구 신길동 124번지";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("이름 : 홍길동");
            sb.AppendLine("나이 : 27세");
            sb.AppendLine("국적 : 한국");
            textBox2.Text = sb.ToString();

            textBox3.MaxLength = 10;
            textBox4.ReadOnly = true;
            textBox5.PasswordChar = '*';

            textBox3.Text = "서울특별시 영동구 신길동 124번지";
            textBox4.Text = "서울특별시 영동구 신길동 124번지";
            textBox5.Text = "서울특별시 영동구 신길동 124번지";


        }
    }
}
