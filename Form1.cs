using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLua;

namespace lab1_SYP
{
    public partial class Form1 : Form
    {
        double a, b, c, d, x1, x2;
        string filePath = "C:\\Users\\danik\\source\\repos\\lab1_SYP\\ret.lua";

        private void button1_Click(object sender, EventArgs e)
        {
            a=Convert.ToDouble(textBox1.Text);
            b=Convert.ToDouble(textBox2.Text);
            c=Convert.ToDouble(textBox3.Text);

            using (Lua luaState = new Lua())
            {
                luaState.DoFile(filePath);
                LuaFunction mainFunc = luaState["main"] as LuaFunction;
                double d = (double)mainFunc.Call(a,b,c)[0];
                textBox6.Text = Convert.ToString(d);
                if (d >= 0)
                {
                    double x1 = (double)mainFunc.Call(a, b, c)[1];
                    double x2 = (double)mainFunc.Call(a, b, c)[2];
                    textBox4.Text = Convert.ToString(x1);
                    textBox5.Text = Convert.ToString(x2);
                }
                else
                {
                    string x1 = (string)mainFunc.Call(a, b, c)[1];
                    string x2 = (string)mainFunc.Call(a, b, c)[2];
                    textBox4.Text = x1;
                    textBox5.Text = x2;
                }
            }
            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

    }
}
