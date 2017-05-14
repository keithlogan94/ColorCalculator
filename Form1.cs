using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AcceptButton = button15;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            pinkToolStripMenuItem_Click(null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }
        
        /// <summary>
        /// Divide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += button13.Text;
        }

        /// <summary>
        /// Plus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += button11.Text;
        }

        /// <summary>
        /// Minus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += button12.Text;
        }

        /// <summary>
        /// Multiply
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += button14.Text;
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button15_Click(object sender, EventArgs e)
        {
            MSScriptControl.ScriptControl sc = new MSScriptControl.ScriptControl();
            sc.Language = "VBScript";
            try
            {
                textBox1.Text = ((object)sc.Eval((string)textBox1.Text)).ToString();
            }
            catch (Exception exception){}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += this.button1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.AcceptsReturn = false;
            if (e.KeyChar == (char)ConsoleKey.Enter)
                button15_Click(null, null);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.AcceptsReturn = false;
            if (e.KeyChar == (char)ConsoleKey.Enter)
                button15_Click(null, null);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void setAllButtonForeColor(Color color)
        {
            foreach (Control control in this.Controls)
                if (control.GetType() == typeof(Button))
                    control.BackColor = color;
        }

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = menuStrip1.BackColor = Color.LightPink;
            ForeColor = Color.DeepPink;
            menuStrip1.ForeColor = Color.White;
            setAllButtonForeColor(Color.White);
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = menuStrip1.BackColor = Color.LightYellow;
            ForeColor = Color.DarkCyan;
            menuStrip1.ForeColor = Color.DarkCyan;
            setAllButtonForeColor(Color.White);
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = menuStrip1.BackColor = Color.LightBlue;
            ForeColor = Color.Blue;
            menuStrip1.ForeColor = Color.Blue;
            setAllButtonForeColor(Color.White);
        }
    }
}
