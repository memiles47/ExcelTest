namespace DataSheetOne
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
            this.tab_Control = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_EmailAddress = new System.Windows.Forms.Label();
            this.lbl_WebAddress = new System.Windows.Forms.Label();
            this.tb_PhoneNumber = new System.Windows.Forms.TextBox();
            this.tb_EmailAddress = new System.Windows.Forms.TextBox();
            this.tab_Control.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_Control
            // 
            this.tab_Control.Controls.Add(this.tabPage1);
            this.tab_Control.Controls.Add(this.tabPage2);
            this.tab_Control.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Control.Location = new System.Drawing.Point(38, 51);
            this.tab_Control.Name = "tab_Control";
            this.tab_Control.SelectedIndex = 0;
            this.tab_Control.Size = new System.Drawing.Size(900, 500);
            this.tab_Control.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(892, 462);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employee Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tb_EmailAddress);
            this.tabPage2.Controls.Add(this.tb_PhoneNumber);
            this.tabPage2.Controls.Add(this.lbl_WebAddress);
            this.tabPage2.Controls.Add(this.lbl_EmailAddress);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(892, 462);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Misc Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_EmailAddress
            // 
            this.lbl_EmailAddress.AutoSize = true;
            this.lbl_EmailAddress.Location = new System.Drawing.Point(154, 158);
            this.lbl_EmailAddress.Name = "lbl_EmailAddress";
            this.lbl_EmailAddress.Size = new System.Drawing.Size(138, 25);
            this.lbl_EmailAddress.TabIndex = 0;
            this.lbl_EmailAddress.Text = "Email Address";
            // 
            // lbl_WebAddress
            // 
            this.lbl_WebAddress.AutoSize = true;
            this.lbl_WebAddress.Location = new System.Drawing.Point(154, 237);
            this.lbl_WebAddress.Name = "lbl_WebAddress";
            this.lbl_WebAddress.Size = new System.Drawing.Size(132, 25);
            this.lbl_WebAddress.TabIndex = 1;
            this.lbl_WebAddress.Text = "Web Address";
            // 
            // tb_PhoneNumber
            // 
            this.tb_PhoneNumber.Location = new System.Drawing.Point(298, 232);
            this.tb_PhoneNumber.Name = "tb_PhoneNumber";
            this.tb_PhoneNumber.Size = new System.Drawing.Size(386, 30);
            this.tb_PhoneNumber.TabIndex = 2;
            // 
            // tb_EmailAddress
            // 
            this.tb_EmailAddress.Location = new System.Drawing.Point(298, 153);
            this.tb_EmailAddress.Name = "tb_EmailAddress";
            this.tb_EmailAddress.Size = new System.Drawing.Size(386, 30);
            this.tb_EmailAddress.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 600);
            this.Controls.Add(this.tab_Control);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tab_Control.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Control;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_EmailAddress;
        private System.Windows.Forms.TextBox tb_PhoneNumber;
        private System.Windows.Forms.Label lbl_WebAddress;
        private System.Windows.Forms.Label lbl_EmailAddress;
    }
}