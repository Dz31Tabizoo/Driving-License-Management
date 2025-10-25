using System.Windows.Forms;

namespace Project19
{
    partial class Frm_Shcuduel_Tests
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblFormTitle = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnAddApointment = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditAppointmentTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.takeTestTSMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.lblApointmentTitle = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.kryptonContextMenuHeading1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading();
            this.kryptonContextMenuItems1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.crtlApplicationInfo1 = new Project19.crtlApplicationInfo();
            this.crtlLDVLappInfo1 = new Project19.crtlLDVLappInfo();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(723, 678);
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
            // lblFormTitle
            // 
            this.lblFormTitle.Location = new System.Drawing.Point(16, 8);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(295, 29);
            this.lblFormTitle.StateNormal.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.lblFormTitle.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.lblFormTitle.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.lblFormTitle.StateNormal.ShortText.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.StateNormal.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.lblFormTitle.TabIndex = 22;
            this.lblFormTitle.Values.Text = "Vision Test Appointment";
            // 
            // btnAddApointment
            // 
            this.btnAddApointment.Location = new System.Drawing.Point(763, 458);
            this.btnAddApointment.Name = "btnAddApointment";
            this.btnAddApointment.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddApointment.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddApointment.OverrideDefault.Back.ColorAngle = 45F;
            this.btnAddApointment.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddApointment.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddApointment.OverrideDefault.Border.ColorAngle = 45F;
            this.btnAddApointment.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddApointment.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddApointment.OverrideDefault.Border.Rounding = 20;
            this.btnAddApointment.OverrideDefault.Border.Width = 1;
            this.btnAddApointment.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnAddApointment.Size = new System.Drawing.Size(46, 45);
            this.btnAddApointment.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.btnAddApointment.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.btnAddApointment.StateCommon.Back.ColorAngle = 45F;
            this.btnAddApointment.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.btnAddApointment.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.btnAddApointment.StateCommon.Border.ColorAngle = 45F;
            this.btnAddApointment.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddApointment.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddApointment.StateCommon.Border.Rounding = 20;
            this.btnAddApointment.StateCommon.Border.Width = 1;
            this.btnAddApointment.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAddApointment.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAddApointment.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddApointment.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.btnAddApointment.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.btnAddApointment.StatePressed.Back.ColorAngle = 135F;
            this.btnAddApointment.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.btnAddApointment.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.btnAddApointment.StatePressed.Border.ColorAngle = 135F;
            this.btnAddApointment.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddApointment.StatePressed.Border.Rounding = 20;
            this.btnAddApointment.StatePressed.Border.Width = 1;
            this.btnAddApointment.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.btnAddApointment.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.btnAddApointment.StateTracking.Back.ColorAngle = 45F;
            this.btnAddApointment.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.btnAddApointment.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.btnAddApointment.StateTracking.Border.ColorAngle = 45F;
            this.btnAddApointment.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddApointment.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddApointment.StateTracking.Border.Rounding = 20;
            this.btnAddApointment.StateTracking.Border.Width = 1;
            this.btnAddApointment.TabIndex = 42;
            this.btnAddApointment.Values.Image = global::Project19.Properties.Resources.calendar__1_;
            this.btnAddApointment.Values.Text = "";
            this.btnAddApointment.Click += new System.EventHandler(this.btnAddApointment_Click);
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointments.BackgroundColor = System.Drawing.Color.White;
            this.dgvAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppointments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAppointments.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAppointments.ColumnHeadersHeight = 40;
            this.dgvAppointments.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAppointments.EnableHeadersVisualStyles = false;
            this.dgvAppointments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dgvAppointments.Location = new System.Drawing.Point(21, 509);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Footlight MT Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAppointments.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAppointments.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.Size = new System.Drawing.Size(785, 164);
            this.dgvAppointments.TabIndex = 43;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditAppointmentTSM,
            this.toolStripSeparator1,
            this.takeTestTSMenu});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 76);
            // 
            // EditAppointmentTSM
            // 
            this.EditAppointmentTSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(102)))));
            this.EditAppointmentTSM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditAppointmentTSM.ForeColor = System.Drawing.Color.White;
            this.EditAppointmentTSM.Image = global::Project19.Properties.Resources.edit;
            this.EditAppointmentTSM.Name = "EditAppointmentTSM";
            this.EditAppointmentTSM.Size = new System.Drawing.Size(180, 22);
            this.EditAppointmentTSM.Text = "Edit Appointment";
            this.EditAppointmentTSM.Click += new System.EventHandler(this.EditAppointmentTSM_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(102)))));
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // takeTestTSMenu
            // 
            this.takeTestTSMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(102)))));
            this.takeTestTSMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeTestTSMenu.ForeColor = System.Drawing.Color.White;
            this.takeTestTSMenu.Image = global::Project19.Properties.Resources.test__2_;
            this.takeTestTSMenu.Name = "takeTestTSMenu";
            this.takeTestTSMenu.Size = new System.Drawing.Size(180, 22);
            this.takeTestTSMenu.Text = "Take Test";
            // 
            // lblApointmentTitle
            // 
            this.lblApointmentTitle.Location = new System.Drawing.Point(17, 463);
            this.lblApointmentTitle.Name = "lblApointmentTitle";
            this.lblApointmentTitle.Size = new System.Drawing.Size(144, 26);
            this.lblApointmentTitle.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.lblApointmentTitle.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.lblApointmentTitle.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApointmentTitle.TabIndex = 54;
            this.lblApointmentTitle.Values.Image = global::Project19.Properties.Resources._19795265411582994870_24;
            this.lblApointmentTitle.Values.Text = "Appointments :";
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
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project19.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(798, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // crtlApplicationInfo1
            // 
            this.crtlApplicationInfo1.BackColor = System.Drawing.Color.White;
            this.crtlApplicationInfo1.Location = new System.Drawing.Point(6, 168);
            this.crtlApplicationInfo1.Name = "crtlApplicationInfo1";
            this.crtlApplicationInfo1.Size = new System.Drawing.Size(814, 289);
            this.crtlApplicationInfo1.TabIndex = 41;
            // 
            // crtlLDVLappInfo1
            // 
            this.crtlLDVLappInfo1.BackColor = System.Drawing.Color.White;
            this.crtlLDVLappInfo1.Location = new System.Drawing.Point(6, 39);
            this.crtlLDVLappInfo1.Name = "crtlLDVLappInfo1";
            this.crtlLDVLappInfo1.Size = new System.Drawing.Size(814, 134);
            this.crtlLDVLappInfo1.TabIndex = 40;
            // 
            // Frm_Shcuduel_Tests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 715);
            this.Controls.Add(this.lblApointmentTitle);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.btnAddApointment);
            this.Controls.Add(this.crtlApplicationInfo1);
            this.Controls.Add(this.crtlLDVLappInfo1);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Shcuduel_Tests";
            this.Text = "Frm_Add_User";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExit;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblFormTitle;
        private crtlLDVLappInfo crtlLDVLappInfo1;
        private crtlApplicationInfo crtlApplicationInfo1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddApointment;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblApointmentTitle;
        private ToolTip toolTip1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem EditAppointmentTSM;
        private ToolStripMenuItem takeTestTSMenu;
        private ToolStripSeparator toolStripSeparator1;
    }
}
