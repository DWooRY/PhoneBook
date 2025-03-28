namespace PhoneBook.UI
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lst_bookList = new System.Windows.Forms.ListBox();
            this.gb_registration = new System.Windows.Forms.GroupBox();
            this.progbar_status = new System.Windows.Forms.ProgressBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_jsonExport = new System.Windows.Forms.Button();
            this.btn_xmlImport = new System.Windows.Forms.Button();
            this.btn_csvExport = new System.Windows.Forms.Button();
            this.btn_xmlExport = new System.Windows.Forms.Button();
            this.btn_deleteRegistration = new System.Windows.Forms.Button();
            this.btn_updateRegistration = new System.Windows.Forms.Button();
            this.btn_newRegistration = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_website = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_emailAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_phoneIII = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_phoneII = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_phoneI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gb_registration.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_bookList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 323);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book List";
            // 
            // lst_bookList
            // 
            this.lst_bookList.FormattingEnabled = true;
            this.lst_bookList.Location = new System.Drawing.Point(6, 19);
            this.lst_bookList.Name = "lst_bookList";
            this.lst_bookList.Size = new System.Drawing.Size(199, 290);
            this.lst_bookList.TabIndex = 0;
            this.lst_bookList.DoubleClick += new System.EventHandler(this.lst_bookList_DoubleClick);
            // 
            // gb_registration
            // 
            this.gb_registration.Controls.Add(this.progbar_status);
            this.gb_registration.Controls.Add(this.label11);
            this.gb_registration.Controls.Add(this.label10);
            this.gb_registration.Controls.Add(this.label9);
            this.gb_registration.Controls.Add(this.btn_jsonExport);
            this.gb_registration.Controls.Add(this.btn_xmlImport);
            this.gb_registration.Controls.Add(this.btn_csvExport);
            this.gb_registration.Controls.Add(this.btn_xmlExport);
            this.gb_registration.Controls.Add(this.btn_deleteRegistration);
            this.gb_registration.Controls.Add(this.btn_updateRegistration);
            this.gb_registration.Controls.Add(this.btn_newRegistration);
            this.gb_registration.Controls.Add(this.tabControl1);
            this.gb_registration.Location = new System.Drawing.Point(229, 12);
            this.gb_registration.Name = "gb_registration";
            this.gb_registration.Size = new System.Drawing.Size(786, 323);
            this.gb_registration.TabIndex = 1;
            this.gb_registration.TabStop = false;
            this.gb_registration.Text = "New Book";
            // 
            // progbar_status
            // 
            this.progbar_status.Location = new System.Drawing.Point(672, 279);
            this.progbar_status.Name = "progbar_status";
            this.progbar_status.Size = new System.Drawing.Size(100, 25);
            this.progbar_status.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.label11.Location = new System.Drawing.Point(670, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Status Export/Import";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(599, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Import Data";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(407, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Export Data";
            // 
            // btn_jsonExport
            // 
            this.btn_jsonExport.Location = new System.Drawing.Point(530, 274);
            this.btn_jsonExport.Name = "btn_jsonExport";
            this.btn_jsonExport.Size = new System.Drawing.Size(55, 37);
            this.btn_jsonExport.TabIndex = 4;
            this.btn_jsonExport.Text = "JSON";
            this.btn_jsonExport.UseVisualStyleBackColor = true;
            this.btn_jsonExport.Click += new System.EventHandler(this.btn_jsonExport_Click);
            // 
            // btn_xmlImport
            // 
            this.btn_xmlImport.Location = new System.Drawing.Point(600, 274);
            this.btn_xmlImport.Name = "btn_xmlImport";
            this.btn_xmlImport.Size = new System.Drawing.Size(55, 37);
            this.btn_xmlImport.TabIndex = 5;
            this.btn_xmlImport.Text = "XML";
            this.btn_xmlImport.UseVisualStyleBackColor = true;
            // 
            // btn_csvExport
            // 
            this.btn_csvExport.Location = new System.Drawing.Point(469, 274);
            this.btn_csvExport.Name = "btn_csvExport";
            this.btn_csvExport.Size = new System.Drawing.Size(55, 37);
            this.btn_csvExport.TabIndex = 3;
            this.btn_csvExport.Text = "CSV";
            this.btn_csvExport.UseVisualStyleBackColor = true;
            this.btn_csvExport.Click += new System.EventHandler(this.btn_csvExport_Click);
            // 
            // btn_xmlExport
            // 
            this.btn_xmlExport.Location = new System.Drawing.Point(408, 274);
            this.btn_xmlExport.Name = "btn_xmlExport";
            this.btn_xmlExport.Size = new System.Drawing.Size(55, 37);
            this.btn_xmlExport.TabIndex = 2;
            this.btn_xmlExport.Text = "XML";
            this.btn_xmlExport.UseVisualStyleBackColor = true;
            this.btn_xmlExport.Click += new System.EventHandler(this.btn_xmlExport_Click);
            // 
            // btn_deleteRegistration
            // 
            this.btn_deleteRegistration.Location = new System.Drawing.Point(285, 261);
            this.btn_deleteRegistration.Name = "btn_deleteRegistration";
            this.btn_deleteRegistration.Size = new System.Drawing.Size(112, 52);
            this.btn_deleteRegistration.TabIndex = 1;
            this.btn_deleteRegistration.Text = "Delete Registration";
            this.btn_deleteRegistration.UseVisualStyleBackColor = true;
            this.btn_deleteRegistration.Click += new System.EventHandler(this.btn_deleteRegistration_Click);
            // 
            // btn_updateRegistration
            // 
            this.btn_updateRegistration.Location = new System.Drawing.Point(149, 261);
            this.btn_updateRegistration.Name = "btn_updateRegistration";
            this.btn_updateRegistration.Size = new System.Drawing.Size(130, 52);
            this.btn_updateRegistration.TabIndex = 1;
            this.btn_updateRegistration.Text = "Update Registration";
            this.btn_updateRegistration.UseVisualStyleBackColor = true;
            this.btn_updateRegistration.Click += new System.EventHandler(this.btn_updateRegistration_Click);
            // 
            // btn_newRegistration
            // 
            this.btn_newRegistration.Location = new System.Drawing.Point(13, 261);
            this.btn_newRegistration.Name = "btn_newRegistration";
            this.btn_newRegistration.Size = new System.Drawing.Size(130, 52);
            this.btn_newRegistration.TabIndex = 0;
            this.btn_newRegistration.Text = "Add New Registration";
            this.btn_newRegistration.UseVisualStyleBackColor = true;
            this.btn_newRegistration.Click += new System.EventHandler(this.btn_newRegistration_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(772, 233);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_address);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txt_website);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txt_emailAddress);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txt_phoneIII);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_phoneII);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txt_phoneI);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_surname);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_name);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(764, 207);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personal Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(464, 43);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(292, 150);
            this.txt_address.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(461, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Address";
            // 
            // txt_website
            // 
            this.txt_website.Location = new System.Drawing.Point(104, 173);
            this.txt_website.Name = "txt_website";
            this.txt_website.Size = new System.Drawing.Size(327, 20);
            this.txt_website.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Website";
            // 
            // txt_emailAddress
            // 
            this.txt_emailAddress.Location = new System.Drawing.Point(104, 147);
            this.txt_emailAddress.Name = "txt_emailAddress";
            this.txt_emailAddress.Size = new System.Drawing.Size(327, 20);
            this.txt_emailAddress.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email Address";
            // 
            // txt_phoneIII
            // 
            this.txt_phoneIII.Location = new System.Drawing.Point(104, 121);
            this.txt_phoneIII.Name = "txt_phoneIII";
            this.txt_phoneIII.Size = new System.Drawing.Size(327, 20);
            this.txt_phoneIII.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phone III";
            // 
            // txt_phoneII
            // 
            this.txt_phoneII.Location = new System.Drawing.Point(104, 95);
            this.txt_phoneII.Name = "txt_phoneII";
            this.txt_phoneII.Size = new System.Drawing.Size(327, 20);
            this.txt_phoneII.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phone II";
            // 
            // txt_phoneI
            // 
            this.txt_phoneI.Location = new System.Drawing.Point(104, 69);
            this.txt_phoneI.Name = "txt_phoneI";
            this.txt_phoneI.Size = new System.Drawing.Size(327, 20);
            this.txt_phoneI.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone I";
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(104, 43);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(327, 20);
            this.txt_surname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Surname";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(104, 17);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(327, 20);
            this.txt_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_description);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(764, 207);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Description";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(6, 6);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(752, 317);
            this.txt_description.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 342);
            this.Controls.Add(this.gb_registration);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.gb_registration.ResumeLayout(false);
            this.gb_registration.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gb_registration;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_website;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_emailAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_phoneIII;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_phoneII;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_phoneI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_newRegistration;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Button btn_updateRegistration;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_jsonExport;
        private System.Windows.Forms.Button btn_xmlImport;
        private System.Windows.Forms.Button btn_csvExport;
        private System.Windows.Forms.ListBox lst_bookList;
        private System.Windows.Forms.ProgressBar progbar_status;
        private System.Windows.Forms.Button btn_deleteRegistration;
        private System.Windows.Forms.Button btn_xmlExport;
    }
}