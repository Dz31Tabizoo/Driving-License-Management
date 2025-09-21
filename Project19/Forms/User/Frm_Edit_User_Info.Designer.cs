namespace Project19
{
    partial class Frm_Edit_User_Info
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Edit_User_Info));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbUserStatus = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.chkActive = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.lblUserIDOutput = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.lblUSerID = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.txtUserName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonWrapLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.gboxPasswordEdit = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.picPass1 = new System.Windows.Forms.PictureBox();
            this.txtPriviousPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picPass2 = new System.Windows.Forms.PictureBox();
            this.picPass3 = new System.Windows.Forms.PictureBox();
            this.txtConfirmNewpass = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonWrapLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.txtNewPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonWrapLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.kryptonWrapLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.btnSaveEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbUserStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbUserStatus.Panel)).BeginInit();
            this.gbUserStatus.Panel.SuspendLayout();
            this.gbUserStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gboxPasswordEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gboxPasswordEdit.Panel)).BeginInit();
            this.gboxPasswordEdit.Panel.SuspendLayout();
            this.gboxPasswordEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project19.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(635, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(294, 29);
            this.kryptonLabel1.StateNormal.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.kryptonLabel1.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.kryptonLabel1.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.kryptonLabel1.StateNormal.ShortText.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateNormal.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.kryptonLabel1.StateNormal.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel1.StateNormal.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonLabel1.TabIndex = 23;
            this.kryptonLabel1.Values.Text = "Edit User Info & Password";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // gbUserStatus
            // 
            this.gbUserStatus.CaptionOverlap = 0D;
            this.gbUserStatus.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.gbUserStatus.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlGroupBox;
            this.gbUserStatus.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.TabCustom1;
            this.gbUserStatus.Location = new System.Drawing.Point(12, 47);
            this.gbUserStatus.Name = "gbUserStatus";
            // 
            // gbUserStatus.Panel
            // 
            this.gbUserStatus.Panel.Controls.Add(this.pictureBox4);
            this.gbUserStatus.Panel.Controls.Add(this.chkActive);
            this.gbUserStatus.Panel.Controls.Add(this.lblUserIDOutput);
            this.gbUserStatus.Panel.Controls.Add(this.lblUSerID);
            this.gbUserStatus.Panel.Controls.Add(this.txtUserName);
            this.gbUserStatus.Panel.Controls.Add(this.kryptonWrapLabel2);
            this.gbUserStatus.Panel.Controls.Add(this.pictureBox3);
            this.gbUserStatus.Panel.Controls.Add(this.pictureBox5);
            this.gbUserStatus.Size = new System.Drawing.Size(645, 103);
            this.gbUserStatus.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.gbUserStatus.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.gbUserStatus.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.gbUserStatus.TabIndex = 24;
            this.gbUserStatus.Values.Heading = "Edit User Info";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Project19.Properties.Resources.active_user;
            this.pictureBox4.Location = new System.Drawing.Point(499, 17);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.TabIndex = 126;
            this.pictureBox4.TabStop = false;
            // 
            // chkActive
            // 
            this.chkActive.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.chkActive.Location = new System.Drawing.Point(535, 21);
            this.chkActive.Name = "chkActive";
            this.chkActive.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.chkActive.Size = new System.Drawing.Size(93, 20);
            this.chkActive.StateNormal.Padding = new System.Windows.Forms.Padding(3, -1, -1, -1);
            this.chkActive.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.chkActive.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.chkActive.StateNormal.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.chkActive.StateNormal.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.chkActive.TabIndex = 125;
            this.chkActive.Values.Text = " Active User";
            this.chkActive.CheckedChanged += new System.EventHandler(this.chkActive_CheckedChanged);
            // 
            // lblUserIDOutput
            // 
            this.lblUserIDOutput.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIDOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.lblUserIDOutput.Location = new System.Drawing.Point(110, 21);
            this.lblUserIDOutput.Name = "lblUserIDOutput";
            this.lblUserIDOutput.Size = new System.Drawing.Size(37, 20);
            this.lblUserIDOutput.StateCommon.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIDOutput.StateCommon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.lblUserIDOutput.Text = "N/A";
            // 
            // lblUSerID
            // 
            this.lblUSerID.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUSerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.lblUSerID.Location = new System.Drawing.Point(37, 21);
            this.lblUSerID.Name = "lblUSerID";
            this.lblUSerID.Size = new System.Drawing.Size(67, 20);
            this.lblUSerID.StateCommon.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUSerID.StateCommon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.lblUSerID.Text = "User ID :";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(319, 17);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(164, 29);
            this.txtUserName.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtUserName.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.txtUserName.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.txtUserName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUserName.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txtUserName.StateCommon.Border.Rounding = 5;
            this.txtUserName.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.txtUserName.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.StateNormal.Content.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.TabIndex = 116;
            // 
            // kryptonWrapLabel2
            // 
            this.kryptonWrapLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonWrapLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.kryptonWrapLabel2.Location = new System.Drawing.Point(220, 21);
            this.kryptonWrapLabel2.Name = "kryptonWrapLabel2";
            this.kryptonWrapLabel2.Size = new System.Drawing.Size(93, 20);
            this.kryptonWrapLabel2.StateCommon.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonWrapLabel2.StateCommon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.kryptonWrapLabel2.Text = "User Name :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Project19.Properties.Resources.id_card__2_;
            this.pictureBox3.Location = new System.Drawing.Point(7, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 124;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Project19.Properties.Resources.employee;
            this.pictureBox5.Location = new System.Drawing.Point(190, 17);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.TabIndex = 120;
            this.pictureBox5.TabStop = false;
            // 
            // gboxPasswordEdit
            // 
            this.gboxPasswordEdit.CaptionOverlap = 0D;
            this.gboxPasswordEdit.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.gboxPasswordEdit.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlGroupBox;
            this.gboxPasswordEdit.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.FormMain;
            this.gboxPasswordEdit.Location = new System.Drawing.Point(12, 156);
            this.gboxPasswordEdit.Name = "gboxPasswordEdit";
            // 
            // gboxPasswordEdit.Panel
            // 
            this.gboxPasswordEdit.Panel.AllowDrop = true;
            this.gboxPasswordEdit.Panel.AutoScroll = true;
            this.gboxPasswordEdit.Panel.Controls.Add(this.picPass1);
            this.gboxPasswordEdit.Panel.Controls.Add(this.txtPriviousPassword);
            this.gboxPasswordEdit.Panel.Controls.Add(this.pictureBox1);
            this.gboxPasswordEdit.Panel.Controls.Add(this.picPass2);
            this.gboxPasswordEdit.Panel.Controls.Add(this.picPass3);
            this.gboxPasswordEdit.Panel.Controls.Add(this.txtConfirmNewpass);
            this.gboxPasswordEdit.Panel.Controls.Add(this.kryptonWrapLabel5);
            this.gboxPasswordEdit.Panel.Controls.Add(this.txtNewPassword);
            this.gboxPasswordEdit.Panel.Controls.Add(this.kryptonWrapLabel6);
            this.gboxPasswordEdit.Panel.Controls.Add(this.kryptonWrapLabel7);
            this.gboxPasswordEdit.Panel.Controls.Add(this.pictureBox10);
            this.gboxPasswordEdit.Panel.Controls.Add(this.pictureBox13);
            this.gboxPasswordEdit.Size = new System.Drawing.Size(645, 169);
            this.gboxPasswordEdit.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.gboxPasswordEdit.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.gboxPasswordEdit.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.gboxPasswordEdit.TabIndex = 25;
            this.gboxPasswordEdit.Values.Heading = "Edit User Password";
            // 
            // picPass1
            // 
            this.picPass1.BackColor = System.Drawing.Color.Transparent;
            this.picPass1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPass1.Image = global::Project19.Properties.Resources.hide;
            this.picPass1.Location = new System.Drawing.Point(369, 16);
            this.picPass1.Name = "picPass1";
            this.picPass1.Size = new System.Drawing.Size(20, 20);
            this.picPass1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPass1.TabIndex = 139;
            this.picPass1.TabStop = false;
            this.picPass1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowText);
            this.picPass1.MouseLeave += new System.EventHandler(this.HideText);
            this.picPass1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HideText);
            // 
            // txtPriviousPassword
            // 
            this.txtPriviousPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPriviousPassword.Location = new System.Drawing.Point(188, 14);
            this.txtPriviousPassword.Name = "txtPriviousPassword";
            this.txtPriviousPassword.PasswordChar = '▬';
            this.txtPriviousPassword.Size = new System.Drawing.Size(164, 29);
            this.txtPriviousPassword.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtPriviousPassword.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.txtPriviousPassword.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.txtPriviousPassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPriviousPassword.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txtPriviousPassword.StateCommon.Border.Rounding = 5;
            this.txtPriviousPassword.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.txtPriviousPassword.StateCommon.Content.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriviousPassword.StateNormal.Content.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriviousPassword.TabIndex = 135;
            this.txtPriviousPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPerviousPassword_Validating);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Project19.Properties.Resources.locked;
            this.pictureBox1.Location = new System.Drawing.Point(154, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 134;
            this.pictureBox1.TabStop = false;
            // 
            // picPass2
            // 
            this.picPass2.BackColor = System.Drawing.Color.Transparent;
            this.picPass2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPass2.Image = global::Project19.Properties.Resources.hide;
            this.picPass2.Location = new System.Drawing.Point(494, 67);
            this.picPass2.Name = "picPass2";
            this.picPass2.Size = new System.Drawing.Size(20, 20);
            this.picPass2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPass2.TabIndex = 128;
            this.picPass2.TabStop = false;
            this.picPass2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowText);
            this.picPass2.MouseLeave += new System.EventHandler(this.HideText);
            this.picPass2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HideText);
            // 
            // picPass3
            // 
            this.picPass3.BackColor = System.Drawing.Color.Transparent;
            this.picPass3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPass3.Image = global::Project19.Properties.Resources.hide;
            this.picPass3.Location = new System.Drawing.Point(494, 104);
            this.picPass3.Name = "picPass3";
            this.picPass3.Size = new System.Drawing.Size(20, 20);
            this.picPass3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPass3.TabIndex = 127;
            this.picPass3.TabStop = false;
            this.picPass3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowText);
            this.picPass3.MouseLeave += new System.EventHandler(this.HideText);
            this.picPass3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HideText);
            // 
            // txtConfirmNewpass
            // 
            this.txtConfirmNewpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmNewpass.Location = new System.Drawing.Point(317, 99);
            this.txtConfirmNewpass.Name = "txtConfirmNewpass";
            this.txtConfirmNewpass.PasswordChar = '▬';
            this.txtConfirmNewpass.Size = new System.Drawing.Size(164, 29);
            this.txtConfirmNewpass.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtConfirmNewpass.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.txtConfirmNewpass.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.txtConfirmNewpass.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtConfirmNewpass.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txtConfirmNewpass.StateCommon.Border.Rounding = 5;
            this.txtConfirmNewpass.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.txtConfirmNewpass.StateCommon.Content.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmNewpass.StateNormal.Content.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmNewpass.TabIndex = 122;
            this.txtConfirmNewpass.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmNewPass_Validating);
            // 
            // kryptonWrapLabel5
            // 
            this.kryptonWrapLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonWrapLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.kryptonWrapLabel5.Location = new System.Drawing.Point(125, 107);
            this.kryptonWrapLabel5.Name = "kryptonWrapLabel5";
            this.kryptonWrapLabel5.Size = new System.Drawing.Size(147, 20);
            this.kryptonWrapLabel5.StateCommon.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonWrapLabel5.StateCommon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.kryptonWrapLabel5.Text = "Confirm Pass Word :";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.Location = new System.Drawing.Point(317, 64);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '▬';
            this.txtNewPassword.Size = new System.Drawing.Size(164, 29);
            this.txtNewPassword.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtNewPassword.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.txtNewPassword.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.txtNewPassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNewPassword.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txtNewPassword.StateCommon.Border.Rounding = 5;
            this.txtNewPassword.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.txtNewPassword.StateCommon.Content.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.StateNormal.Content.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.TabIndex = 118;
            // 
            // kryptonWrapLabel6
            // 
            this.kryptonWrapLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonWrapLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.kryptonWrapLabel6.Location = new System.Drawing.Point(158, 71);
            this.kryptonWrapLabel6.Name = "kryptonWrapLabel6";
            this.kryptonWrapLabel6.Size = new System.Drawing.Size(116, 20);
            this.kryptonWrapLabel6.StateCommon.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonWrapLabel6.StateCommon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.kryptonWrapLabel6.Text = "New Password :";
            // 
            // kryptonWrapLabel7
            // 
            this.kryptonWrapLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonWrapLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.kryptonWrapLabel7.Location = new System.Drawing.Point(16, 16);
            this.kryptonWrapLabel7.Name = "kryptonWrapLabel7";
            this.kryptonWrapLabel7.Size = new System.Drawing.Size(132, 20);
            this.kryptonWrapLabel7.StateCommon.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonWrapLabel7.StateCommon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.kryptonWrapLabel7.Text = "Privious Password";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = global::Project19.Properties.Resources.locked;
            this.pictureBox10.Location = new System.Drawing.Point(277, 104);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(24, 24);
            this.pictureBox10.TabIndex = 123;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.Image = global::Project19.Properties.Resources.locked;
            this.pictureBox13.Location = new System.Drawing.Point(277, 67);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(24, 24);
            this.pictureBox13.TabIndex = 121;
            this.pictureBox13.TabStop = false;
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Location = new System.Drawing.Point(550, 331);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(91, 30);
            this.btnSaveEdit.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.btnSaveEdit.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.btnSaveEdit.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnSaveEdit.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.btnSaveEdit.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.btnSaveEdit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSaveEdit.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnSaveEdit.StateCommon.Border.Rounding = 5;
            this.btnSaveEdit.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSaveEdit.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSaveEdit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEdit.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnSaveEdit.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btnSaveEdit.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.btnSaveEdit.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.btnSaveEdit.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnSaveEdit.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.btnSaveEdit.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.btnSaveEdit.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSaveEdit.StateTracking.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnSaveEdit.StateTracking.Border.Rounding = 5;
            this.btnSaveEdit.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSaveEdit.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSaveEdit.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEdit.StateTracking.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnSaveEdit.StateTracking.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btnSaveEdit.TabIndex = 26;
            this.btnSaveEdit.Values.Text = "  Save Edit";
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // Frm_Edit_User_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(670, 371);
            this.Controls.Add(this.btnSaveEdit);
            this.Controls.Add(this.gboxPasswordEdit);
            this.Controls.Add(this.gbUserStatus);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Edit_User_Info";
            this.Text = "Frm_Add_User";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbUserStatus.Panel)).EndInit();
            this.gbUserStatus.Panel.ResumeLayout(false);
            this.gbUserStatus.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbUserStatus)).EndInit();
            this.gbUserStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gboxPasswordEdit.Panel)).EndInit();
            this.gboxPasswordEdit.Panel.ResumeLayout(false);
            this.gboxPasswordEdit.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gboxPasswordEdit)).EndInit();
            this.gboxPasswordEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbUserStatus;
        private System.Windows.Forms.PictureBox pictureBox4;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chkActive;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel lblUserIDOutput;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel lblUSerID;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUserName;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gboxPasswordEdit;
        private System.Windows.Forms.PictureBox picPass2;
        private System.Windows.Forms.PictureBox picPass3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtConfirmNewpass;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNewPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel7;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox13;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPriviousPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picPass1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSaveEdit;
    }


}