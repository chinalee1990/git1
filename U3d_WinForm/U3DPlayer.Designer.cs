namespace U3d_WinForm
{
    partial class U3DPlayer
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(U3DPlayer));
            this._u3DPlayer = new AxUnityWebPlayerAXLib.AxUnityWebPlayer();
            ((System.ComponentModel.ISupportInitialize)(this._u3DPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // _u3DPlayer
            // 
            this._u3DPlayer.Enabled = true;
            this._u3DPlayer.Location = new System.Drawing.Point(38, 29);
            this._u3DPlayer.Name = "_u3DPlayer";
            this._u3DPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("_u3DPlayer.OcxState")));
            this._u3DPlayer.Size = new System.Drawing.Size(192, 192);
            this._u3DPlayer.TabIndex = 0;
            // 
            // U3DPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._u3DPlayer);
            this.Name = "U3DPlayer";
            this.Size = new System.Drawing.Size(254, 242);
            ((System.ComponentModel.ISupportInitialize)(this._u3DPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxUnityWebPlayerAXLib.AxUnityWebPlayer _u3DPlayer;
    }
}
