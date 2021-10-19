
namespace BarangayInformation
{
    partial class RoleAddEditForm
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
            this.textBoxrole = new System.Windows.Forms.TextBox();
            this.labelwatersource = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonwatersave
            // 
            this.buttonwatersave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonwatersave.Location = new System.Drawing.Point(74, 69);
            this.buttonwatersave.Name = "buttonwatersave";
            this.buttonwatersave.Size = new System.Drawing.Size(84, 33);
            this.buttonwatersave.TabIndex = 5;
            this.buttonwatersave.Text = "Save";
            this.buttonwatersave.UseVisualStyleBackColor = true;
            this.buttonwatersave.Click += new System.EventHandler(this.buttonwatersave_Click);
            // 
            // textBoxrole
            // 
            this.textBoxrole.Location = new System.Drawing.Point(74, 43);
            this.textBoxrole.Name = "textBoxrole";
            this.textBoxrole.Size = new System.Drawing.Size(197, 20);
            this.textBoxrole.TabIndex = 4;
            // 
            // labelwatersource
            // 
            this.labelwatersource.AutoSize = true;
            this.labelwatersource.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelwatersource.ForeColor = System.Drawing.Color.White;
            this.labelwatersource.Location = new System.Drawing.Point(27, 41);
            this.labelwatersource.Name = "labelwatersource";
            this.labelwatersource.Size = new System.Drawing.Size(44, 20);
            this.labelwatersource.TabIndex = 3;
            this.labelwatersource.Text = "Role:";
            // 
            // RoleAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(308, 121);
            this.Controls.Add(this.buttonwatersave);
            this.Controls.Add(this.textBoxrole);
            this.Controls.Add(this.labelwatersource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RoleAddEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoleAddEditForm";
            this.Load += new System.EventHandler(this.RoleAddEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonwatersave;
        private System.Windows.Forms.TextBox textBoxrole;
        private System.Windows.Forms.Label labelwatersource;
    }
}