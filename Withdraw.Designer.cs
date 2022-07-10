
namespace ATM_Management_System
{
    partial class Withdraw
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
            this.back_label = new System.Windows.Forms.Label();
            this.Withdraw_Button = new System.Windows.Forms.Button();
            this.acc_Num_Txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AvailableBalanceLBL = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // back_label
            // 
            this.back_label.AutoSize = true;
            this.back_label.Font = new System.Drawing.Font("Footlight MT Light", 14F);
            this.back_label.Location = new System.Drawing.Point(368, 452);
            this.back_label.Name = "back_label";
            this.back_label.Size = new System.Drawing.Size(68, 30);
            this.back_label.TabIndex = 46;
            this.back_label.Text = "Back";
            this.back_label.Click += new System.EventHandler(this.back_label_Click);
            // 
            // Withdraw_Button
            // 
            this.Withdraw_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Withdraw_Button.Font = new System.Drawing.Font("Footlight MT Light", 14F);
            this.Withdraw_Button.Location = new System.Drawing.Point(329, 378);
            this.Withdraw_Button.Name = "Withdraw_Button";
            this.Withdraw_Button.Size = new System.Drawing.Size(155, 52);
            this.Withdraw_Button.TabIndex = 45;
            this.Withdraw_Button.Text = "Withdraw";
            this.Withdraw_Button.UseVisualStyleBackColor = true;
            this.Withdraw_Button.Click += new System.EventHandler(this.Withdraw_Button_Click);
            // 
            // acc_Num_Txtbox
            // 
            this.acc_Num_Txtbox.Location = new System.Drawing.Point(373, 279);
            this.acc_Num_Txtbox.Multiline = true;
            this.acc_Num_Txtbox.Name = "acc_Num_Txtbox";
            this.acc_Num_Txtbox.Size = new System.Drawing.Size(304, 35);
            this.acc_Num_Txtbox.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Footlight MT Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 30);
            this.label3.TabIndex = 43;
            this.label3.Text = "Amount :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bradley Hand ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 60);
            this.label2.TabIndex = 42;
            this.label2.Text = "Withdraw";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 101);
            this.panel1.TabIndex = 41;
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
            this.label5.Location = new System.Drawing.Point(824, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 29);
            this.label5.TabIndex = 47;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // AvailableBalanceLBL
            // 
            this.AvailableBalanceLBL.AutoSize = true;
            this.AvailableBalanceLBL.Font = new System.Drawing.Font("Footlight MT Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableBalanceLBL.Location = new System.Drawing.Point(132, 222);
            this.AvailableBalanceLBL.Name = "AvailableBalanceLBL";
            this.AvailableBalanceLBL.Size = new System.Drawing.Size(229, 30);
            this.AvailableBalanceLBL.TabIndex = 48;
            this.AvailableBalanceLBL.Text = "Available Balance :";
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(857, 518);
            this.Controls.Add(this.AvailableBalanceLBL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.back_label);
            this.Controls.Add(this.Withdraw_Button);
            this.Controls.Add(this.acc_Num_Txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Withdraw";
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label back_label;
        private System.Windows.Forms.Button Withdraw_Button;
        private System.Windows.Forms.TextBox acc_Num_Txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label AvailableBalanceLBL;
    }
}