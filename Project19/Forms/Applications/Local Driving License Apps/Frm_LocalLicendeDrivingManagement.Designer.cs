using ComponentFactory.Krypton.Toolkit;

namespace Project19
{
    partial class Frm_LocalLicendeDrivingManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddNewtoolstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ChangePAsswordtoolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writtenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.issueDrivingLicense1stTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.showDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lblTotalUserNum = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblTotalPeople = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnClosePeopleMng = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgvApplications = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblTitle = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblAddPerson = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnClear = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cmbSearchCriteria = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.TxtSearchTerm = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonContextMenuItem1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSearchCriteria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.contextMenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.AddNewtoolstrip,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator6,
            this.ChangePAsswordtoolStrip,
            this.toolStripSeparator3,
            this.phoneCallToolStripMenuItem,
            this.toolStripSeparator5,
            this.issueDrivingLicense1stTimeToolStripMenuItem,
            this.toolStripSeparator2,
            this.showDrivingLicenseToolStripMenuItem,
            this.toolStripSeparator4,
            this.emailToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(278, 404);
            this.contextMenuStrip1.Text = "User Options";
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showDetailsToolStripMenuItem.Image = global::Project19.Properties.Resources.info;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(277, 38);
            this.showDetailsToolStripMenuItem.Text = "Show Application Details";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(274, 6);
            // 
            // AddNewtoolstrip
            // 
            this.AddNewtoolstrip.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewtoolstrip.ForeColor = System.Drawing.Color.White;
            this.AddNewtoolstrip.Image = global::Project19.Properties.Resources.tab;
            this.AddNewtoolstrip.Name = "AddNewtoolstrip";
            this.AddNewtoolstrip.Size = new System.Drawing.Size(277, 38);
            this.AddNewtoolstrip.Text = "Add New Application";
            this.AddNewtoolstrip.Click += new System.EventHandler(this.AddNewtoolstrip_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Image = global::Project19.Properties.Resources.edit;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(277, 38);
            this.editToolStripMenuItem.Text = "Edit Application";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteToolStripMenuItem.Image = global::Project19.Properties.Resources.delete__3_;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(277, 38);
            this.deleteToolStripMenuItem.Text = "Delete ";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(274, 6);
            // 
            // ChangePAsswordtoolStrip
            // 
            this.ChangePAsswordtoolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChangePAsswordtoolStrip.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePAsswordtoolStrip.ForeColor = System.Drawing.Color.White;
            this.ChangePAsswordtoolStrip.Image = global::Project19.Properties.Resources.cross;
            this.ChangePAsswordtoolStrip.Name = "ChangePAsswordtoolStrip";
            this.ChangePAsswordtoolStrip.Size = new System.Drawing.Size(277, 38);
            this.ChangePAsswordtoolStrip.Text = "Cancel Application";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(274, 6);
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visionTestToolStripMenuItem,
            this.writtenTestToolStripMenuItem,
            this.practicalToolStripMenuItem});
            this.phoneCallToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneCallToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.phoneCallToolStripMenuItem.Image = global::Project19.Properties.Resources.calendar1;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(277, 38);
            this.phoneCallToolStripMenuItem.Text = "Sechdule Tests";
            // 
            // visionTestToolStripMenuItem
            // 
            this.visionTestToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.visionTestToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.visionTestToolStripMenuItem.Image = global::Project19.Properties.Resources.eye__2_;
            this.visionTestToolStripMenuItem.Name = "visionTestToolStripMenuItem";
            this.visionTestToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.visionTestToolStripMenuItem.Text = "Vision Test";
            this.visionTestToolStripMenuItem.Click += new System.EventHandler(this.visionTestToolStripMenuItem_Click);
            // 
            // writtenTestToolStripMenuItem
            // 
            this.writtenTestToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.writtenTestToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.writtenTestToolStripMenuItem.Image = global::Project19.Properties.Resources.document;
            this.writtenTestToolStripMenuItem.Name = "writtenTestToolStripMenuItem";
            this.writtenTestToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.writtenTestToolStripMenuItem.Text = "Written Test";
            // 
            // practicalToolStripMenuItem
            // 
            this.practicalToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.practicalToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.practicalToolStripMenuItem.Image = global::Project19.Properties.Resources.steering_wheel;
            this.practicalToolStripMenuItem.Name = "practicalToolStripMenuItem";
            this.practicalToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.practicalToolStripMenuItem.Text = "Practical";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(274, 6);
            // 
            // issueDrivingLicense1stTimeToolStripMenuItem
            // 
            this.issueDrivingLicense1stTimeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.issueDrivingLicense1stTimeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.issueDrivingLicense1stTimeToolStripMenuItem.Image = global::Project19.Properties.Resources.registered_document;
            this.issueDrivingLicense1stTimeToolStripMenuItem.Name = "issueDrivingLicense1stTimeToolStripMenuItem";
            this.issueDrivingLicense1stTimeToolStripMenuItem.Size = new System.Drawing.Size(277, 38);
            this.issueDrivingLicense1stTimeToolStripMenuItem.Text = "Issue Driving License (1st Time)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(274, 6);
            // 
            // showDrivingLicenseToolStripMenuItem
            // 
            this.showDrivingLicenseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.showDrivingLicenseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showDrivingLicenseToolStripMenuItem.Image = global::Project19.Properties.Resources.licensing;
            this.showDrivingLicenseToolStripMenuItem.Name = "showDrivingLicenseToolStripMenuItem";
            this.showDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(277, 38);
            this.showDrivingLicenseToolStripMenuItem.Text = "Show Driving License";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(274, 6);
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.emailToolStripMenuItem.Image = global::Project19.Properties.Resources.history;
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(277, 38);
            this.emailToolStripMenuItem.Text = "Show Person License History";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel1.Controls.Add(this.lblTotalUserNum);
            this.kryptonPanel1.Controls.Add(this.lblTotalPeople);
            this.kryptonPanel1.Controls.Add(this.btnClosePeopleMng);
            this.kryptonPanel1.Controls.Add(this.dgvApplications);
            this.kryptonPanel1.Controls.Add(this.panel1);
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(994, 700);
            this.kryptonPanel1.StateNormal.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.StateNormal.Color2 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 0;
            // 
            // lblTotalUserNum
            // 
            this.lblTotalUserNum.Location = new System.Drawing.Point(145, 668);
            this.lblTotalUserNum.Name = "lblTotalUserNum";
            this.lblTotalUserNum.Size = new System.Drawing.Size(45, 29);
            this.lblTotalUserNum.StateNormal.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.lblTotalUserNum.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.lblTotalUserNum.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.lblTotalUserNum.StateNormal.ShortText.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUserNum.StateNormal.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.lblTotalUserNum.TabIndex = 4;
            this.lblTotalUserNum.Values.Text = "000";
            // 
            // lblTotalPeople
            // 
            this.lblTotalPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalPeople.Location = new System.Drawing.Point(12, 659);
            this.lblTotalPeople.Name = "lblTotalPeople";
            this.lblTotalPeople.Size = new System.Drawing.Size(127, 29);
            this.lblTotalPeople.StateNormal.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.lblTotalPeople.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.lblTotalPeople.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.lblTotalPeople.StateNormal.ShortText.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPeople.StateNormal.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.lblTotalPeople.TabIndex = 3;
            this.lblTotalPeople.Values.Text = "Total People";
            // 
            // btnClosePeopleMng
            // 
            this.btnClosePeopleMng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClosePeopleMng.Location = new System.Drawing.Point(869, 644);
            this.btnClosePeopleMng.Name = "btnClosePeopleMng";
            this.btnClosePeopleMng.Size = new System.Drawing.Size(106, 33);
            this.btnClosePeopleMng.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnClosePeopleMng.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnClosePeopleMng.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClosePeopleMng.StateCommon.Border.Rounding = 5;
            this.btnClosePeopleMng.StateCommon.Border.Width = 0;
            this.btnClosePeopleMng.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnClosePeopleMng.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnClosePeopleMng.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnClosePeopleMng.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnClosePeopleMng.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClosePeopleMng.StateNormal.Border.Rounding = 5;
            this.btnClosePeopleMng.StateNormal.Border.Width = 0;
            this.btnClosePeopleMng.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnClosePeopleMng.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnClosePeopleMng.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosePeopleMng.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.btnClosePeopleMng.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.btnClosePeopleMng.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClosePeopleMng.StatePressed.Border.Rounding = 5;
            this.btnClosePeopleMng.StatePressed.Border.Width = 0;
            this.btnClosePeopleMng.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.btnClosePeopleMng.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.btnClosePeopleMng.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.btnClosePeopleMng.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.btnClosePeopleMng.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClosePeopleMng.StateTracking.Border.Rounding = 5;
            this.btnClosePeopleMng.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnClosePeopleMng.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnClosePeopleMng.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosePeopleMng.TabIndex = 2;
            this.btnClosePeopleMng.Values.Text = "Close";
            this.btnClosePeopleMng.Click += new System.EventHandler(this.btnClosePeopleMng_Click);
            // 
            // dgvApplications
            // 
            this.dgvApplications.AllowUserToAddRows = false;
            this.dgvApplications.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvApplications.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApplications.BackgroundColor = System.Drawing.Color.White;
            this.dgvApplications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvApplications.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvApplications.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvApplications.ColumnHeadersHeight = 40;
            this.dgvApplications.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvApplications.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvApplications.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvApplications.EnableHeadersVisualStyles = false;
            this.dgvApplications.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dgvApplications.Location = new System.Drawing.Point(0, 134);
            this.dgvApplications.MultiSelect = false;
            this.dgvApplications.Name = "dgvApplications";
            this.dgvApplications.ReadOnly = true;
            this.dgvApplications.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplications.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvApplications.RowHeadersVisible = false;
            this.dgvApplications.RowHeadersWidth = 30;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvApplications.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvApplications.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvApplications.RowTemplate.Height = 30;
            this.dgvApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplications.Size = new System.Drawing.Size(994, 397);
            this.dgvApplications.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.lblAddPerson);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.cmbSearchCriteria);
            this.panel1.Controls.Add(this.TxtSearchTerm);
            this.panel1.Controls.Add(this.kryptonLabel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 134);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project19.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(969, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(625, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.btnSearch.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.btnSearch.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.btnSearch.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.btnSearch.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearch.OverrideDefault.Border.Rounding = 5;
            this.btnSearch.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSearch.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSearch.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearch.OverrideFocus.Border.Rounding = 5;
            this.btnSearch.Size = new System.Drawing.Size(106, 33);
            this.btnSearch.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.btnSearch.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.btnSearch.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.btnSearch.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.btnSearch.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearch.StateCommon.Border.Rounding = 5;
            this.btnSearch.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSearch.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSearch.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnSearch.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnSearch.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearch.StateDisabled.Border.Rounding = 5;
            this.btnSearch.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.btnSearch.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.btnSearch.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.btnSearch.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.btnSearch.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearch.StateNormal.Border.Rounding = 5;
            this.btnSearch.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSearch.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSearch.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.btnSearch.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.btnSearch.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearch.StatePressed.Border.Rounding = 5;
            this.btnSearch.StatePressed.Border.Width = 0;
            this.btnSearch.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSearch.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSearch.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.btnSearch.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.btnSearch.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearch.StateTracking.Border.Rounding = 5;
            this.btnSearch.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSearch.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSearch.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Values.Text = "Search";
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(3, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(356, 26);
            this.lblTitle.StateNormal.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.lblTitle.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.lblTitle.StateNormal.ShortText.Color2 = System.Drawing.Color.White;
            this.lblTitle.StateNormal.ShortText.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.StateNormal.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Values.Text = "Local Driving License Applications";
            // 
            // lblAddPerson
            // 
            this.lblAddPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddPerson.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ToolTip;
            this.lblAddPerson.Location = new System.Drawing.Point(803, 94);
            this.lblAddPerson.Name = "lblAddPerson";
            this.lblAddPerson.Size = new System.Drawing.Size(175, 29);
            this.lblAddPerson.StateNormal.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.lblAddPerson.StateNormal.Image.ImageColorMap = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.lblAddPerson.StateNormal.Image.ImageColorTo = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.lblAddPerson.StateNormal.Padding = new System.Windows.Forms.Padding(8, -1, -1, -1);
            this.lblAddPerson.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.lblAddPerson.StateNormal.ShortText.Color2 = System.Drawing.Color.White;
            this.lblAddPerson.StateNormal.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertPressed;
            this.lblAddPerson.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPerson.StateNormal.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.lblAddPerson.TabIndex = 7;
            this.lblAddPerson.UseMnemonic = false;
            this.lblAddPerson.Values.Image = global::Project19.Properties.Resources.app;
            this.lblAddPerson.Values.Text = "  Add Application";
            this.lblAddPerson.Click += new System.EventHandler(this.lblAddPerson_Click);
            this.lblAddPerson.MouseEnter += new System.EventHandler(this.lblAddPerson_MouseEnter);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(780, 46);
            this.btnClear.Name = "btnClear";
            this.btnClear.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnClear.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnClear.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnClear.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnClear.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClear.OverrideDefault.Border.Rounding = 5;
            this.btnClear.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnClear.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnClear.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClear.OverrideFocus.Border.Rounding = 5;
            this.btnClear.Size = new System.Drawing.Size(124, 34);
            this.btnClear.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnClear.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnClear.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnClear.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnClear.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClear.StateCommon.Border.Rounding = 5;
            this.btnClear.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnClear.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnClear.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnClear.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnClear.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClear.StateDisabled.Border.Rounding = 5;
            this.btnClear.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnClear.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnClear.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnClear.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnClear.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClear.StateNormal.Border.Rounding = 5;
            this.btnClear.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnClear.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnClear.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.btnClear.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.btnClear.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClear.StatePressed.Border.Rounding = 5;
            this.btnClear.StatePressed.Border.Width = 0;
            this.btnClear.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnClear.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnClear.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.btnClear.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.btnClear.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClear.StateTracking.Border.Rounding = 5;
            this.btnClear.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnClear.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnClear.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.TabIndex = 6;
            this.btnClear.Values.Text = "Clear";
            // 
            // cmbSearchCriteria
            // 
            this.cmbSearchCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchCriteria.DropDownWidth = 183;
            this.cmbSearchCriteria.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.cmbSearchCriteria.Items.AddRange(new object[] {
            "None",
            "User ID",
            "User Name",
            "Person ID",
            "Full Name",
            "IsActive"});
            this.cmbSearchCriteria.Location = new System.Drawing.Point(140, 46);
            this.cmbSearchCriteria.Name = "cmbSearchCriteria";
            this.cmbSearchCriteria.Size = new System.Drawing.Size(183, 27);
            this.cmbSearchCriteria.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cmbSearchCriteria.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.cmbSearchCriteria.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.cmbSearchCriteria.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbSearchCriteria.StateCommon.ComboBox.Border.Rounding = 5;
            this.cmbSearchCriteria.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.cmbSearchCriteria.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchCriteria.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.cmbSearchCriteria.StateCommon.DropBack.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.cmbSearchCriteria.StateCommon.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.cmbSearchCriteria.StateCommon.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.cmbSearchCriteria.StateCommon.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.cmbSearchCriteria.StateCommon.Item.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.cmbSearchCriteria.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbSearchCriteria.StateCommon.Item.Content.Padding = new System.Windows.Forms.Padding(5, -1, -1, -1);
            this.cmbSearchCriteria.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.cmbSearchCriteria.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.cmbSearchCriteria.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchCriteria.TabIndex = 4;
            // 
            // TxtSearchTerm
            // 
            this.TxtSearchTerm.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.TxtSearchTerm.Location = new System.Drawing.Point(363, 46);
            this.TxtSearchTerm.Name = "TxtSearchTerm";
            this.TxtSearchTerm.Size = new System.Drawing.Size(205, 29);
            this.TxtSearchTerm.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.TxtSearchTerm.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.TxtSearchTerm.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TxtSearchTerm.StateActive.Border.Rounding = 5;
            this.TxtSearchTerm.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.TxtSearchTerm.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.TxtSearchTerm.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.TxtSearchTerm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TxtSearchTerm.StateCommon.Border.Rounding = 5;
            this.TxtSearchTerm.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.TxtSearchTerm.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearchTerm.TabIndex = 1;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(13, 46);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(111, 29);
            this.kryptonLabel2.StateNormal.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.kryptonLabel2.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.StateNormal.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonLabel2.StateNormal.ShortText.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateNormal.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.kryptonLabel2.TabIndex = 0;
            this.kryptonLabel2.Values.Image = global::Project19.Properties.Resources.filter;
            this.kryptonLabel2.Values.Text = "Filter by";
            // 
            // kryptonContextMenuItem1
            // 
            this.kryptonContextMenuItem1.Text = "Menu Item";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Frm_LocalLicendeDrivingManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(994, 700);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_LocalLicendeDrivingManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_User_Managment";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSearchCriteria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.DataGridView dgvApplications;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClosePeopleMng;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTotalPeople;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem AddNewtoolstrip;
        private System.Windows.Forms.ToolStripMenuItem ChangePAsswordtoolStrip;
        private KryptonLabel lblTotalUserNum;
        private System.Windows.Forms.Panel panel1;
        private KryptonLabel lblTitle;
        private KryptonLabel lblAddPerson;
        private KryptonButton btnClear;
        private KryptonComboBox cmbSearchCriteria;
        private KryptonTextBox TxtSearchTerm;
        private KryptonLabel kryptonLabel2;
        private KryptonButton btnSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicense1stTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem showDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem visionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writtenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practicalToolStripMenuItem;
    }
}