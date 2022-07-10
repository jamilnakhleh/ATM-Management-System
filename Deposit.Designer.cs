
namespace ATM_Management_System
{
    partial class Deposit
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
            this.label2 = new System.Windows.Forms.Label();
            this.acc_Num_Txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LogOut_Label = new System.Windows.Forms.Label();
            this.Deposit_Button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 101);
            this.panel1.TabIndex = 5;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bradley Hand ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 60);
            this.label2.TabIndex = 6;
            this.label2.Text = "Deposit";
            // 
            // acc_Num_Txtbox
            // 
            this.acc_Num_Txtbox.Location = new System.Drawing.Point(333, 224);
            this.acc_Num_Txtbox.Multiline = true;
            this.acc_Num_Txtbox.Name = "acc_Num_Txtbox";
            this.acc_Num_Txtbox.Size = new System.Drawing.Size(304, 35);
            this.acc_Num_Txtbox.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Footlight MT Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 30);
            this.label3.TabIndex = 27;
            this.label3.Text = "Amount :";
            // 
            // LogOut_Label
            // 
            this.LogOut_Label.AutoSize = true;
            this.LogOut_Label.Font = new System.Drawing.Font("Footlight MT Light", 14F);
            this.LogOut_Label.Location = new System.Drawing.Point(375, 417);
            this.LogOut_Label.Name = "LogOut_Label";
            this.LogOut_Label.Size = new System.Drawing.Size(68, 30);
            this.LogOut_Label.TabIndex = 40;
            this.LogOut_Label.Text = "Back";
            this.LogOut_Label.Click += new System.EventHandler(this.LogOut_Label_Click);
            // 
            // Deposit_Button
            // 
            this.Deposit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deposit_Button.Font = new System.Drawing.Font("Footlight MT Light", 14F);
            this.Deposit_Button.Location = new System.Drawing.Point(333, 334);
            this.Deposit_Button.Name = "Deposit_Button";
            this.Deposit_Button.Size = new System.Drawing.Size(155, 52);
            this.Deposit_Button.TabIndex = 39;
            this.Deposit_Button.Text = "Deposit";
            this.Deposit_Button.UseVisualStyleBackColor = true;
            this.Deposit_Button.Click += new System.EventHandler(this.Deposit_Button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(823, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 29);
            this.label5.TabIndex = 41;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(856, 500);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LogOut_Label);
            this.Controls.Add(this.Deposit_Button);
            this.Controls.Add(this.acc_Num_Txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox acc_Num_Txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LogOut_Label;
        private System.Windows.Forms.Button Deposit_Button;
        private System.Windows.Forms.Label label5;
    }
}