namespace Project19
{
    partial class Frm_User_Info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.usCrtlPersonCard1 = new Project19.UsCTRLPersonCard();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.usrCrtlLogingInfo1 = new Project19.UsrCrtlLogingInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(118, 33);
            this.kryptonLabel1.StateNormal.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.kryptonLabel1.StateNormal.ShortText.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateNormal.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.kryptonLabel1.StateNormal.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel1.StateNormal.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "User Info";
            // 
            // usCrtlPersonCard1
            // 
            this.usCrtlPersonCard1.BackColor = System.Drawing.Color.White;
            this.usCrtlPersonCard1.Enabled = false;
            this.usCrtlPersonCard1.Location = new System.Drawing.Point(20, 60);
            this.usCrtlPersonCard1.Margin = new System.Windows.Forms.Padding(2);
            this.usCrtlPersonCard1.Name = "usCrtlPersonCard1";
            this.usCrtlPersonCard1.PersonDetailsRow = null;
            this.usCrtlPersonCard1.Size = new System.Drawing.Size(820, 383);
            this.usCrtlPersonCard1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project19.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(795, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // usrCrtlLogingInfo1
            // 
            this.usrCrtlLogingInfo1.BackColor = System.Drawing.Color.White;
            this.usrCrtlLogingInfo1.Location = new System.Drawing.Point(-3, 435);
            this.usrCrtlLogingInfo1.Name = "usrCrtlLogingInfo1";
            this.usrCrtlLogingInfo1.Size = new System.Drawing.Size(841, 170);
            this.usrCrtlLogingInfo1.TabIndex = 5;
            // 
            // Frm_User_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 604);
            this.Controls.Add(this.usrCrtlLogingInfo1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.usCrtlPersonCard1);
            this.Controls.Add(this.kryptonLabel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_User_Info";
            this.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.StateCommon.Border.Rounding = 5;
            this.StateCommon.Border.Width = 0;
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.StateCommon.Header.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.StateCommon.Header.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.StateCommon.Header.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.StateCommon.Header.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.StateCommon.Header.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Header.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.StateCommon.Header.ButtonEdgeInset = 5;
            this.Text = "Person_Details";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private UsCTRLPersonCard usCrtlPersonCard1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private UsrCrtlLogingInfo usrCrtlLogingInfo1;
    }
}