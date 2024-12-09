namespace ClientAppointment
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
            this.TxtBxName = new System.Windows.Forms.TextBox();
            this.TxtBxContactNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CBTime = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RTBNotes = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RBYes = new System.Windows.Forms.RadioButton();
            this.RBNo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // TxtBxName
            // 
            this.TxtBxName.Location = new System.Drawing.Point(59, 93);
            this.TxtBxName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtBxName.Name = "TxtBxName";
            this.TxtBxName.Size = new System.Drawing.Size(517, 26);
            this.TxtBxName.TabIndex = 0;
            // 
            // TxtBxContactNumber
            // 
            this.TxtBxContactNumber.Location = new System.Drawing.Point(59, 154);
            this.TxtBxContactNumber.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtBxContactNumber.Name = "TxtBxContactNumber";
            this.TxtBxContactNumber.Size = new System.Drawing.Size(517, 26);
            this.TxtBxContactNumber.TabIndex = 3;
            this.TxtBxContactNumber.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contact number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Appointment Schedule:";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(498, 533);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(78, 41);
            this.submitBtn.TabIndex = 8;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(135, 228);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(441, 26);
            this.dateTimePicker.TabIndex = 9;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // CBTime
            // 
            this.CBTime.FormattingEnabled = true;
            this.CBTime.Location = new System.Drawing.Point(135, 268);
            this.CBTime.Name = "CBTime";
            this.CBTime.Size = new System.Drawing.Size(441, 26);
            this.CBTime.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Date:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Time:";
            // 
            // RTBNotes
            // 
            this.RTBNotes.Location = new System.Drawing.Point(59, 329);
            this.RTBNotes.Name = "RTBNotes";
            this.RTBNotes.Size = new System.Drawing.Size(517, 144);
            this.RTBNotes.TabIndex = 15;
            this.RTBNotes.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 308);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Notes:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(395, 36);
            this.label6.TabIndex = 17;
            this.label6.Text = "Appoint Schedule Now";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 476);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(578, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Would you agree to reschedule the appointment, if needed?";
            // 
            // RBYes
            // 
            this.RBYes.AutoSize = true;
            this.RBYes.Location = new System.Drawing.Point(105, 507);
            this.RBYes.Name = "RBYes";
            this.RBYes.Size = new System.Drawing.Size(56, 22);
            this.RBYes.TabIndex = 19;
            this.RBYes.TabStop = true;
            this.RBYes.Text = "Yes";
            this.RBYes.UseVisualStyleBackColor = true;
            // 
            // RBNo
            // 
            this.RBNo.AutoSize = true;
            this.RBNo.Location = new System.Drawing.Point(241, 507);
            this.RBNo.Name = "RBNo";
            this.RBNo.Size = new System.Drawing.Size(46, 22);
            this.RBNo.TabIndex = 20;
            this.RBNo.TabStop = true;
            this.RBNo.Text = "No";
            this.RBNo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 578);
            this.Controls.Add(this.RBNo);
            this.Controls.Add(this.RBYes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RTBNotes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBTime);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBxContactNumber);
            this.Controls.Add(this.TxtBxName);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Appoint Schedule";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBxName;
        private System.Windows.Forms.TextBox TxtBxContactNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox CBTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox RTBNotes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton RBYes;
        private System.Windows.Forms.RadioButton RBNo;
    }
}

