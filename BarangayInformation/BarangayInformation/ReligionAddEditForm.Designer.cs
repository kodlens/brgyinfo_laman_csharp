
namespace BarangayInformation
{
    partial class ReligionAddEditForm
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
            this.buttonwatersave = new System.Windows.Forms.Button();
            this.textreligion = new System.Windows.Forms.TextBox();
            this.labelwatersource = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonwatersave
            // 
            this.buttonwatersave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonwatersave.Location = new System.Drawing.Point(97, 55);
            this.buttonwatersave.Name = "buttonwatersave";
            this.buttonwatersave.Size = new System.Drawing.Size(84, 33);
            this.buttonwatersave.TabIndex = 5;
            this.buttonwatersave.Text = "Save";
            this.buttonwatersave.UseVisualStyleBackColor = true;
            this.buttonwatersave.Click += new System.EventHandler(this.buttonwatersave_Click);
            // 
            // textreligion
            // 
            this.textreligion.Location = new System.Drawing.Point(97, 29);
            this.textreligion.Name = "textreligion";
            this.textreligion.Size = new System.Drawing.Size(197, 20);
            this.textreligion.TabIndex = 4;
            // 
            // labelwatersource
            // 
            this.labelwatersource.AutoSize = true;
            this.labelwatersource.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelwatersource.ForeColor = System.Drawing.Color.White;
            this.labelwatersource.Location = new System.Drawing.Point(21, 26);
            this.labelwatersource.Name = "labelwatersource";
            this.labelwatersource.Size = new System.Drawing.Size(70, 20);
            this.labelwatersource.TabIndex = 3;
            this.labelwatersource.Text = "Religion:";
            // 
            // ReligionAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(318, 107);
            this.Controls.Add(this.buttonwatersave);
            this.Controls.Add(this.textreligion);
            this.Controls.Add(this.labelwatersource);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReligionAddEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReligionAddEditForm";
            this.Load += new System.EventHandler(this.ReligionAddEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonwatersave;
        private System.Windows.Forms.TextBox textreligion;
        private System.Windows.Forms.Label labelwatersource;
    }
}