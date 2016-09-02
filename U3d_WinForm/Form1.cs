using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U3d_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //axUnityWebPlayer1.src = Environment.CurrentDirectory + "\\U3d_Test\\Test.html";
            //webBrowser1.Navigate(Environment.CurrentDirectory + "\\U3d_Test\\index.html");

            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void axUnityWebPlayer1_OnExternalCall(object sender, AxUnityWebPlayerAXLib._DUnityWebPlayerAXEvents_OnExternalCallEvent e)
        {
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //axUnityWebPlayer1.src = Environment.CurrentDirectory + "\\U3d_Test\\Test.unity3d";

        }

        //public partial class U3DPlayer : UserControl
        //{

   

        //}

    }
}
