using System.Windows.Forms;

namespace Project19
{
    partial class Frm_Take_Tests
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
            this.btnExit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditAppointmentTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.takeTestTSMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.kryptonContextMenuHeading1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading();
            this.kryptonContextMenuItems1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblClassesOutput = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.lblApp_Date = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblClass = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_trailsOutput = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblLocalDVLAppIDOutput = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.lbl_FeesOutput = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblLDVLappID = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.lbl_Applicant = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblApp_ID = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblApplicationDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblUser = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblFees = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbltrails = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblID = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnSaveAppointmentDateTest = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.checkBoxFail = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.checkBoxPass = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.txtBoxNotes = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lblFomTitle = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(373, 624);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 33);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditAppointmentTSM,
            this.toolStripSeparator1,
            this.takeTestTSMenu});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 54);
            // 
            // EditAppointmentTSM
            // 
            this.EditAppointmentTSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(102)))));
            this.EditAppointmentTSM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditAppointmentTSM.ForeColor = System.Drawing.Color.White;
            this.EditAppointmentTSM.Image = global::Project19.Properties.Resources.edit;
            this.EditAppointmentTSM.Name = "EditAppointmentTSM";
            this.EditAppointmentTSM.Size = new System.Drawing.Size(168, 22);
            this.EditAppointmentTSM.Text = "Edit Appointment";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(102)))));
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // takeTestTSMenu
            // 
            this.takeTestTSMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(102)))));
            this.takeTestTSMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeTestTSMenu.ForeColor = System.Drawing.Color.White;
            this.takeTestTSMenu.Image = global::Project19.Properties.Resources.test__2_;
            this.takeTestTSMenu.Name = "takeTestTSMenu";
            this.takeTestTSMenu.Size = new System.Drawing.Size(168, 22);
            this.takeTestTSMenu.Text = "Take Test";
            // 
            // kryptonContextMenuHeading1
            // 
            this.kryptonContextMenuHeading1.ExtraText = "";
            // 
            // kryptonContextMenuItems1
            // 
            this.kryptonContextMenuItems1.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItem1});
            // 
            // kryptonContextMenuItem1
            // 
            this.kryptonContextMenuItem1.Text = "Take Test";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(7, 53);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.pictureBox6);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblClassesOutput);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblApp_Date);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblClass);
            this.kryptonGroupBox1.Panel.Controls.Add(this.pictureBox3);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbl_trailsOutput);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblLocalDVLAppIDOutput);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbl_FeesOutput);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblLDVLappID);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbl_Applicant);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblApp_ID);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblApplicationDate);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblUser);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblFees);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbltrails);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblID);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(474, 353);
            this.kryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroupBox1.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonGroupBox1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.kryptonGroupBox1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.kryptonGroupBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox1.StateCommon.Border.Rounding = 5;
            this.kryptonGroupBox1.StateCommon.Border.Width = 2;
            this.kryptonGroupBox1.TabIndex = 55;
            this.kryptonGroupBox1.Values.Heading = " Vesion Test";
            this.kryptonGroupBox1.Values.Image = global::Project19.Properties.Resources.eye_test;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Project19.Properties.Resources.id_card__1_;
            this.pictureBox6.Location = new System.Drawing.Point(178, 56);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 24);
            this.pictureBox6.TabIndex = 68;
            this.pictureBox6.TabStop = false;
            // 
            // lblClassesOutput
            // 
            this.lblClassesOutput.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassesOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.lblClassesOutput.Location = new System.Drawing.Point(208, 60);
            this.lblClassesOutput.Name = "lblClassesOutput";
            this.lblClassesOutput.Size = new System.Drawing.Size(0, 20);
            this.lblClassesOutput.StateCommon.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassesOutput.StateCommon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            // 
            // lblApp_Date
            // 
            this.lblApp_Date.Location = new System.Drawing.Point(130, 153);
            this.lblApp_Date.Name = "lblApp_Date";
            this.lblApp_Date.Size = new System.Drawing.Size(54, 20);
            this.lblApp_Date.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(102)))));
            this.lblApp_Date.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(102)))));
            this.lblApp_Date.TabIndex = 60;
            this.lblApp_Date.Values.Text = "XXXXXX";
            // 
            // lblClass
            // 
            this.lblClass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.lblClass.Location = new System.Drawing.Point(28, 60);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(141, 20);
            this.lblClass.StateCommon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.StateCommon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.lblClass.Text = "Applied for license :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Project19.Properties.Resources.id_card;
            this.pictureBox3.Location = new System.Drawing.Point(176, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 58;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_trailsOutput
            // 
            this.lbl_trailsOutput.Location = new System.Drawing.Point(130, 263);
            this.lbl_trailsOutput.Name = "lbl_trailsOutput";
            this.lbl_trailsOutput.Size = new System.Drawing.Size(54, 20);
            this.lbl_trailsOutput.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(102)))));
            this.lbl_trailsOutput.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(102)))));
            this.lbl_trailsOutput.TabIndex = 58;
            this.lbl_trailsOutput.Values.Text = "XXXXXX";
            // 
            // lblLocalDVLAppIDOutput
            // 
            this.lblLocalDVLAppIDOutput.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalDVLAppIDOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.lblLocalDVLAppIDOutput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLocalDVLAppIDOutput.Location = new System.Drawing.Point(208, 28);
            this.lblLocalDVLAppIDOutput.Name = "lblLocalDVLAppIDOutput";
            this.lblLocalDVLAppIDOutput.Size = new System.Drawing.Size(0, 20);
            this.lblLocalDVLAppIDOutput.StateCommon.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalDVLAppIDOutput.StateCommon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            // 
            // lbl_FeesOutput
            // 
            this.lbl_FeesOutput.Location = new System.Drawing.Point(130, 189);
            this.lbl_FeesOutput.Name = "lbl_FeesOutput";
            this.lbl_FeesOutput.Size = new System.Drawing.Size(54, 20);
            this.lbl_FeesOutput.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(102)))));
            this.lbl_FeesOutput.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(102)))));
            this.lbl_FeesOutput.TabIndex = 57;
            this.lbl_FeesOutput.Values.Text = "XXXXXX";
            // 
            // lblLDVLappID
            // 
            this.lblLDVLappID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLDVLappID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.lblLDVLappID.Location = new System.Drawing.Point(19, 28);
            this.lblLDVLappID.Name = "lblLDVLappID";
            this.lblLDVLappID.Size = new System.Drawing.Size(150, 20);
            this.lblLDVLappID.StateCommon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLDVLappID.StateCommon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.lblLDVLappID.Text = "LDVL Application ID :";
            // 
            // lbl_Applicant
            // 
            this.lbl_Applicant.Location = new System.Drawing.Point(132, 117);
            this.lbl_Applicant.Name = "lbl_Applicant";
            this.lbl_Applicant.Size = new System.Drawing.Size(54, 20);
            this.lbl_Applicant.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(102)))));
            this.lbl_Applicant.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(102)))));
            this.lbl_Applicant.TabIndex = 55;
            this.lbl_Applicant.Values.Text = "XXXXXX";
            // 
            // lblApp_ID
            // 
            this.lblApp_ID.Location = new System.Drawing.Point(130, 226);
            this.lblApp_ID.Name = "lblApp_ID";
            this.lblApp_ID.Size = new System.Drawing.Size(87, 20);
            this.lblApp_ID.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(102)))));
            this.lblApp_ID.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(102)))));
            this.lblApp_ID.TabIndex = 54;
            this.lblApp_ID.Values.Text = "Non taken yet";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.Location = new System.Drawing.Point(28, 148);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(80, 26);
            this.lblApplicationDate.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.lblApplicationDate.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.lblApplicationDate.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.TabIndex = 53;
            this.lblApplicationDate.Values.Image = global::Project19.Properties.Resources.calendar;
            this.lblApplicationDate.Values.Text = " Date :";
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(28, 111);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(98, 26);
            this.lblUser.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.lblUser.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.lblUser.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.TabIndex = 50;
            this.lblUser.Values.Image = global::Project19.Properties.Resources.user__4_;
            this.lblUser.Values.Text = "   Name :";
            // 
            // lblFees
            // 
            this.lblFees.Location = new System.Drawing.Point(28, 185);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(87, 26);
            this.lblFees.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.lblFees.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.lblFees.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.TabIndex = 47;
            this.lblFees.Values.Image = global::Project19.Properties.Resources.coin;
            this.lblFees.Values.Text = "   Fees :";
            // 
            // lbltrails
            // 
            this.lbltrails.Location = new System.Drawing.Point(28, 259);
            this.lbltrails.Name = "lbltrails";
            this.lbltrails.Size = new System.Drawing.Size(92, 26);
            this.lbltrails.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.lbltrails.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.lbltrails.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltrails.TabIndex = 46;
            this.lbltrails.Values.Image = global::Project19.Properties.Resources.check_list__1_;
            this.lbltrails.Values.Text = "   Trails :";
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(28, 222);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(100, 26);
            this.lblID.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.lblID.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.lblID.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.TabIndex = 45;
            this.lblID.Values.Image = global::Project19.Properties.Resources.indesign;
            this.lblID.Values.Text = "  Test ID :";
            // 
            // btnSaveAppointmentDateTest
            // 
            this.btnSaveAppointmentDateTest.Location = new System.Drawing.Point(6, 614);
            this.btnSaveAppointmentDateTest.Name = "btnSaveAppointmentDateTest";
            this.btnSaveAppointmentDateTest.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSaveAppointmentDateTest.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSaveAppointmentDateTest.OverrideDefault.Back.ColorAngle = 45F;
            this.btnSaveAppointmentDateTest.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSaveAppointmentDateTest.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSaveAppointmentDateTest.OverrideDefault.Border.ColorAngle = 45F;
            this.btnSaveAppointmentDateTest.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSaveAppointmentDateTest.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSaveAppointmentDateTest.OverrideDefault.Border.Rounding = 20;
            this.btnSaveAppointmentDateTest.OverrideDefault.Border.Width = 1;
            this.btnSaveAppointmentDateTest.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSaveAppointmentDateTest.Size = new System.Drawing.Size(125, 43);
            this.btnSaveAppointmentDateTest.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.btnSaveAppointmentDateTest.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.btnSaveAppointmentDateTest.StateCommon.Back.ColorAngle = 45F;
            this.btnSaveAppointmentDateTest.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.btnSaveAppointmentDateTest.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.btnSaveAppointmentDateTest.StateCommon.Border.ColorAngle = 45F;
            this.btnSaveAppointmentDateTest.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSaveAppointmentDateTest.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSaveAppointmentDateTest.StateCommon.Border.Rounding = 20;
            this.btnSaveAppointmentDateTest.StateCommon.Border.Width = 1;
            this.btnSaveAppointmentDateTest.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSaveAppointmentDateTest.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSaveAppointmentDateTest.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAppointmentDateTest.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaveAppointmentDateTest.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSaveAppointmentDateTest.StateDisabled.Back.ColorAngle = 45F;
            this.btnSaveAppointmentDateTest.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.btnSaveAppointmentDateTest.StateDisabled.Content.ShortText.Color2 = System.Drawing.Color.Gray;
            this.btnSaveAppointmentDateTest.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.btnSaveAppointmentDateTest.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.btnSaveAppointmentDateTest.StatePressed.Back.ColorAngle = 135F;
            this.btnSaveAppointmentDateTest.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.btnSaveAppointmentDateTest.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.btnSaveAppointmentDateTest.StatePressed.Border.ColorAngle = 135F;
            this.btnSaveAppointmentDateTest.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSaveAppointmentDateTest.StatePressed.Border.Rounding = 20;
            this.btnSaveAppointmentDateTest.StatePressed.Border.Width = 1;
            this.btnSaveAppointmentDateTest.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.btnSaveAppointmentDateTest.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.btnSaveAppointmentDateTest.StateTracking.Back.ColorAngle = 45F;
            this.btnSaveAppointmentDateTest.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.btnSaveAppointmentDateTest.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.btnSaveAppointmentDateTest.StateTracking.Border.ColorAngle = 45F;
            this.btnSaveAppointmentDateTest.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSaveAppointmentDateTest.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSaveAppointmentDateTest.StateTracking.Border.Rounding = 20;
            this.btnSaveAppointmentDateTest.StateTracking.Border.Width = 1;
            this.btnSaveAppointmentDateTest.TabIndex = 56;
            this.btnSaveAppointmentDateTest.Values.Image = global::Project19.Properties.Resources.save;
            this.btnSaveAppointmentDateTest.Values.Text = " Save";
            this.btnSaveAppointmentDateTest.Click += new System.EventHandler(this.btnSaveAppointmentDateTest_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(24, 424);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(104, 34);
            this.kryptonLabel1.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.kryptonLabel1.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.kryptonLabel1.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 57;
            this.kryptonLabel1.Values.Image = global::Project19.Properties.Resources.testing;
            this.kryptonLabel1.Values.Text = "  Result :";
            // 
            // checkBoxFail
            // 
            this.checkBoxFail.Location = new System.Drawing.Point(187, 424);
            this.checkBoxFail.Name = "checkBoxFail";
            this.checkBoxFail.Size = new System.Drawing.Size(69, 28);
            this.checkBoxFail.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.checkBoxFail.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.checkBoxFail.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFail.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.checkBoxFail.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.checkBoxFail.TabIndex = 58;
            this.checkBoxFail.Values.Image = global::Project19.Properties.Resources.cancel__1_;
            this.checkBoxFail.Values.Text = "Fail";
            this.checkBoxFail.CheckedChanged += new System.EventHandler(this.kryptonCheckBox1_CheckedChanged);
            // 
            // checkBoxPass
            // 
            this.checkBoxPass.Location = new System.Drawing.Point(285, 424);
            this.checkBoxPass.Name = "checkBoxPass";
            this.checkBoxPass.Size = new System.Drawing.Size(77, 28);
            this.checkBoxPass.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.checkBoxPass.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.checkBoxPass.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPass.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.checkBoxPass.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.checkBoxPass.TabIndex = 59;
            this.checkBoxPass.Values.Image = global::Project19.Properties.Resources.check__2_;
            this.checkBoxPass.Values.Text = "Pass";
            this.checkBoxPass.CheckedChanged += new System.EventHandler(this.checkBoxPass_CheckedChanged);
            // 
            // txtBoxNotes
            // 
            this.txtBoxNotes.Location = new System.Drawing.Point(30, 507);
            this.txtBoxNotes.MaxLength = 500;
            this.txtBoxNotes.Name = "txtBoxNotes";
            this.txtBoxNotes.Size = new System.Drawing.Size(445, 77);
            this.txtBoxNotes.TabIndex = 60;
            this.txtBoxNotes.Text = "";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(26, 464);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(103, 34);
            this.kryptonLabel2.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.kryptonLabel2.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.kryptonLabel2.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 61;
            this.kryptonLabel2.Values.Image = global::Project19.Properties.Resources.write__1_;
            this.kryptonLabel2.Values.Text = "  Notes :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project19.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(466, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.lblFomTitle);
            this.kryptonPanel1.Location = new System.Drawing.Point(-4, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(500, 34);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.kryptonPanel1.TabIndex = 81;
            // 
            // lblFomTitle
            // 
            this.lblFomTitle.Location = new System.Drawing.Point(7, 3);
            this.lblFomTitle.Name = "lblFomTitle";
            this.lblFomTitle.Size = new System.Drawing.Size(82, 26);
            this.lblFomTitle.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.lblFomTitle.StateNormal.ShortText.Color2 = System.Drawing.Color.White;
            this.lblFomTitle.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFomTitle.TabIndex = 81;
            this.lblFomTitle.Values.Text = "Take Test";
            // 
            // Frm_Take_Tests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(493, 666);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.txtBoxNotes);
            this.Controls.Add(this.checkBoxPass);
            this.Controls.Add(this.checkBoxFail);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.btnSaveAppointmentDateTest);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Take_Tests";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 5;
            this.Text = "Frm_Add_User";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExit;
        private ToolTip toolTip1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem EditAppointmentTSM;
        private ToolStripMenuItem takeTestTSMenu;
        private ToolStripSeparator toolStripSeparator1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblApp_Date;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_trailsOutput;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_FeesOutput;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Applicant;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblApp_ID;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblApplicationDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblUser;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblFees;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbltrails;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblID;
        private PictureBox pictureBox3;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel lblLocalDVLAppIDOutput;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel lblLDVLappID;
        private PictureBox pictureBox6;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel lblClassesOutput;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel lblClass;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSaveAppointmentDateTest;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox checkBoxFail;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox checkBoxPass;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txtBoxNotes;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblFomTitle;
    }
}