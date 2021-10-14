
namespace BarangayInformation
{
    partial class WaterSourceAddEditForm
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
            this.labelwatersource = new System.Windows.Forms.Label();
            this.textBoxwatersource = new System.Windows.Forms.TextBox();
            this.buttonwatersave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelwatersource
            // 
            this.labelwatersource.AutoSize = true;
            this.labelwatersource.Location = new System.Drawing.Point(29, 47);
            this.labelwatersource.Name = "labelwatersource";
            this.labelwatersource.Size = new System.Drawing.Size(76, 13);
            this.labelwatersource.TabIndex = 0;
            this.labelwatersource.Text = "Water Source:";
            // 
            // textBoxwatersource
            // 
            this.textBoxwatersource.Location = new System.Drawing.Point(108, 44);
            this.textBoxwatersource.Name = "textBoxwatersource";
            this.textBoxwatersource.Size = new System.Drawing.Size(197, 20);
            this.textBoxwatersource.TabIndex = 1;
            // 
            // buttonwatersave
            // 
            this.buttonwatersave.Location = new System.Drawing.Point(108, 70);
            this.buttonwatersave.Name = "buttonwatersave";
            this.buttonwatersave.Size = new System.Drawing.Size(84, 33);
            this.buttonwatersave.TabIndex = 2;
            this.buttonwatersave.Text = "Save";
            this.buttonwatersave.UseVisualStyleBackColor = true;
            this.buttonwatersave.Click += new System.EventHandler(this.buttonwatersave_Click);
            // 
            // WaterSourceAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 159);
            this.Controls.Add(this.buttonwatersave);
            this.Controls.Add(this.textBoxwatersource);
            this.Controls.Add(this.labelwatersource);
            this.Name = "WaterSourceAddEditForm";
            this.Text = "WaterSourceAddEditForm";
            this.Load += new System.EventHandler(this.WaterSourceAddEditForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelwatersource;
        private System.Windows.Forms.TextBox textBoxwatersource;
        private System.Windows.Forms.Button buttonwatersave;
    }
}