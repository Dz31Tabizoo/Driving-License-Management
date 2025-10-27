namespace Project19
{
    partial class Frm_Add_New_Local_DVL
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
            this.btnExit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnToApplication = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.crtlPersonCardWithFilter1 = new Project19.crtlPersonCardWithFilter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbxLicenseClasses = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblLicenseClass = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblUserCreatedByOutput = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblAppFeeOutput = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblApplicationFee = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblApplicationDateOutput = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblApplicationDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblldvlApplicationOutput = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblApplicationID = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnSaveApplication = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLicenseClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(779, 686);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 30);
            this.btnExit.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.btnExit.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.btnExit.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.btnExit.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.btnExit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExit.StateCommon.Border.Rounding = 5;
            this.btnExit.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnExit.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnExit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.btnExit.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.btnExit.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.btnExit.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.btnExit.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExit.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnExit.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnExit.TabIndex = 39;
            this.btnExit.Tag = "btnAddNewPerson";
            this.btnExit.Values.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project19.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(879, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(16, 8);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(450, 29);
            this.kryptonLabel1.StateNormal.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.kryptonLabel1.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.kryptonLabel1.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.kryptonLabel1.StateNormal.ShortText.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateNormal.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.kryptonLabel1.TabIndex = 22;
            this.kryptonLabel1.Values.Text = "New Local Driving License Application";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(21, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(868, 604);
            this.tabControl1.TabIndex = 40;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnToApplication);
            this.tabPage1.Controls.Add(this.crtlPersonCardWithFilter1);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.IndianRed;
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(860, 568);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Person Select";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnToApplication
            // 
            this.btnToApplication.Location = new System.Drawing.Point(653, 515);
            this.btnToApplication.Name = "btnToApplication";
            this.btnToApplication.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnToApplication.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnToApplication.OverrideDefault.Back.ColorAngle = 45F;
            this.btnToApplication.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnToApplication.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnToApplication.OverrideDefault.Border.ColorAngle = 45F;
            this.btnToApplication.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnToApplication.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnToApplication.OverrideDefault.Border.Rounding = 20;
            this.btnToApplication.OverrideDefault.Border.Width = 1;
            this.btnToApplication.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnToApplication.Size = new System.Drawing.Size(172, 45);
            this.btnToApplication.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.btnToApplication.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.btnToApplication.StateCommon.Back.ColorAngle = 45F;
            this.btnToApplication.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.btnToApplication.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.btnToApplication.StateCommon.Border.ColorAngle = 45F;
            this.btnToApplication.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnToApplication.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnToApplication.StateCommon.Border.Rounding = 20;
            this.btnToApplication.StateCommon.Border.Width = 1;
            this.btnToApplication.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnToApplication.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnToApplication.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToApplication.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.btnToApplication.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.btnToApplication.StatePressed.Back.ColorAngle = 135F;
            this.btnToApplication.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.btnToApplication.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.btnToApplication.StatePressed.Border.ColorAngle = 135F;
            this.btnToApplication.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnToApplication.StatePressed.Border.Rounding = 20;
            this.btnToApplication.StatePressed.Border.Width = 1;
            this.btnToApplication.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.btnToApplication.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.btnToApplication.StateTracking.Back.ColorAngle = 45F;
            this.btnToApplication.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.btnToApplication.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.btnToApplication.StateTracking.Border.ColorAngle = 45F;
            this.btnToApplication.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnToApplication.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnToApplication.StateTracking.Border.Rounding = 20;
            this.btnToApplication.StateTracking.Border.Width = 1;
            this.btnToApplication.TabIndex = 5;
            this.btnToApplication.Values.Image = global::Project19.Properties.Resources.right_arrow;
            this.btnToApplication.Values.Text = "To Application";
            this.btnToApplication.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // crtlPersonCardWithFilter1
            // 
            this.crtlPersonCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.crtlPersonCardWithFilter1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crtlPersonCardWithFilter1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.crtlPersonCardWithFilter1.Location = new System.Drawing.Point(25, 25);
            this.crtlPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.crtlPersonCardWithFilter1.Name = "crtlPersonCardWithFilter1";
            this.crtlPersonCardWithFilter1.PersID = -1;
            this.crtlPersonCardWithFilter1.PersonRow = null;
            this.crtlPersonCardWithFilter1.Size = new System.Drawing.Size(800, 483);
            this.crtlPersonCardWithFilter1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSaveApplication);
            this.tabPage2.Controls.Add(this.cbxLicenseClasses);
            this.tabPage2.Controls.Add(this.lblLicenseClass);
            this.tabPage2.Controls.Add(this.lblUserCreatedByOutput);
            this.tabPage2.Controls.Add(this.kryptonLabel3);
            this.tabPage2.Controls.Add(this.lblAppFeeOutput);
            this.tabPage2.Controls.Add(this.lblApplicationFee);
            this.tabPage2.Controls.Add(this.lblApplicationDateOutput);
            this.tabPage2.Controls.Add(this.lblApplicationDate);
            this.tabPage2.Controls.Add(this.lblldvlApplicationOutput);
            this.tabPage2.Controls.Add(this.lblApplicationID);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(860, 568);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Application";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbxLicenseClasses
            // 
            this.cbxLicenseClasses.DropDownWidth = 205;
            this.cbxLicenseClasses.Location = new System.Drawing.Point(278, 176);
            this.cbxLicenseClasses.Name = "cbxLicenseClasses";
            this.cbxLicenseClasses.Size = new System.Drawing.Size(205, 21);
            this.cbxLicenseClasses.StateNormal.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cbxLicenseClasses.StateNormal.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.cbxLicenseClasses.StateNormal.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.cbxLicenseClasses.StateNormal.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxLicenseClasses.StateNormal.ComboBox.Border.Rounding = 5;
            this.cbxLicenseClasses.StateNormal.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.cbxLicenseClasses.StateNormal.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLicenseClasses.StateNormal.Item.Back.Color1 = System.Drawing.Color.White;
            this.cbxLicenseClasses.StateNormal.Item.Back.Color2 = System.Drawing.Color.White;
            this.cbxLicenseClasses.StateNormal.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.cbxLicenseClasses.StateNormal.Item.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.cbxLicenseClasses.StateNormal.Item.Border.ColorAngle = 45F;
            this.cbxLicenseClasses.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxLicenseClasses.StateNormal.Item.Border.Rounding = 0;
            this.cbxLicenseClasses.StateNormal.Item.Border.Width = 1;
            this.cbxLicenseClasses.StateNormal.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.cbxLicenseClasses.StateNormal.Item.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.cbxLicenseClasses.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLicenseClasses.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.cbxLicenseClasses.StateTracking.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.cbxLicenseClasses.StateTracking.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.cbxLicenseClasses.StateTracking.Item.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.cbxLicenseClasses.StateTracking.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxLicenseClasses.StateTracking.Item.Border.Rounding = 0;
            this.cbxLicenseClasses.StateTracking.Item.Content.LongText.Color1 = System.Drawing.Color.White;
            this.cbxLicenseClasses.StateTracking.Item.Content.LongText.Color2 = System.Drawing.Color.White;
            this.cbxLicenseClasses.StateTracking.Item.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLicenseClasses.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.cbxLicenseClasses.StateTracking.Item.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.cbxLicenseClasses.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLicenseClasses.TabIndex = 9;
            this.cbxLicenseClasses.Text = "Select a License Class ...";
            // 
            // lblLicenseClass
            // 
            this.lblLicenseClass.Location = new System.Drawing.Point(149, 176);
            this.lblLicenseClass.Name = "lblLicenseClass";
            this.lblLicenseClass.Size = new System.Drawing.Size(120, 26);
            this.lblLicenseClass.StateCommon.ShortText.Color1 = System.Drawing.Color.Navy;
            this.lblLicenseClass.StateCommon.ShortText.Color2 = System.Drawing.Color.Navy;
            this.lblLicenseClass.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.lblLicenseClass.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.lblLicenseClass.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseClass.TabIndex = 8;
            this.lblLicenseClass.Values.Text = "License Class :";
            // 
            // lblUserCreatedByOutput
            // 
            this.lblUserCreatedByOutput.Location = new System.Drawing.Point(278, 240);
            this.lblUserCreatedByOutput.Name = "lblUserCreatedByOutput";
            this.lblUserCreatedByOutput.Size = new System.Drawing.Size(54, 26);
            this.lblUserCreatedByOutput.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.lblUserCreatedByOutput.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.lblUserCreatedByOutput.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserCreatedByOutput.TabIndex = 7;
            this.lblUserCreatedByOutput.Values.Text = "[****]";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(164, 240);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(105, 26);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Navy;
            this.kryptonLabel3.StateCommon.ShortText.Color2 = System.Drawing.Color.Navy;
            this.kryptonLabel3.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.kryptonLabel3.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.kryptonLabel3.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 6;
            this.kryptonLabel3.Values.Text = "Created By :";
            // 
            // lblAppFeeOutput
            // 
            this.lblAppFeeOutput.Location = new System.Drawing.Point(275, 208);
            this.lblAppFeeOutput.Name = "lblAppFeeOutput";
            this.lblAppFeeOutput.Size = new System.Drawing.Size(45, 26);
            this.lblAppFeeOutput.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.lblAppFeeOutput.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.lblAppFeeOutput.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFeeOutput.TabIndex = 5;
            this.lblAppFeeOutput.Values.Text = "15 $";
            // 
            // lblApplicationFee
            // 
            this.lblApplicationFee.Location = new System.Drawing.Point(121, 208);
            this.lblApplicationFee.Name = "lblApplicationFee";
            this.lblApplicationFee.Size = new System.Drawing.Size(148, 26);
            this.lblApplicationFee.StateCommon.ShortText.Color1 = System.Drawing.Color.Navy;
            this.lblApplicationFee.StateCommon.ShortText.Color2 = System.Drawing.Color.Navy;
            this.lblApplicationFee.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.lblApplicationFee.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.lblApplicationFee.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFee.TabIndex = 4;
            this.lblApplicationFee.Values.Text = "Application Fees :";
            // 
            // lblApplicationDateOutput
            // 
            this.lblApplicationDateOutput.Location = new System.Drawing.Point(275, 136);
            this.lblApplicationDateOutput.Name = "lblApplicationDateOutput";
            this.lblApplicationDateOutput.Size = new System.Drawing.Size(54, 26);
            this.lblApplicationDateOutput.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.lblApplicationDateOutput.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.lblApplicationDateOutput.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDateOutput.TabIndex = 3;
            this.lblApplicationDateOutput.Values.Text = "[****]";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.Location = new System.Drawing.Point(118, 136);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(151, 26);
            this.lblApplicationDate.StateCommon.ShortText.Color1 = System.Drawing.Color.Navy;
            this.lblApplicationDate.StateCommon.ShortText.Color2 = System.Drawing.Color.Navy;
            this.lblApplicationDate.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.lblApplicationDate.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.lblApplicationDate.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.TabIndex = 2;
            this.lblApplicationDate.Values.Text = "Application Date :";
            // 
            // lblldvlApplicationOutput
            // 
            this.lblldvlApplicationOutput.Location = new System.Drawing.Point(275, 95);
            this.lblldvlApplicationOutput.Name = "lblldvlApplicationOutput";
            this.lblldvlApplicationOutput.Size = new System.Drawing.Size(54, 26);
            this.lblldvlApplicationOutput.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.lblldvlApplicationOutput.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.lblldvlApplicationOutput.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblldvlApplicationOutput.TabIndex = 1;
            this.lblldvlApplicationOutput.Values.Text = "[****]";
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.Location = new System.Drawing.Point(137, 95);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(132, 26);
            this.lblApplicationID.StateCommon.ShortText.Color1 = System.Drawing.Color.Navy;
            this.lblApplicationID.StateCommon.ShortText.Color2 = System.Drawing.Color.Navy;
            this.lblApplicationID.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.lblApplicationID.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.lblApplicationID.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationID.TabIndex = 0;
            this.lblApplicationID.Values.Text = "Application ID :";
            // 
            // btnSaveApplication
            // 
            this.btnSaveApplication.Location = new System.Drawing.Point(336, 413);
            this.btnSaveApplication.Name = "btnSaveApplication";
            this.btnSaveApplication.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSaveApplication.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSaveApplication.OverrideDefault.Back.ColorAngle = 45F;
            this.btnSaveApplication.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSaveApplication.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSaveApplication.OverrideDefault.Border.ColorAngle = 45F;
            this.btnSaveApplication.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSaveApplication.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSaveApplication.OverrideDefault.Border.Rounding = 20;
            this.btnSaveApplication.OverrideDefault.Border.Width = 1;
            this.btnSaveApplication.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSaveApplication.Size = new System.Drawing.Size(198, 45);
            this.btnSaveApplication.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.btnSaveApplication.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.btnSaveApplication.StateCommon.Back.ColorAngle = 45F;
            this.btnSaveApplication.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.btnSaveApplication.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.btnSaveApplication.StateCommon.Border.ColorAngle = 45F;
            this.btnSaveApplication.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSaveApplication.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSaveApplication.StateCommon.Border.Rounding = 20;
            this.btnSaveApplication.StateCommon.Border.Width = 1;
            this.btnSaveApplication.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSaveApplication.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSaveApplication.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveApplication.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaveApplication.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSaveApplication.StateDisabled.Back.ColorAngle = 45F;
            this.btnSaveApplication.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.btnSaveApplication.StateDisabled.Content.ShortText.Color2 = System.Drawing.Color.Gray;
            this.btnSaveApplication.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.btnSaveApplication.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.btnSaveApplication.StatePressed.Back.ColorAngle = 135F;
            this.btnSaveApplication.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.btnSaveApplication.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.btnSaveApplication.StatePressed.Border.ColorAngle = 135F;
            this.btnSaveApplication.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSaveApplication.StatePressed.Border.Rounding = 20;
            this.btnSaveApplication.StatePressed.Border.Width = 1;
            this.btnSaveApplication.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.btnSaveApplication.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.btnSaveApplication.StateTracking.Back.ColorAngle = 45F;
            this.btnSaveApplication.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.btnSaveApplication.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.btnSaveApplication.StateTracking.Border.ColorAngle = 45F;
            this.btnSaveApplication.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSaveApplication.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSaveApplication.StateTracking.Border.Rounding = 20;
            this.btnSaveApplication.StateTracking.Border.Width = 1;
            this.btnSaveApplication.TabIndex = 43;
            this.btnSaveApplication.Values.Image = global::Project19.Properties.Resources.save;
            this.btnSaveApplication.Values.Text = " Save";
            this.btnSaveApplication.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // Frm_Add_New_Local_DVL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 729);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Add_New_Local_DVL";
            this.Text = "Frm_Add_User";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLicenseClasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExit;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private crtlPersonCardWithFilter crtlPersonCardWithFilter1;
        private System.Windows.Forms.TabPage tabPage2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnToApplication;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblApplicationID;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblAppFeeOutput;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblApplicationFee;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblApplicationDateOutput;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblApplicationDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblldvlApplicationOutput;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblLicenseClass;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblUserCreatedByOutput;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbxLicenseClasses;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSaveApplication;
    }
}