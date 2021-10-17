
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
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
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.citiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barangaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripSetting,
            this.toolStripSplitButton1,
            this.toolStripSplitButton2,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(3, 6, 7, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1277, 92);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 83);
            this.toolStripButton2.Text = "ADMIN";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(32, 83);
            this.toolStripSplitButton2.Text = "toolStripSplitButton2";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 736);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainform_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem citiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barangaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem gardenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem petToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
    }
}

