
namespace ATM_Management_System
{
    partial class Balance
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
            this.Acc_Num_Lbl = new System.Windows.Forms.Label();
            this.Balance_Lbl = new System.Windows.Forms.Label();
            this.AccountNumber_Lbl = new System.Windows.Forms.Label();
            this.BalanceinRs_Lbl = new System.Windows.Forms.Label();
            this.LogOut_Label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(67, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 101);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bradley Hand ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "ATM Management System";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(892, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Acc_Num_Lbl
            // 
            this.Acc_Num_Lbl.AutoSize = true;
            this.Acc_Num_Lbl.Font = new System.Drawing.Font("Footlight MT Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acc_Num_Lbl.Location = new System.Drawing.Point(174, 214);
            this.Acc_Num_Lbl.Name = "Acc_Num_Lbl";
            this.Acc_Num_Lbl.Size = new System.Drawing.Size(222, 30);
            this.Acc_Num_Lbl.TabIndex = 12;
            this.Acc_Num_Lbl.Text = "Account Number :";
            // 
            // Balance_Lbl
            // 
            this.Balance_Lbl.AutoSize = true;
            this.Balance_Lbl.Font = new System.Drawing.Font("Footlight MT Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balance_Lbl.Location = new System.Drawing.Point(174, 334);
            this.Balance_Lbl.Name = "Balance_Lbl";
            this.Balance_Lbl.Size = new System.Drawing.Size(179, 30);
            this.Balance_Lbl.TabIndex = 13;
            this.Balance_Lbl.Text = "Your Balance :";
            // 
            // AccountNumber_Lbl
            // 
            this.AccountNumber_Lbl.AutoSize = true;
            this.AccountNumber_Lbl.Font = new System.Drawing.Font("Footlight MT Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNumber_Lbl.Location = new System.Drawing.Point(504, 214);
            this.AccountNumber_Lbl.Name = "AccountNumber_Lbl";
            this.AccountNumber_Lbl.Size = new System.Drawing.Size(208, 30);
            this.AccountNumber_Lbl.TabIndex = 14;
            this.AccountNumber_Lbl.Text = "Account Number";
            this.AccountNumber_Lbl.Click += new System.EventHandler(this.AccountNumber_Lbl_Click);
            // 
            // BalanceinRs_Lbl
            // 
            this.BalanceinRs_Lbl.AutoSize = true;
            this.BalanceinRs_Lbl.Font = new System.Drawing.Font("Footlight MT Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceinRs_Lbl.Location = new System.Drawing.Point(504, 334);
            this.BalanceinRs_Lbl.Name = "BalanceinRs_Lbl";
            this.BalanceinRs_Lbl.Size = new System.Drawing.Size(150, 30);
            this.BalanceinRs_Lbl.TabIndex = 15;
            this.BalanceinRs_Lbl.Text = "BalanceinRs";
            // 
            // LogOut_Label
            // 
            this.LogOut_Label.AutoSize = true;
            this.LogOut_Label.Font = new System.Drawing.Font("Bradley Hand ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut_Label.Location = new System.Drawing.Point(399, 431);
            this.LogOut_Label.Name = "LogOut_Label";
            this.LogOut_Label.Size = new System.Drawing.Size(130, 60);
            this.LogOut_Label.TabIndex = 16;
            this.LogOut_Label.Text = "Back";
            this.LogOut_Label.Click += new System.EventHandler(this.LogOut_Label_Click);
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(936, 529);
            this.Controls.Add(this.LogOut_Label);
            this.Controls.Add(this.BalanceinRs_Lbl);
            this.Controls.Add(this.AccountNumber_Lbl);
            this.Controls.Add(this.Balance_Lbl);
            this.Controls.Add(this.Acc_Num_Lbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Balance";
            this.Text = "Balance";
            this.Load += new System.EventHandler(this.Balance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Acc_Num_Lbl;
        private System.Windows.Forms.Label Balance_Lbl;
        private System.Windows.Forms.Label AccountNumber_Lbl;
        private System.Windows.Forms.Label BalanceinRs_Lbl;
        private System.Windows.Forms.Label LogOut_Label;
    }
}