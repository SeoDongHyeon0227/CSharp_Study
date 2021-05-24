using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] data = { "사과", "배", "복숭아", "수박", "딸기", "참외", "석류", "귤" };

            //ComboBox1은 Simple
            //ComboBox2은 DropDown
            //ComboBox3은 DropDownList

            //각 콤보박스 데이터 초기화   
            comboBox1.Items.AddRange(data);
            comboBox2.Items.AddRange(data);
            comboBox3.Items.AddRange(data);

            //처음 선택값 지정. 첫째 아이템 선택 기본설정
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;



        }
    }
}
