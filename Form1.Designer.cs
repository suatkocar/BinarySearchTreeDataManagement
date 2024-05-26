namespace Exercise2
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
            this.components = new System.ComponentModel.Container();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.listBoxOutputInt = new System.Windows.Forms.ListBox();
            this.btnInsertNumber = new System.Windows.Forms.Button();
            this.btnPreOrderInt = new System.Windows.Forms.Button();
            this.btnInOrderInt = new System.Windows.Forms.Button();
            this.btnPostOrderInt = new System.Windows.Forms.Button();
            this.lblTotalItemsInt = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxAmountOwed = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnFindCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxOutputCustomer = new System.Windows.Forms.ListBox();
            this.btnPreOrderCustomer = new System.Windows.Forms.Button();
            this.btnInOrderCustomer = new System.Windows.Forms.Button();
            this.btnPostOrderCustomer = new System.Windows.Forms.Button();
            this.lblTotalItemsCustomer = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(54, 80);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(218, 31);
            this.textBoxNumber.TabIndex = 0;
            this.textBoxNumber.Text = "Enter a number";
            // 
            // listBoxOutputInt
            // 
            this.listBoxOutputInt.FormattingEnabled = true;
            this.listBoxOutputInt.ItemHeight = 25;
            this.listBoxOutputInt.Location = new System.Drawing.Point(305, 80);
            this.listBoxOutputInt.Name = "listBoxOutputInt";
            this.listBoxOutputInt.Size = new System.Drawing.Size(218, 654);
            this.listBoxOutputInt.TabIndex = 1;
            // 
            // btnInsertNumber
            // 
            this.btnInsertNumber.Location = new System.Drawing.Point(54, 646);
            this.btnInsertNumber.Name = "btnInsertNumber";
            this.btnInsertNumber.Size = new System.Drawing.Size(218, 88);
            this.btnInsertNumber.TabIndex = 2;
            this.btnInsertNumber.Text = "Insert Number";
            this.btnInsertNumber.UseVisualStyleBackColor = true;
            this.btnInsertNumber.Click += new System.EventHandler(this.btnInsertNumber_Click);
            // 
            // btnPreOrderInt
            // 
            this.btnPreOrderInt.Location = new System.Drawing.Point(305, 812);
            this.btnPreOrderInt.Name = "btnPreOrderInt";
            this.btnPreOrderInt.Size = new System.Drawing.Size(218, 88);
            this.btnPreOrderInt.TabIndex = 3;
            this.btnPreOrderInt.Text = "Pre-Order Traversal";
            this.btnPreOrderInt.UseVisualStyleBackColor = true;
            this.btnPreOrderInt.Click += new System.EventHandler(this.btnPreOrderInt_Click);
            // 
            // btnInOrderInt
            // 
            this.btnInOrderInt.Location = new System.Drawing.Point(305, 930);
            this.btnInOrderInt.Name = "btnInOrderInt";
            this.btnInOrderInt.Size = new System.Drawing.Size(218, 88);
            this.btnInOrderInt.TabIndex = 4;
            this.btnInOrderInt.Text = "InOrder Traverse";
            this.btnInOrderInt.UseVisualStyleBackColor = true;
            this.btnInOrderInt.Click += new System.EventHandler(this.btnInOrderInt_Click);
            // 
            // btnPostOrderInt
            // 
            this.btnPostOrderInt.Location = new System.Drawing.Point(305, 1051);
            this.btnPostOrderInt.Name = "btnPostOrderInt";
            this.btnPostOrderInt.Size = new System.Drawing.Size(218, 88);
            this.btnPostOrderInt.TabIndex = 5;
            this.btnPostOrderInt.Text = "PostOrder Traverse";
            this.btnPostOrderInt.UseVisualStyleBackColor = true;
            this.btnPostOrderInt.Click += new System.EventHandler(this.btnPostOrderInt_Click);
            // 
            // lblTotalItemsInt
            // 
            this.lblTotalItemsInt.AutoSize = true;
            this.lblTotalItemsInt.Location = new System.Drawing.Point(343, 758);
            this.lblTotalItemsInt.Name = "lblTotalItemsInt";
            this.lblTotalItemsInt.Size = new System.Drawing.Size(141, 25);
            this.lblTotalItemsInt.TabIndex = 6;
            this.lblTotalItemsInt.Text = "Total Items: 0";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(736, 80);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(172, 31);
            this.textBoxName.TabIndex = 7;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(736, 168);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(76, 31);
            this.textBoxAge.TabIndex = 8;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(736, 252);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(172, 60);
            this.textBoxAddress.TabIndex = 9;
            // 
            // textBoxAmountOwed
            // 
            this.textBoxAmountOwed.Location = new System.Drawing.Point(736, 344);
            this.textBoxAmountOwed.Name = "textBoxAmountOwed";
            this.textBoxAmountOwed.Size = new System.Drawing.Size(100, 31);
            this.textBoxAmountOwed.TabIndex = 10;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(690, 528);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(218, 88);
            this.btnAddCustomer.TabIndex = 11;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnFindCustomer
            // 
            this.btnFindCustomer.Location = new System.Drawing.Point(690, 646);
            this.btnFindCustomer.Name = "btnFindCustomer";
            this.btnFindCustomer.Size = new System.Drawing.Size(218, 88);
            this.btnFindCustomer.TabIndex = 12;
            this.btnFindCustomer.Text = "Find Customer";
            this.btnFindCustomer.UseVisualStyleBackColor = true;
            this.btnFindCustomer.Click += new System.EventHandler(this.btnFindCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(565, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(565, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Amount Owed:";
            // 
            // listBoxOutputCustomer
            // 
            this.listBoxOutputCustomer.FormattingEnabled = true;
            this.listBoxOutputCustomer.ItemHeight = 25;
            this.listBoxOutputCustomer.Location = new System.Drawing.Point(945, 80);
            this.listBoxOutputCustomer.Name = "listBoxOutputCustomer";
            this.listBoxOutputCustomer.Size = new System.Drawing.Size(890, 654);
            this.listBoxOutputCustomer.TabIndex = 17;
            // 
            // btnPreOrderCustomer
            // 
            this.btnPreOrderCustomer.Location = new System.Drawing.Point(1197, 812);
            this.btnPreOrderCustomer.Name = "btnPreOrderCustomer";
            this.btnPreOrderCustomer.Size = new System.Drawing.Size(406, 88);
            this.btnPreOrderCustomer.TabIndex = 18;
            this.btnPreOrderCustomer.Text = "Pre-Order Traversal";
            this.btnPreOrderCustomer.UseVisualStyleBackColor = true;
            this.btnPreOrderCustomer.Click += new System.EventHandler(this.btnPreOrderCustomer_Click);
            // 
            // btnInOrderCustomer
            // 
            this.btnInOrderCustomer.Location = new System.Drawing.Point(1197, 930);
            this.btnInOrderCustomer.Name = "btnInOrderCustomer";
            this.btnInOrderCustomer.Size = new System.Drawing.Size(406, 88);
            this.btnInOrderCustomer.TabIndex = 19;
            this.btnInOrderCustomer.Text = "InOrder Traverse";
            this.btnInOrderCustomer.UseVisualStyleBackColor = true;
            this.btnInOrderCustomer.Click += new System.EventHandler(this.btnInOrderCustomer_Click);
            // 
            // btnPostOrderCustomer
            // 
            this.btnPostOrderCustomer.Location = new System.Drawing.Point(1197, 1051);
            this.btnPostOrderCustomer.Name = "btnPostOrderCustomer";
            this.btnPostOrderCustomer.Size = new System.Drawing.Size(406, 88);
            this.btnPostOrderCustomer.TabIndex = 20;
            this.btnPostOrderCustomer.Text = "PostOrder Traverse";
            this.btnPostOrderCustomer.UseVisualStyleBackColor = true;
            this.btnPostOrderCustomer.Click += new System.EventHandler(this.btnPostOrderCustomer_Click);
            // 
            // lblTotalItemsCustomer
            // 
            this.lblTotalItemsCustomer.AutoSize = true;
            this.lblTotalItemsCustomer.Location = new System.Drawing.Point(1338, 758);
            this.lblTotalItemsCustomer.Name = "lblTotalItemsCustomer";
            this.lblTotalItemsCustomer.Size = new System.Drawing.Size(141, 25);
            this.lblTotalItemsCustomer.TabIndex = 21;
            this.lblTotalItemsCustomer.Text = "Total Items: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1881, 1239);
            this.Controls.Add(this.lblTotalItemsCustomer);
            this.Controls.Add(this.btnPostOrderCustomer);
            this.Controls.Add(this.btnInOrderCustomer);
            this.Controls.Add(this.btnPreOrderCustomer);
            this.Controls.Add(this.listBoxOutputCustomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFindCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.textBoxAmountOwed);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.lblTotalItemsInt);
            this.Controls.Add(this.btnPostOrderInt);
            this.Controls.Add(this.btnInOrderInt);
            this.Controls.Add(this.btnPreOrderInt);
            this.Controls.Add(this.btnInsertNumber);
            this.Controls.Add(this.listBoxOutputInt);
            this.Controls.Add(this.textBoxNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.ListBox listBoxOutputInt;
        private System.Windows.Forms.Button btnInsertNumber;
        private System.Windows.Forms.Button btnPreOrderInt;
        private System.Windows.Forms.Button btnInOrderInt;
        private System.Windows.Forms.Button btnPostOrderInt;
        private System.Windows.Forms.Label lblTotalItemsInt;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxAmountOwed;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnFindCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxOutputCustomer;
        private System.Windows.Forms.Button btnPreOrderCustomer;
        private System.Windows.Forms.Button btnInOrderCustomer;
        private System.Windows.Forms.Button btnPostOrderCustomer;
        private System.Windows.Forms.Label lblTotalItemsCustomer;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

