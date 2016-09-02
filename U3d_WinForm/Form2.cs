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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //axUnityWebPlayer1.src = @"D:\VS2013 Projects\C#\U3d_WinForm\U3d_WinForm\bin\Debug\U3d_Test\Tested.Unity3d";
            InitUnity();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void axUnityWebPlayer1_OnExternalCall(object sender, AxUnityWebPlayerAXLib._DUnityWebPlayerAXEvents_OnExternalCallEvent e)
        {

        }

        private void InitUnity()
        {
            var unity = new AxUnityWebPlayerAXLib.AxUnityWebPlayer();
            ((System.ComponentModel.ISupportInitialize)(unity)).BeginInit();
            Controls.Add(unity);
            ((System.ComponentModel.ISupportInitialize)(unity)).EndInit();
            //unity.src = Application.StartupPath + "\\u.unity3d";  //改成自己想要的路径  
            unity.src = Environment.CurrentDirectory + "\\U3d_Test\\Desktop.Unity3d";
            //unity.src = Environment.CurrentDirectory + "\\U3d_Test\\Desktop.html";
            AxHost.State state = unity.OcxState;
            unity.Dispose();
            unity = new AxUnityWebPlayerAXLib.AxUnityWebPlayer();
            ((System.ComponentModel.ISupportInitialize)(unity)).BeginInit();
            this.SuspendLayout();
            unity.Dock = DockStyle.Fill;
            unity.Name = "Unity";
            unity.OcxState = state;
            unity.TabIndex = 0;
            this.Controls.Add(unity); //panel1是我用的一个容器，改成this.Controls也可以  
            ((System.ComponentModel.ISupportInitialize)(unity)).EndInit();
            this.ResumeLayout(false);
        }  
    }
}
