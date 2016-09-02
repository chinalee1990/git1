using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxUnityWebPlayerAXLib;
using System.IO;

namespace U3d_WinForm
{
    public partial class U3DPlayer : UserControl
    {

        public U3DPlayer(string path)
        {
            InitializeComponent();
            _u3DPlayer = InitU3DPlayer();
            OpenFile(path);
        }

        public static U3DPlayer AppendTo(Control parent, string path)
        {

            try
            {
                U3DPlayer player = new U3DPlayer(path);
                parent.Controls.Clear();
                parent.Controls.Add(player);
                return player;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }

        }

        private void OpenFile(string path)
        {
            _u3DPlayer = CreateU3DPlayerEx(path, _u3DPlayer);
        }

        private AxUnityWebPlayer InitU3DPlayer()
        {
            var resources = new ComponentResourceManager(GetType());
            AxHost.State state1 = ((AxHost.State)(resources.GetObject("u3dPlayer.OcxState")));
            var player = CreateU3DPlayer(state1);
            return player;
        }

        private AxUnityWebPlayer CreateU3DPlayerEx(string path, AxUnityWebPlayer player)
        {
            var state = GetState(path, player);

            return CreateU3DPlayer(state);
        }

        /*
            * 给unity设置src属性时，会自动生成字符串资源，并把它赋值给属性OcxState。
            * 由于没办法手动生成这个字符串，因而需要通过代码，即先赋值给OcxState，再取出来的方式得到需要的字符串资源。
            * 然后再将值赋给重新创建的控件。
        */

        /// <summary>
        /// 获取需要的字符串资源
        /// </summary>
        /// <param name="path"></param>
        /// <param name="player"></param>
        /// <returns></returns>

        private static AxHost.State GetState(string path, AxUnityWebPlayer player)
        {
            player.src = new FileInfo(path).FullName; //这里是重点
            AxHost.State state = player.OcxState;
            player.Dispose();//因为之后马上就要创建新的了
            return state;
        }

        private AxUnityWebPlayer CreateU3DPlayer(AxHost.State state1)
        {
            var player = new AxUnityWebPlayer() { Dock = DockStyle.Fill };
            ((ISupportInitialize)(player)).BeginInit();
            player.OcxState = state1;
            Controls.Add(player);
            ((ISupportInitialize)(player)).EndInit();
            return player;
        }
    }
}
