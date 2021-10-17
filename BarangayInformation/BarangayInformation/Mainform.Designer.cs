
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
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSetting = new System.Windows.Forms.ToolStripSplitButton();
            this.waterSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toiletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nationalitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.religionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gardenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.petToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuSetupControl = new System.Windows.Forms.ToolStripMenuItem();
            this.accessLevelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripButton4,
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripSetting,
            this.toolStripSplitButton2,
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(2, 5, 5, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1102, 91);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::BarangayInformation.Properties.Resources.Admin_icon64x64;
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(68, 83);
            this.toolStripButton4.Text = "User";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::BarangayInformation.Properties.Resources.people64x64;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(68, 83);
            this.toolStripButton1.Text = "Resident";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(68, 83);
            this.toolStripButton3.Text = "LOGOUT";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSetting
            // 
            this.toolStripSetting.DropDownButtonWidth = 15;
            this.toolStripSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.waterSourceToolStripMenuItem,
            this.toiletToolStripMenuItem,
            this.toolStripSeparator1,
            this.nationalitiesToolStripMenuItem,
            this.religionsToolStripMenuItem,
            this.toolStripSeparator2,
            this.gardenToolStripMenuItem,
            this.toolStripSeparator3,
            this.petToolStripMenuItem});
            this.toolStripSetting.Image = global::BarangayInformation.Properties.Resources.setting64x64;
            this.toolStripSetting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSetting.Name = "toolStripSetting";
            this.toolStripSetting.Size = new System.Drawing.Size(84, 83);
            this.toolStripSetting.Text = "SETUP";
            this.toolStripSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripSetting.ButtonClick += new System.EventHandler(this.toolStripSetting_ButtonClick);
            // 
            // waterSourceToolStripMenuItem
            // 
            this.waterSourceToolStripMenuItem.Name = "waterSourceToolStripMenuItem";
            this.waterSourceToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.waterSourceToolStripMenuItem.Text = "Water Source";
            this.waterSourceToolStripMenuItem.Click += new System.EventHandler(this.waterSourceToolStripMenuItem_Click);
            // 
            // toiletToolStripMenuItem
            // 
            this.toiletToolStripMenuItem.Name = "toiletToolStripMenuItem";
            this.toiletToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.toiletToolStripMenuItem.Text = "Toilet";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // nationalitiesToolStripMenuItem
            // 
            this.nationalitiesToolStripMenuItem.Name = "nationalitiesToolStripMenuItem";
            this.nationalitiesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.nationalitiesToolStripMenuItem.Text = "Nationalities";
            this.nationalitiesToolStripMenuItem.Click += new System.EventHandler(this.nationalitiesToolStripMenuItem_Click);
            // 
            // religionsToolStripMenuItem
            // 
            this.religionsToolStripMenuItem.Name = "religionsToolStripMenuItem";
            this.religionsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.religionsToolStripMenuItem.Text = "Religions";
            this.religionsToolStripMenuItem.Click += new System.EventHandler(this.religionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(141, 6);
            // 
            // gardenToolStripMenuItem
            // 
            this.gardenToolStripMenuItem.Name = "gardenToolStripMenuItem";
            this.gardenToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.gardenToolStripMenuItem.Text = "Garden";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // petToolStripMenuItem
            // 
            this.petToolStripMenuItem.Name = "petToolStripMenuItem";
            this.petToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.petToolStripMenuItem.Text = "Pet";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DropDownButtonWidth = 15;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolesToolStripMenuItem,
            this.toolStripMenuSetupControl,
            this.accessLevelsToolStripMenuItem});
            this.toolStripSplitButton2.Image = global::BarangayInformation.Properties.Resources.Control_Panel_icon64x64;
            this.toolStripSplitButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(126, 83);
            this.toolStripSplitButton2.Text = "ACCESS CONTROL";
            this.toolStripSplitButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuSetupControl
            // 
            this.toolStripMenuSetupControl.Name = "toolStripMenuSetupControl";
            this.toolStripMenuSetupControl.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuSetupControl.Text = "Controls";
            this.toolStripMenuSetupControl.Click += new System.EventHandler(this.toolStripMenuSetupControl_Click);
            // 
            // accessLevelsToolStripMenuItem
            // 
            this.accessLevelsToolStripMenuItem.Name = "accessLevelsToolStripMenuItem";
            this.accessLevelsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.accessLevelsToolStripMenuItem.Text = "Access Levels";
            this.accessLevelsToolStripMenuItem.Click += new System.EventHandler(this.accessLevelsToolStripMenuItem_Click);
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rolesToolStripMenuItem.Text = "Roles";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownButtonWidth = 15;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.citiesToolStripMenuItem,
            this.barangaysToolStripMenuItem});
            this.toolStripSplitButton1.Image = global::BarangayInformation.Properties.Resources.map64x64;
            this.toolStripSplitButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(84, 83);
            this.toolStripSplitButton1.Text = "ADDRESS";
            this.toolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItem1.Text = "Countries";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItem2.Text = "Provinces";
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
            this.toolStrip2.Location = new System.Drawing.Point(0, 643);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1102, 25);
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
            this.ClientSize = new System.Drawing.Size(1102, 668);
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
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSplitButton toolStripSetting;
        private System.Windows.Forms.ToolStripMenuItem waterSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toiletToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem nationalitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem religionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem citiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barangaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem gardenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem petToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabelUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabelRole;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSetupControl;
        private System.Windows.Forms.ToolStripLabel toolStripLabelSystemTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripMenuItem accessLevelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
    }
}

