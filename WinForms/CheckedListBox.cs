using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedListBox_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("기성용");
            checkedListBox1.Items.Add("손흥민");
            checkedListBox1.Items.Add("이승우");
            checkedListBox1.Items.Add("황희찬");
            checkedListBox1.Items.Add("조현우");
            checkedListBox1.Items.Add("김현우");
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("선수를 선택했습니다");
        }
    }
}
