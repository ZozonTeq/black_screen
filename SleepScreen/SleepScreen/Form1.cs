using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SleepScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;//ボーダー消去
            this.WindowState = FormWindowState.Maximized;//ウィンドウ最大化

        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }//カーソル非表示

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }//カーソル表示

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();//プロセス終了
        }
    }
}
