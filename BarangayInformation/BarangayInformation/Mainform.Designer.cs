
namespace BarangayInformation
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonResident = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLogout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSetting = new System.Windows.Forms.ToolStripSplitButton();
            this.contraceptiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gardenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toiletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waterSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nationalitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.religionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.petToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButtonAccessControl = new System.Windows.Forms.ToolStripSplitButton();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSetupControl = new System.Windows.Forms.ToolStripMenuItem();
            this.accessLevelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButtonAddress = new System.Windows.Forms.ToolStripSplitButton();
            this.countriesStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provinceStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barangaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelUser = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelRole = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelSystemTime = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonUser,
            this.toolStripButtonResident,
            this.toolStripButtonLogout,
            this.toolStripSetting,
            this.toolStripSplitButtonAccessControl,
            this.toolStripSplitButtonAddress});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(2, 5, 5, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1115, 91);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonUser
            // 
            this.toolStripButtonUser.Image = global::BarangayInformation.Properties.Resources.Admin_icon64x64;
            this.toolStripButtonUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUser.Name = "toolStripButtonUser";
            this.toolStripButtonUser.Size = new System.Drawing.Size(68, 83);
            this.toolStripButtonUser.Text = "User";
            this.toolStripButtonUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonUser.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButtonResident
            // 
            this.toolStripButtonResident.Image = global::BarangayInformation.Properties.Resources.people64x64;
            this.toolStripButtonResident.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonResident.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonResident.Name = "toolStripButtonResident";
            this.toolStripButtonResident.Size = new System.Drawing.Size(68, 83);
            this.toolStripButtonResident.Text = "Resident";
            this.toolStripButtonResident.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonResident.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButtonLogout
            // 
            this.toolStripButtonLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonLogout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLogout.Image")));
            this.toolStripButtonLogout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLogout.Name = "toolStripButtonLogout";
            this.toolStripButtonLogout.Size = new System.Drawing.Size(68, 83);
            this.toolStripButtonLogout.Text = "LOGOUT";
            this.toolStripButtonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonLogout.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSetting
            // 
            this.toolStripSetting.DropDownButtonWidth = 15;
            this.toolStripSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contraceptiveToolStripMenuItem,
            this.gardenToolStripMenuItem,
            this.toiletToolStripMenuItem,
            this.waterSourceToolStripMenuItem,
            this.toolStripSeparator1,
            this.nationalitiesToolStripMenuItem,
            this.religionsToolStripMenuItem,
            this.petToolStripMenuItem});
            this.toolStripSetting.Image = global::BarangayInformation.Properties.Resources.setting64x64;
            this.toolStripSetting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSetting.Name = "toolStripSetting";
            this.toolStripSetting.Size = new System.Drawing.Size(84, 83);
            this.toolStripSetting.Text = "SETUP";
            this.toolStripSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // contraceptiveToolStripMenuItem
            // 
            this.contraceptiveToolStripMenuItem.Name = "contraceptiveToolStripMenuItem";
            this.contraceptiveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contraceptiveToolStripMenuItem.Text = "Contraceptives";
            this.contraceptiveToolStripMenuItem.Click += new System.EventHandler(this.contraceptiveToolStripMenuItem_Click);
            // 
            // gardenToolStripMenuItem
            // 
            this.gardenToolStripMenuItem.Name = "gardenToolStripMenuItem";
            this.gardenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gardenToolStripMenuItem.Text = "Gardens";
            this.gardenToolStripMenuItem.Click += new System.EventHandler(this.gardenToolStripMenuItem_Click);
            // 
            // toiletToolStripMenuItem
            // 
            this.toiletToolStripMenuItem.Name = "toiletToolStripMenuItem";
            this.toiletToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toiletToolStripMenuItem.Text = "Toilets";
            this.toiletToolStripMenuItem.Click += new System.EventHandler(this.toiletToolStripMenuItem_Click);
            // 
            // waterSourceToolStripMenuItem
            // 
            this.waterSourceToolStripMenuItem.Name = "waterSourceToolStripMenuItem";
            this.waterSourceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.waterSourceToolStripMenuItem.Text = "Water Sources";
            this.waterSourceToolStripMenuItem.Click += new System.EventHandler(this.waterSourceToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // nationalitiesToolStripMenuItem
            // 
            this.nationalitiesToolStripMenuItem.Name = "nationalitiesToolStripMenuItem";
            this.nationalitiesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nationalitiesToolStripMenuItem.Text = "Nationalities";
            this.nationalitiesToolStripMenuItem.Click += new System.EventHandler(this.nationalitiesToolStripMenuItem_Click);
            // 
            // religionsToolStripMenuItem
            // 
            this.religionsToolStripMenuItem.Name = "religionsToolStripMenuItem";
            this.religionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.religionsToolStripMenuItem.Text = "Religions";
            this.religionsToolStripMenuItem.Click += new System.EventHandler(this.religionsToolStripMenuItem_Click);
            // 
            // petToolStripMenuItem
            // 
            this.petToolStripMenuItem.Name = "petToolStripMenuItem";
            this.petToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.petToolStripMenuItem.Text = "Pets";
            this.petToolStripMenuItem.Click += new System.EventHandler(this.petToolStripMenuItem_Click);
            // 
            // toolStripSplitButtonAccessControl
            // 
            this.toolStripSplitButtonAccessControl.DropDownButtonWidth = 15;
            this.toolStripSplitButtonAccessControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolesToolStripMenuItem,
            this.toolStripMenuSetupControl,
            this.accessLevelsToolStripMenuItem});
            this.toolStripSplitButtonAccessControl.Image = global::BarangayInformation.Properties.Resources.Control_Panel_icon64x64;
            this.toolStripSplitButtonAccessControl.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSplitButtonAccessControl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonAccessControl.Name = "toolStripSplitButtonAccessControl";
            this.toolStripSplitButtonAccessControl.Size = new System.Drawing.Size(126, 83);
            this.toolStripSplitButtonAccessControl.Text = "ACCESS CONTROL";
            this.toolStripSplitButtonAccessControl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.rolesToolStripMenuItem.Text = "Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click_1);
            // 
            // toolStripMenuSetupControl
            // 
            this.toolStripMenuSetupControl.Name = "toolStripMenuSetupControl";
            this.toolStripMenuSetupControl.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuSetupControl.Text = "Controls";
            this.toolStripMenuSetupControl.Click += new System.EventHandler(this.toolStripMenuSetupControl_Click);
            // 
            // accessLevelsToolStripMenuItem
            // 
            this.accessLevelsToolStripMenuItem.Name = "accessLevelsToolStripMenuItem";
            this.accessLevelsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.accessLevelsToolStripMenuItem.Text = "Access Levels";
            this.accessLevelsToolStripMenuItem.Click += new System.EventHandler(this.accessLevelsToolStripMenuItem_Click);
            // 
            // toolStripSplitButtonAddress
            // 
            this.toolStripSplitButtonAddress.DropDownButtonWidth = 15;
            this.toolStripSplitButtonAddress.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countriesStripMenuItem,
            this.provinceStripMenuItem,
            this.citiesToolStripMenuItem,
            this.barangaysToolStripMenuItem});
            this.toolStripSplitButtonAddress.Image = global::BarangayInformation.Properties.Resources.map64x64;
            this.toolStripSplitButtonAddress.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSplitButtonAddress.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonAddress.Name = "toolStripSplitButtonAddress";
            this.toolStripSplitButtonAddress.Size = new System.Drawing.Size(84, 83);
            this.toolStripSplitButtonAddress.Text = "ADDRESS";
            this.toolStripSplitButtonAddress.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // countriesStripMenuItem
            // 
            this.countriesStripMenuItem.Name = "countriesStripMenuItem";
            this.countriesStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.countriesStripMenuItem.Text = "Countries";
            this.countriesStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // provinceStripMenuItem
            // 
            this.provinceStripMenuItem.Name = "provinceStripMenuItem";
            this.provinceStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.provinceStripMenuItem.Text = "Provinces";
            // 
            // citiesToolStripMenuItem
            // 
            this.citiesToolStripMenuItem.Name = "citiesToolStripMenuItem";
            this.citiesToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.citiesToolStripMenuItem.Text = "Cities";
            // 
            // barangaysToolStripMenuItem
            // 
            this.barangaysToolStripMenuItem.Name = "barangaysToolStripMenuItem";
            this.barangaysToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.barangaysToolStripMenuItem.Text = "Barangays";
            this.barangaysToolStripMenuItem.Click += new System.EventHandler(this.barangaysToolStripMenuItem_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripLabelUser,
            this.toolStripSeparator4,
            this.toolStripLabel3,
            this.toolStripLabelRole,
            this.toolStripSeparator5,
            this.toolStripLabel1,
            this.toolStripLabelSystemTime});
            this.toolStrip2.Location = new System.Drawing.Point(0, 594);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1115, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel2.Text = "USER: ";
            // 
            // toolStripLabelUser
            // 
            this.toolStripLabelUser.Name = "toolStripLabelUser";
            this.toolStripLabelUser.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabelUser.Text = "USER:";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel3.Text = "ROLE: ";
            // 
            // toolStripLabelRole
            // 
            this.toolStripLabelRole.Name = "toolStripLabelRole";
            this.toolStripLabelRole.Size = new System.Drawing.Size(30, 22);
            this.toolStripLabelRole.Text = "Role";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(96, 22);
            this.toolStripLabel1.Text = "DATE AND TIME";
            // 
            // toolStripLabelSystemTime
            // 
            this.toolStripLabelSystemTime.Name = "toolStripLabelSystemTime";
            this.toolStripLabelSystemTime.Size = new System.Drawing.Size(78, 22);
            this.toolStripLabelSystemTime.Text = "SYSTEM TIME";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 619);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainform_FormClosing);
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonResident;
        private System.Windows.Forms.ToolStripButton toolStripButtonLogout;
        private System.Windows.Forms.ToolStripSplitButton toolStripSetting;
        private System.Windows.Forms.ToolStripMenuItem waterSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toiletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nationalitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem religionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonAddress;
        private System.Windows.Forms.ToolStripMenuItem countriesStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provinceStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barangaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gardenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem petToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonUser;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabelUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabelRole;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonAccessControl;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSetupControl;
        private System.Windows.Forms.ToolStripLabel toolStripLabelSystemTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripMenuItem accessLevelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contraceptiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

