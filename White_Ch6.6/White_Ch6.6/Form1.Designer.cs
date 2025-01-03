namespace White_Ch6._6
{
    partial class Hospital_Expenses
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
            this.Title = new System.Windows.Forms.Label();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.MedInput = new System.Windows.Forms.TextBox();
            this.SurgInput = new System.Windows.Forms.TextBox();
            this.LabInput = new System.Windows.Forms.TextBox();
            this.RehabInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.StayLbl = new System.Windows.Forms.Label();
            this.OtherLbl = new System.Windows.Forms.Label();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.DayInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(278, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(207, 24);
            this.Title.TabIndex = 1;
            this.Title.Text = "Hosptial Stay Expenses";
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(187, 289);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(75, 36);
            this.CalcBtn.TabIndex = 3;
            this.CalcBtn.Text = "Calculate Expenses";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(674, 289);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 36);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MedInput
            // 
            this.MedInput.Location = new System.Drawing.Point(187, 93);
            this.MedInput.Name = "MedInput";
            this.MedInput.Size = new System.Drawing.Size(95, 20);
            this.MedInput.TabIndex = 5;
            this.MedInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MedInput_KeyPress);
            // 
            // SurgInput
            // 
            this.SurgInput.Location = new System.Drawing.Point(187, 135);
            this.SurgInput.Name = "SurgInput";
            this.SurgInput.Size = new System.Drawing.Size(95, 20);
            this.SurgInput.TabIndex = 6;
            this.SurgInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurgInput_KeyPress);
            // 
            // LabInput
            // 
            this.LabInput.Location = new System.Drawing.Point(187, 190);
            this.LabInput.Name = "LabInput";
            this.LabInput.Size = new System.Drawing.Size(95, 20);
            this.LabInput.TabIndex = 7;
            this.LabInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LabInput_KeyPress);
            // 
            // RehabInput
            // 
            this.RehabInput.Location = new System.Drawing.Point(187, 231);
            this.RehabInput.Name = "RehabInput";
            this.RehabInput.Size = new System.Drawing.Size(95, 20);
            this.RehabInput.TabIndex = 8;
            this.RehabInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RehabInput_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter Days Stayed in Hospital: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Surgical Charge Amount: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Medication Charge Amount: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Lab Fee Amount: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Physical Rehabilitation Charges: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(461, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Miscellaneous Charfes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(486, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Stay Total:  ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(486, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Total Charges: ";
            // 
            // StayLbl
            // 
            this.StayLbl.AutoSize = true;
            this.StayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StayLbl.Location = new System.Drawing.Point(623, 72);
            this.StayLbl.Name = "StayLbl";
            this.StayLbl.Size = new System.Drawing.Size(44, 16);
            this.StayLbl.TabIndex = 17;
            this.StayLbl.Text = "label9";
            // 
            // OtherLbl
            // 
            this.OtherLbl.AutoSize = true;
            this.OtherLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtherLbl.Location = new System.Drawing.Point(617, 114);
            this.OtherLbl.Name = "OtherLbl";
            this.OtherLbl.Size = new System.Drawing.Size(51, 16);
            this.OtherLbl.TabIndex = 18;
            this.OtherLbl.Text = "label10";
            // 
            // TotalLbl
            // 
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLbl.Location = new System.Drawing.Point(617, 155);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(51, 16);
            this.TotalLbl.TabIndex = 19;
            this.TotalLbl.Text = "label11";
            // 
            // DayInput
            // 
            this.DayInput.Location = new System.Drawing.Point(187, 50);
            this.DayInput.Name = "DayInput";
            this.DayInput.Size = new System.Drawing.Size(95, 20);
            this.DayInput.TabIndex = 20;
            this.DayInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DayInput_KeyPress);
            // 
            // Hospital_Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DayInput);
            this.Controls.Add(this.TotalLbl);
            this.Controls.Add(this.OtherLbl);
            this.Controls.Add(this.StayLbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RehabInput);
            this.Controls.Add(this.LabInput);
            this.Controls.Add(this.SurgInput);
            this.Controls.Add(this.MedInput);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.Title);
            this.Name = "Hospital_Expenses";
            this.Text = "Hospital Expenses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox MedInput;
        private System.Windows.Forms.TextBox SurgInput;
        private System.Windows.Forms.TextBox LabInput;
        private System.Windows.Forms.TextBox RehabInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label StayLbl;
        private System.Windows.Forms.Label OtherLbl;
        private System.Windows.Forms.Label TotalLbl;
        private System.Windows.Forms.TextBox DayInput;
    }
}

