using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        int CountNum = 0;
        string[] SList = new string[] { "홍차", "녹차", "루이보스차", "국화차" };
        int[] TList = new int[] { 10 * 60 * 2, 10 * 60 * 3, 10 * 60 * 5, 10 * 60 * 2 };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < SList.Length; i++)
            {
                this.cbList.Items.Add(SList[i]);
            }
            if (cbList.Items.Count > 0)
            {
                this.cbList.SelectedIndex = 0;
            }
            this.timeStr.Text = TList[this.cbList.SelectedIndex] / 600 + "분";

        }

        private void CbList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.timeStr.Text = TList[this.cbList.SelectedIndex] / 600 +  "분";

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (CountNum < 1)
            {
                this.Timer.Enabled = false;
                MessageBox.Show("티백을 건지세요!", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.timeLeftStr.Text = "";
                this.cbList.Focus();
            }
            else
            {
                CountNum--;
                if (CountNum / 10 / 60 == 0)
                    this.timeLeftStr.Text = Convert.ToString((CountNum / 10) % 60 + "초" + " 남았습니다!");
                else
                    this.timeLeftStr.Text = Convert.ToString(CountNum / 10 / 60 + "분 " + (CountNum / 10) % 60 + "초" + " 남았습니다!");
            }

        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            CountNum = TList[this.cbList.SelectedIndex];
            this.Timer.Enabled = true;
        }

        private void TimeStr_Click(object sender, EventArgs e)
        {

        }
    }
}
