namespace Aeneas_Accounting
{
    partial class ExEntry
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
            this.label1 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.businessBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.partyBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.notesBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.freqBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // typeBox
            // 
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "Business",
            "Groceries",
            "Clothing",
            "Dining",
            "Automotive",
            "Medical",
            "Convenience",
            "Leisure",
            "Lifestyle"});
            this.typeBox.Location = new System.Drawing.Point(105, 6);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(182, 21);
            this.typeBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount";
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(192, 33);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(95, 20);
            this.valueBox.TabIndex = 2;
            // 
            // businessBox
            // 
            this.businessBox.FormattingEnabled = true;
            this.businessBox.Location = new System.Drawing.Point(105, 59);
            this.businessBox.Name = "businessBox";
            this.businessBox.Size = new System.Drawing.Size(182, 21);
            this.businessBox.TabIndex = 3;
            this.businessBox.SelectedIndexChanged += new System.EventHandler(this.businessBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Business";
            // 
            // partyBox
            // 
            this.partyBox.FormattingEnabled = true;
            this.partyBox.Items.AddRange(new object[] {
            "TJ",
            "Sam",
            "Troy"});
            this.partyBox.Location = new System.Drawing.Point(105, 86);
            this.partyBox.Name = "partyBox";
            this.partyBox.Size = new System.Drawing.Size(182, 21);
            this.partyBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Party";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Notes";
            // 
            // notesBox
            // 
            this.notesBox.Location = new System.Drawing.Point(12, 210);
            this.notesBox.Multiline = true;
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(276, 61);
            this.notesBox.TabIndex = 6;
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(192, 113);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(95, 20);
            this.dateBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(233, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "MM/DD/YY";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(12, 279);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 23);
            this.confirmBtn.TabIndex = 7;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(212, 279);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "¥";
            // 
            // freqBox
            // 
            this.freqBox.FormattingEnabled = true;
            this.freqBox.Items.AddRange(new object[] {
            "Monthly",
            "Bimonthly",
            "Trimonthly",
            "Semi-Annually",
            "Annually",
            "Once"});
            this.freqBox.Location = new System.Drawing.Point(106, 151);
            this.freqBox.Name = "freqBox";
            this.freqBox.Size = new System.Drawing.Size(182, 21);
            this.freqBox.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Frequency";
            // 
            // ExEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 314);
            this.Controls.Add(this.freqBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.notesBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.partyBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.businessBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.valueBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.label1);
            this.Name = "ExEntry";
            this.Text = "Expense Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.ComboBox businessBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox partyBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox notesBox;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox freqBox;
        private System.Windows.Forms.Label label9;
    }
}