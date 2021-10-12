
namespace BarangayInformation
{
    partial class ResidentMainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridResidents = new System.Windows.Forms.DataGridView();
            this.resident_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_head = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middle_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.civilstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voterstatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.employmentstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.rbResidentNumber = new System.Windows.Forms.RadioButton();
            this.rbFirstName = new System.Windows.Forms.RadioButton();
            this.rbLastName = new System.Windows.Forms.RadioButton();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridResidents)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridResidents
            // 
            this.gridResidents.AllowUserToAddRows = false;
            this.gridResidents.AllowUserToDeleteRows = false;
            this.gridResidents.AllowUserToResizeColumns = false;
            this.gridResidents.AllowUserToResizeRows = false;
            this.gridResidents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridResidents.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridResidents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridResidents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridResidents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(132)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(191)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridResidents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridResidents.ColumnHeadersHeight = 40;
            this.gridResidents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.resident_id,
            this.is_head,
            this.first_name,
            this.middle_name,
            this.last_name,
            this.sex,
            this.civilstatus,
            this.voterstatus,
            this.employmentstatus});
            this.gridResidents.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(191)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridResidents.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridResidents.EnableHeadersVisualStyles = false;
            this.gridResidents.Location = new System.Drawing.Point(12, 66);
            this.gridResidents.Name = "gridResidents";
            this.gridResidents.ReadOnly = true;
            this.gridResidents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridResidents.RowHeadersVisible = false;
            this.gridResidents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridResidents.ShowEditingIcon = false;
            this.gridResidents.Size = new System.Drawing.Size(980, 476);
            this.gridResidents.TabIndex = 2;
            // 
            // resident_id
            // 
            this.resident_id.DataPropertyName = "resident_id";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.resident_id.DefaultCellStyle = dataGridViewCellStyle5;
            this.resident_id.HeaderText = "Resident No.";
            this.resident_id.Name = "resident_id";
            this.resident_id.ReadOnly = true;
            this.resident_id.Width = 80;
            // 
            // is_head
            // 
            this.is_head.DataPropertyName = "is_head";
            this.is_head.HeaderText = "Is Head";
            this.is_head.Name = "is_head";
            this.is_head.ReadOnly = true;
            // 
            // first_name
            // 
            this.first_name.DataPropertyName = "fname";
            this.first_name.HeaderText = "First Name";
            this.first_name.Name = "first_name";
            this.first_name.ReadOnly = true;
            this.first_name.Width = 150;
            // 
            // middle_name
            // 
            this.middle_name.DataPropertyName = "mname";
            this.middle_name.HeaderText = "Middle Name";
            this.middle_name.Name = "middle_name";
            this.middle_name.ReadOnly = true;
            this.middle_name.Width = 130;
            // 
            // last_name
            // 
            this.last_name.DataPropertyName = "lname";
            this.last_name.HeaderText = "Last Name";
            this.last_name.Name = "last_name";
            this.last_name.ReadOnly = true;
            this.last_name.Width = 150;
            // 
            // sex
            // 
            this.sex.DataPropertyName = "sex";
            this.sex.HeaderText = "Sex";
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            this.sex.Width = 90;
            // 
            // civilstatus
            // 
            this.civilstatus.DataPropertyName = "civil_status";
            this.civilstatus.HeaderText = "Civil Status";
            this.civilstatus.Name = "civilstatus";
            this.civilstatus.ReadOnly = true;
            // 
            // voterstatus
            // 
            this.voterstatus.DataPropertyName = "is_voter";
            this.voterstatus.HeaderText = "Voter";
            this.voterstatus.Name = "voterstatus";
            this.voterstatus.ReadOnly = true;
            this.voterstatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.voterstatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.voterstatus.Width = 90;
            // 
            // employmentstatus
            // 
            this.employmentstatus.DataPropertyName = "year_residence";
            this.employmentstatus.HeaderText = "Years Residing";
            this.employmentstatus.Name = "employmentstatus";
            this.employmentstatus.ReadOnly = true;
            this.employmentstatus.Width = 90;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.rbResidentNumber);
            this.GroupBox1.Controls.Add(this.rbFirstName);
            this.GroupBox1.Controls.Add(this.rbLastName);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(95, 15);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(336, 45);
            this.GroupBox1.TabIndex = 65;
            this.GroupBox1.TabStop = false;
            // 
            // rbResidentNumber
            // 
            this.rbResidentNumber.AutoSize = true;
            this.rbResidentNumber.Location = new System.Drawing.Point(13, 13);
            this.rbResidentNumber.Name = "rbResidentNumber";
            this.rbResidentNumber.Size = new System.Drawing.Size(122, 19);
            this.rbResidentNumber.TabIndex = 62;
            this.rbResidentNumber.TabStop = true;
            this.rbResidentNumber.Text = "Resident Number";
            this.rbResidentNumber.UseVisualStyleBackColor = true;
            // 
            // rbFirstName
            // 
            this.rbFirstName.AutoSize = true;
            this.rbFirstName.Location = new System.Drawing.Point(141, 14);
            this.rbFirstName.Name = "rbFirstName";
            this.rbFirstName.Size = new System.Drawing.Size(80, 19);
            this.rbFirstName.TabIndex = 59;
            this.rbFirstName.TabStop = true;
            this.rbFirstName.Text = "Firstname";
            this.rbFirstName.UseVisualStyleBackColor = true;
            // 
            // rbLastName
            // 
            this.rbLastName.AutoSize = true;
            this.rbLastName.Location = new System.Drawing.Point(238, 15);
            this.rbLastName.Name = "rbLastName";
            this.rbLastName.Size = new System.Drawing.Size(80, 19);
            this.rbLastName.TabIndex = 60;
            this.rbLastName.TabStop = true;
            this.rbLastName.Text = "Lastname";
            this.rbLastName.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(20, 31);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(69, 16);
            this.Label1.TabIndex = 63;
            this.Label1.Text = "Search by";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Info;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(437, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(546, 38);
            this.txtSearch.TabIndex = 64;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 120);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // ResidentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 620);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gridResidents);
            this.Name = "ResidentMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResidentMainForm";
            this.Load += new System.EventHandler(this.ResidentMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridResidents)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView gridResidents;
        internal System.Windows.Forms.DataGridViewTextBoxColumn resident_id;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn is_head;
        internal System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        internal System.Windows.Forms.DataGridViewTextBoxColumn middle_name;
        internal System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        internal System.Windows.Forms.DataGridViewTextBoxColumn sex;
        internal System.Windows.Forms.DataGridViewTextBoxColumn civilstatus;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn voterstatus;
        internal System.Windows.Forms.DataGridViewTextBoxColumn employmentstatus;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RadioButton rbResidentNumber;
        internal System.Windows.Forms.RadioButton rbFirstName;
        internal System.Windows.Forms.RadioButton rbLastName;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}