namespace WindowsFormsApp2
{
    partial class Form1
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
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblRoleSpecific = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtFaculty = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtRoleSpecific = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(43, 35);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(75, 23);
            this.btnChooseFile.TabIndex = 0;
            this.btnChooseFile.Text = "Choose file ...";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(31, 98);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(57, 13);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Full Name:";
            this.lblFullName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(31, 145);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(67, 13);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Year of birth:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(31, 189);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "City:";
            this.lblCity.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(31, 231);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(44, 13);
            this.lblFaculty.TabIndex = 4;
            this.lblFaculty.Text = "Faculty:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(31, 270);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(32, 13);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "Role:";
            // 
            // lblRoleSpecific
            // 
            this.lblRoleSpecific.AutoSize = true;
            this.lblRoleSpecific.Location = new System.Drawing.Point(31, 313);
            this.lblRoleSpecific.Name = "lblRoleSpecific";
            this.lblRoleSpecific.Size = new System.Drawing.Size(113, 13);
            this.lblRoleSpecific.TabIndex = 6;
            this.lblRoleSpecific.Text = "[role specific attribute]:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(145, 95);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(100, 20);
            this.txtFullName.TabIndex = 7;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(145, 142);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 8;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(145, 189);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 9;
            // 
            // txtFaculty
            // 
            this.txtFaculty.Location = new System.Drawing.Point(145, 228);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(100, 20);
            this.txtFaculty.TabIndex = 10;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(145, 267);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(100, 20);
            this.txtRole.TabIndex = 11;
            // 
            // txtRoleSpecific
            // 
            this.txtRoleSpecific.Location = new System.Drawing.Point(145, 310);
            this.txtRoleSpecific.Name = "txtRoleSpecific";
            this.txtRoleSpecific.Size = new System.Drawing.Size(100, 20);
            this.txtRoleSpecific.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRoleSpecific);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtFaculty);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblRoleSpecific);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblFaculty);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.btnChooseFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblRoleSpecific;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtFaculty;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtRoleSpecific;
    }
}

