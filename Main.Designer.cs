
namespace ATM_Management_System
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Deposit_Button = new System.Windows.Forms.Button();
            this.Withdraw_Button = new System.Windows.Forms.Button();
            this.MiniSta_Button = new System.Windows.Forms.Button();
            this.FastCash_Button = new System.Windows.Forms.Button();
            this.Balance_Button = new System.Windows.Forms.Button();
            this.ChangePIN_Button = new System.Windows.Forms.Button();
            this.LogOut_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(43, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 101);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bradley Hand ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select your transaction";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(836, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Deposit_Button
            // 
            this.Deposit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deposit_Button.Font = new System.Drawing.Font("Footlight MT Light", 12F);
            this.Deposit_Button.Location = new System.Drawing.Point(18, 252);
            this.Deposit_Button.Name = "Deposit_Button";
            this.Deposit_Button.Size = new System.Drawing.Size(239, 62);
            this.Deposit_Button.TabIndex = 9;
            this.Deposit_Button.Text = "Deposit";
            this.Deposit_Button.UseVisualStyleBackColor = true;
            this.Deposit_Button.Click += new System.EventHandler(this.Deposit_Button_Click);
            // 
            // Withdraw_Button
            // 
            this.Withdraw_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Withdraw_Button.Font = new System.Drawing.Font("Footlight MT Light", 12F);
            this.Withdraw_Button.Location = new System.Drawing.Point(607, 252);
            this.Withdraw_Button.Name = "Withdraw_Button";
            this.Withdraw_Button.Size = new System.Drawing.Size(239, 62);
            this.Withdraw_Button.TabIndex = 10;
            this.Withdraw_Button.Text = "Withdraw";
            this.Withdraw_Button.UseVisualStyleBackColor = true;
            this.Withdraw_Button.Click += new System.EventHandler(this.Withdraw_Button_Click);
            // 
            // MiniSta_Button
            // 
            this.MiniSta_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MiniSta_Button.Font = new System.Drawing.Font("Footlight MT Light", 12F);
            this.MiniSta_Button.Location = new System.Drawing.Point(607, 366);
            this.MiniSta_Button.Name = "MiniSta_Button";
            this.MiniSta_Button.Size = new System.Drawing.Size(239, 62);
            this.MiniSta_Button.TabIndex = 12;
            this.MiniSta_Button.Text = "Mini Statement";
            this.MiniSta_Button.UseVisualStyleBackColor = true;
            this.MiniSta_Button.Click += new System.EventHandler(this.MiniSta_Button_Click);
            // 
            // FastCash_Button
            // 
            this.FastCash_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FastCash_Button.Font = new System.Drawing.Font("Footlight MT Light", 12F);
            this.FastCash_Button.Location = new System.Drawing.Point(18, 366);
            this.FastCash_Button.Name = "FastCash_Button";
            this.FastCash_Button.Size = new System.Drawing.Size(239, 62);
            this.FastCash_Button.TabIndex = 11;
            this.FastCash_Button.Text = "Fast Cash";
            this.FastCash_Button.UseVisualStyleBackColor = true;
            this.FastCash_Button.Click += new System.EventHandler(this.FastCash_Button_Click);
            // 
            // Balance_Button
            // 
            this.Balance_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Balance_Button.Font = new System.Drawing.Font("Footlight MT Light", 12F);
            this.Balance_Button.Location = new System.Drawing.Point(607, 477);
            this.Balance_Button.Name = "Balance_Button";
            this.Balance_Button.Size = new System.Drawing.Size(239, 62);
            this.Balance_Button.TabIndex = 14;
            this.Balance_Button.Text = "Balance";
            this.Balance_Button.UseVisualStyleBackColor = true;
            this.Balance_Button.Click += new System.EventHandler(this.Balance_Button_Click);
            // 
            // ChangePIN_Button
            // 
            this.ChangePIN_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePIN_Button.Font = new System.Drawing.Font("Footlight MT Light", 12F);
            this.ChangePIN_Button.Location = new System.Drawing.Point(18, 477);
            this.ChangePIN_Button.Name = "ChangePIN_Button";
            this.ChangePIN_Button.Size = new System.Drawing.Size(239, 62);
            this.ChangePIN_Button.TabIndex = 13;
            this.ChangePIN_Button.Text = "Change PIN";
            this.ChangePIN_Button.UseVisualStyleBackColor = true;
            this.ChangePIN_Button.Click += new System.EventHandler(this.ChangePIN_Button_Click);
            // 
            // LogOut_Label
            // 
            this.LogOut_Label.AutoSize = true;
            this.LogOut_Label.Font = new System.Drawing.Font("Bradley Hand ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut_Label.Location = new System.Drawing.Point(340, 613);
            this.LogOut_Label.Name = "LogOut_Label";
            this.LogOut_Label.Size = new System.Drawing.Size(166, 60);
            this.LogOut_Label.TabIndex = 15;
            this.LogOut_Label.Text = "Logout";
            this.LogOut_Label.Click += new System.EventHandler(this.LogOut_Label_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bradley Hand ITC", 18F);
            this.label2.Location = new System.Drawing.Point(288, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 45);
            this.label2.TabIndex = 16;
            this.label2.Text = "Account Number";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(878, 687);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LogOut_Label);
            this.Controls.Add(this.Balance_Button);
            this.Controls.Add(this.ChangePIN_Button);
            this.Controls.Add(this.MiniSta_Button);
            this.Controls.Add(this.FastCash_Button);
            this.Controls.Add(this.Withdraw_Button);
            this.Controls.Add(this.Deposit_Button);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Deposit_Button;
        private System.Windows.Forms.Button Withdraw_Button;
        private System.Windows.Forms.Button MiniSta_Button;
        private System.Windows.Forms.Button FastCash_Button;
        private System.Windows.Forms.Button Balance_Button;
        private System.Windows.Forms.Button ChangePIN_Button;
        private System.Windows.Forms.Label LogOut_Label;
        private System.Windows.Forms.Label label2;
    }
}