namespace Aeneas_Accounting
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
            this.newBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.displayView = new System.Windows.Forms.ListView();
            this.idH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.businessH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valueH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partyH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.miscH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.expenseView = new System.Windows.Forms.ListView();
            this.eidH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.efreqh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.etypeH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.edateH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ebusinessH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.evalueH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.epartyH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteBtn = new System.Windows.Forms.Button();
            this.exNewBtn = new System.Windows.Forms.Button();
            this.exEditBtn = new System.Windows.Forms.Button();
            this.exDelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalExLbl = new System.Windows.Forms.Label();
            this.budLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.budBtn = new System.Windows.Forms.Button();
            this.remLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalTranLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // newBtn
            // 
            this.newBtn.Location = new System.Drawing.Point(12, 336);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(134, 23);
            this.newBtn.TabIndex = 1;
            this.newBtn.Text = "New Transaction";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.displayView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 318);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transactions";
            // 
            // displayView
            // 
            this.displayView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idH,
            this.typeH,
            this.dateH,
            this.businessH,
            this.valueH,
            this.partyH,
            this.miscH});
            this.displayView.FullRowSelect = true;
            this.displayView.Location = new System.Drawing.Point(6, 19);
            this.displayView.MultiSelect = false;
            this.displayView.Name = "displayView";
            this.displayView.Size = new System.Drawing.Size(550, 293);
            this.displayView.TabIndex = 1;
            this.displayView.UseCompatibleStateImageBehavior = false;
            this.displayView.SelectedIndexChanged += new System.EventHandler(this.displayView_SelectedIndexChanged);
            // 
            // idH
            // 
            this.idH.Tag = "id";
            this.idH.Text = "ID";
            this.idH.Width = 30;
            // 
            // typeH
            // 
            this.typeH.Tag = "type";
            this.typeH.Text = "Type";
            this.typeH.Width = 100;
            // 
            // dateH
            // 
            this.dateH.Tag = "date";
            this.dateH.Text = "Date";
            this.dateH.Width = 80;
            // 
            // businessH
            // 
            this.businessH.Tag = "business";
            this.businessH.Text = "Business";
            this.businessH.Width = 100;
            // 
            // valueH
            // 
            this.valueH.Tag = "value";
            this.valueH.Text = "Amount";
            this.valueH.Width = 80;
            // 
            // partyH
            // 
            this.partyH.Tag = "party";
            this.partyH.Text = "Party";
            this.partyH.Width = 70;
            // 
            // miscH
            // 
            this.miscH.Tag = "misc";
            this.miscH.Text = "Miscellaneous";
            this.miscH.Width = 90;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(12, 365);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(134, 23);
            this.editBtn.TabIndex = 3;
            this.editBtn.Text = "Edit Transaction";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(493, 336);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.expenseView);
            this.groupBox2.Location = new System.Drawing.Point(582, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 318);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Budgeted Expenses";
            // 
            // expenseView
            // 
            this.expenseView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.eidH,
            this.efreqh,
            this.etypeH,
            this.edateH,
            this.ebusinessH,
            this.evalueH,
            this.epartyH});
            this.expenseView.FullRowSelect = true;
            this.expenseView.Location = new System.Drawing.Point(6, 19);
            this.expenseView.Name = "expenseView";
            this.expenseView.Size = new System.Drawing.Size(439, 284);
            this.expenseView.TabIndex = 6;
            this.expenseView.UseCompatibleStateImageBehavior = false;
            // 
            // eidH
            // 
            this.eidH.Text = "ID";
            this.eidH.Width = 30;
            // 
            // efreqh
            // 
            this.efreqh.Text = "Frequency";
            this.efreqh.Width = 80;
            // 
            // etypeH
            // 
            this.etypeH.Text = "Type";
            this.etypeH.Width = 80;
            // 
            // edateH
            // 
            this.edateH.Text = "Date";
            this.edateH.Width = 80;
            // 
            // ebusinessH
            // 
            this.ebusinessH.Text = "Business";
            this.ebusinessH.Width = 90;
            // 
            // evalueH
            // 
            this.evalueH.Text = "Amount";
            this.evalueH.Width = 80;
            // 
            // epartyH
            // 
            this.epartyH.Text = "Party";
            this.epartyH.Width = 80;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(12, 394);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(134, 23);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Delete Transaction";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // exNewBtn
            // 
            this.exNewBtn.Location = new System.Drawing.Point(582, 336);
            this.exNewBtn.Name = "exNewBtn";
            this.exNewBtn.Size = new System.Drawing.Size(134, 23);
            this.exNewBtn.TabIndex = 7;
            this.exNewBtn.Text = "New Expense";
            this.exNewBtn.UseVisualStyleBackColor = true;
            this.exNewBtn.Click += new System.EventHandler(this.exNewBtn_Click);
            // 
            // exEditBtn
            // 
            this.exEditBtn.Location = new System.Drawing.Point(582, 365);
            this.exEditBtn.Name = "exEditBtn";
            this.exEditBtn.Size = new System.Drawing.Size(134, 23);
            this.exEditBtn.TabIndex = 8;
            this.exEditBtn.Text = "Edit Expense";
            this.exEditBtn.UseVisualStyleBackColor = true;
            this.exEditBtn.Click += new System.EventHandler(this.exEditBtn_Click);
            // 
            // exDelBtn
            // 
            this.exDelBtn.Location = new System.Drawing.Point(582, 394);
            this.exDelBtn.Name = "exDelBtn";
            this.exDelBtn.Size = new System.Drawing.Size(134, 23);
            this.exDelBtn.TabIndex = 9;
            this.exDelBtn.Text = "Delete Expense";
            this.exDelBtn.UseVisualStyleBackColor = true;
            this.exDelBtn.Click += new System.EventHandler(this.exDelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(779, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total Budgeted Expenses";
            // 
            // totalExLbl
            // 
            this.totalExLbl.AutoSize = true;
            this.totalExLbl.Location = new System.Drawing.Point(955, 341);
            this.totalExLbl.Name = "totalExLbl";
            this.totalExLbl.Size = new System.Drawing.Size(59, 13);
            this.totalExLbl.TabIndex = 11;
            this.totalExLbl.Text = "totalExpLbl";
            // 
            // budLbl
            // 
            this.budLbl.AutoSize = true;
            this.budLbl.Location = new System.Drawing.Point(955, 370);
            this.budLbl.Name = "budLbl";
            this.budLbl.Size = new System.Drawing.Size(39, 13);
            this.budLbl.TabIndex = 13;
            this.budLbl.Text = "budLbl";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(779, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total Budgeted Amount";
            // 
            // budBtn
            // 
            this.budBtn.Location = new System.Drawing.Point(722, 365);
            this.budBtn.Name = "budBtn";
            this.budBtn.Size = new System.Drawing.Size(33, 23);
            this.budBtn.TabIndex = 14;
            this.budBtn.Text = "Set";
            this.budBtn.UseVisualStyleBackColor = true;
            this.budBtn.Click += new System.EventHandler(this.budBtn_Click);
            // 
            // remLbl
            // 
            this.remLbl.AutoSize = true;
            this.remLbl.Location = new System.Drawing.Point(955, 399);
            this.remLbl.Name = "remLbl";
            this.remLbl.Size = new System.Drawing.Size(38, 13);
            this.remLbl.TabIndex = 16;
            this.remLbl.Text = "remLbl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(779, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Remainder";
            // 
            // totalTranLbl
            // 
            this.totalTranLbl.AutoSize = true;
            this.totalTranLbl.Location = new System.Drawing.Point(385, 341);
            this.totalTranLbl.Name = "totalTranLbl";
            this.totalTranLbl.Size = new System.Drawing.Size(63, 13);
            this.totalTranLbl.TabIndex = 18;
            this.totalTranLbl.Text = "totalTranLbl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Transaction Total (Month)";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 427);
            this.Controls.Add(this.totalTranLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.remLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.budBtn);
            this.Controls.Add(this.budLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalExLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exDelBtn);
            this.Controls.Add(this.exEditBtn);
            this.Controls.Add(this.exNewBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.newBtn);
            this.Name = "Main";
            this.Text = "Aeneas Personal Accounting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.ListView displayView;
        private System.Windows.Forms.ColumnHeader idH;
        private System.Windows.Forms.ColumnHeader typeH;
        private System.Windows.Forms.ColumnHeader dateH;
        private System.Windows.Forms.ColumnHeader businessH;
        private System.Windows.Forms.ColumnHeader valueH;
        private System.Windows.Forms.ColumnHeader partyH;
        private System.Windows.Forms.ColumnHeader miscH;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView expenseView;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button exNewBtn;
        private System.Windows.Forms.Button exEditBtn;
        private System.Windows.Forms.Button exDelBtn;
        private System.Windows.Forms.ColumnHeader eidH;
        private System.Windows.Forms.ColumnHeader efreqh;
        private System.Windows.Forms.ColumnHeader etypeH;
        private System.Windows.Forms.ColumnHeader edateH;
        private System.Windows.Forms.ColumnHeader ebusinessH;
        private System.Windows.Forms.ColumnHeader evalueH;
        private System.Windows.Forms.ColumnHeader epartyH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalExLbl;
        private System.Windows.Forms.Label budLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button budBtn;
        private System.Windows.Forms.Label remLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalTranLbl;
        private System.Windows.Forms.Label label5;
    }
}

