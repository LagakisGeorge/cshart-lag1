namespace WindowsFormsApplication1
{
    partial class QUERY_SETUP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QUERY_SETUP));
            this.DELETE = new System.Windows.Forms.Button();
            this.SAVE = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.LFields = new System.Windows.Forms.ListBox();
            this.LSelect = new System.Windows.Forms.ListBox();
            this.tabs = new System.Windows.Forms.TabControl();
            this.fields = new System.Windows.Forms.TabPage();
            this.pDel = new System.Windows.Forms.Button();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pDown = new System.Windows.Forms.Button();
            this.pUp = new System.Windows.Forms.Button();
            this.searching = new System.Windows.Forms.TabPage();
            this.sDelete = new System.Windows.Forms.Button();
            this.sDOWN = new System.Windows.Forms.Button();
            this.sUP = new System.Windows.Forms.Button();
            this.LSearch = new System.Windows.Forms.ListBox();
            this.oPage = new System.Windows.Forms.TabPage();
            this.oDel = new System.Windows.Forms.Button();
            this.oDown = new System.Windows.Forms.Button();
            this.oUp = new System.Windows.Forms.Button();
            this.LOrder = new System.Windows.Forms.ListBox();
            this.tabs.SuspendLayout();
            this.fields.SuspendLayout();
            this.searching.SuspendLayout();
            this.oPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // DELETE
            // 
            this.DELETE.Location = new System.Drawing.Point(690, 57);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(198, 21);
            this.DELETE.TabIndex = 12;
            this.DELETE.Text = "Διαγραφή";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // SAVE
            // 
            this.SAVE.Location = new System.Drawing.Point(689, 22);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(200, 21);
            this.SAVE.TabIndex = 11;
            this.SAVE.Text = "Αποθήκευση";
            this.SAVE.UseVisualStyleBackColor = true;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(689, 166);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(39, 13);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Label1";
            this.Label1.Visible = false;
            // 
            // LFields
            // 
            this.LFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LFields.FormattingEnabled = true;
            this.LFields.Location = new System.Drawing.Point(2, 22);
            this.LFields.Name = "LFields";
            this.LFields.Size = new System.Drawing.Size(153, 576);
            this.LFields.TabIndex = 9;
            this.LFields.SelectedIndexChanged += new System.EventHandler(this.LFields_SelectedIndexChanged);
            // 
            // LSelect
            // 
            this.LSelect.FormattingEnabled = true;
            this.LSelect.Location = new System.Drawing.Point(0, 0);
            this.LSelect.Name = "LSelect";
            this.LSelect.Size = new System.Drawing.Size(265, 537);
            this.LSelect.TabIndex = 0;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.fields);
            this.tabs.Controls.Add(this.searching);
            this.tabs.Controls.Add(this.oPage);
            this.tabs.Location = new System.Drawing.Point(157, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(526, 598);
            this.tabs.TabIndex = 8;
            // 
            // fields
            // 
            this.fields.Controls.Add(this.pDel);
            this.fields.Controls.Add(this.pDown);
            this.fields.Controls.Add(this.pUp);
            this.fields.Controls.Add(this.LSelect);
            this.fields.Location = new System.Drawing.Point(4, 22);
            this.fields.Name = "fields";
            this.fields.Padding = new System.Windows.Forms.Padding(3);
            this.fields.Size = new System.Drawing.Size(518, 572);
            this.fields.TabIndex = 0;
            this.fields.Text = "Πεδία Εκτύπωσης";
            this.fields.UseVisualStyleBackColor = true;
            // 
            // pDel
            // 
            this.pDel.ImageKey = "1434198501_3.ico";
            this.pDel.ImageList = this.ImageList1;
            this.pDel.Location = new System.Drawing.Point(270, 96);
            this.pDel.Margin = new System.Windows.Forms.Padding(2);
            this.pDel.Name = "pDel";
            this.pDel.Size = new System.Drawing.Size(20, 20);
            this.pDel.TabIndex = 3;
            this.pDel.UseVisualStyleBackColor = true;
            this.pDel.Click += new System.EventHandler(this.pDel_Click);
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "1434198331_9.ico");
            this.ImageList1.Images.SetKeyName(1, "1434198373_10.ico");
            this.ImageList1.Images.SetKeyName(2, "1434198501_3.ico");
            this.ImageList1.Images.SetKeyName(3, "1434198515_1.ico");
            this.ImageList1.Images.SetKeyName(4, "1434198530_4.ico");
            // 
            // pDown
            // 
            this.pDown.ImageKey = "1434198373_10.ico";
            this.pDown.ImageList = this.ImageList1;
            this.pDown.Location = new System.Drawing.Point(270, 156);
            this.pDown.Margin = new System.Windows.Forms.Padding(2);
            this.pDown.Name = "pDown";
            this.pDown.Size = new System.Drawing.Size(20, 20);
            this.pDown.TabIndex = 2;
            this.pDown.UseVisualStyleBackColor = true;
            this.pDown.Click += new System.EventHandler(this.pDown_Click);
            // 
            // pUp
            // 
            this.pUp.ImageKey = "1434198331_9.ico";
            this.pUp.ImageList = this.ImageList1;
            this.pUp.Location = new System.Drawing.Point(270, 36);
            this.pUp.Margin = new System.Windows.Forms.Padding(2);
            this.pUp.Name = "pUp";
            this.pUp.Size = new System.Drawing.Size(20, 20);
            this.pUp.TabIndex = 1;
            this.pUp.UseVisualStyleBackColor = true;
            this.pUp.Click += new System.EventHandler(this.pUp_Click);
            // 
            // searching
            // 
            this.searching.Controls.Add(this.sDelete);
            this.searching.Controls.Add(this.sDOWN);
            this.searching.Controls.Add(this.sUP);
            this.searching.Controls.Add(this.LSearch);
            this.searching.Location = new System.Drawing.Point(4, 22);
            this.searching.Name = "searching";
            this.searching.Padding = new System.Windows.Forms.Padding(3);
            this.searching.Size = new System.Drawing.Size(518, 572);
            this.searching.TabIndex = 1;
            this.searching.Text = "Πεδία Αναζήτησης";
            this.searching.UseVisualStyleBackColor = true;
            // 
            // sDelete
            // 
            this.sDelete.ImageKey = "1434198501_3.ico";
            this.sDelete.ImageList = this.ImageList1;
            this.sDelete.Location = new System.Drawing.Point(270, 96);
            this.sDelete.Margin = new System.Windows.Forms.Padding(2);
            this.sDelete.Name = "sDelete";
            this.sDelete.Size = new System.Drawing.Size(20, 20);
            this.sDelete.TabIndex = 6;
            this.sDelete.UseVisualStyleBackColor = true;
            this.sDelete.Click += new System.EventHandler(this.sDelete_Click);
            // 
            // sDOWN
            // 
            this.sDOWN.ImageKey = "1434198373_10.ico";
            this.sDOWN.ImageList = this.ImageList1;
            this.sDOWN.Location = new System.Drawing.Point(270, 156);
            this.sDOWN.Margin = new System.Windows.Forms.Padding(2);
            this.sDOWN.Name = "sDOWN";
            this.sDOWN.Size = new System.Drawing.Size(20, 20);
            this.sDOWN.TabIndex = 5;
            this.sDOWN.UseVisualStyleBackColor = true;
            this.sDOWN.Click += new System.EventHandler(this.sDOWN_Click);
            // 
            // sUP
            // 
            this.sUP.ImageKey = "1434198331_9.ico";
            this.sUP.ImageList = this.ImageList1;
            this.sUP.Location = new System.Drawing.Point(270, 36);
            this.sUP.Margin = new System.Windows.Forms.Padding(2);
            this.sUP.Name = "sUP";
            this.sUP.Size = new System.Drawing.Size(20, 20);
            this.sUP.TabIndex = 4;
            this.sUP.UseVisualStyleBackColor = true;
            this.sUP.Click += new System.EventHandler(this.sUP_Click_1);
            // 
            // LSearch
            // 
            this.LSearch.FormattingEnabled = true;
            this.LSearch.Location = new System.Drawing.Point(0, 0);
            this.LSearch.Name = "LSearch";
            this.LSearch.Size = new System.Drawing.Size(265, 537);
            this.LSearch.TabIndex = 0;
            // 
            // oPage
            // 
            this.oPage.Controls.Add(this.oDel);
            this.oPage.Controls.Add(this.oDown);
            this.oPage.Controls.Add(this.oUp);
            this.oPage.Controls.Add(this.LOrder);
            this.oPage.Location = new System.Drawing.Point(4, 22);
            this.oPage.Name = "oPage";
            this.oPage.Size = new System.Drawing.Size(518, 572);
            this.oPage.TabIndex = 2;
            this.oPage.Text = "Ταξινόμηση";
            this.oPage.UseVisualStyleBackColor = true;
            // 
            // oDel
            // 
            this.oDel.ImageKey = "1434198501_3.ico";
            this.oDel.ImageList = this.ImageList1;
            this.oDel.Location = new System.Drawing.Point(270, 96);
            this.oDel.Margin = new System.Windows.Forms.Padding(2);
            this.oDel.Name = "oDel";
            this.oDel.Size = new System.Drawing.Size(20, 20);
            this.oDel.TabIndex = 6;
            this.oDel.UseVisualStyleBackColor = true;
            this.oDel.Click += new System.EventHandler(this.oDel_Click_1);
            // 
            // oDown
            // 
            this.oDown.ImageKey = "1434198373_10.ico";
            this.oDown.ImageList = this.ImageList1;
            this.oDown.Location = new System.Drawing.Point(270, 156);
            this.oDown.Margin = new System.Windows.Forms.Padding(2);
            this.oDown.Name = "oDown";
            this.oDown.Size = new System.Drawing.Size(20, 20);
            this.oDown.TabIndex = 5;
            this.oDown.UseVisualStyleBackColor = true;
            this.oDown.Click += new System.EventHandler(this.oDown_Click);
            // 
            // oUp
            // 
            this.oUp.ImageKey = "1434198331_9.ico";
            this.oUp.ImageList = this.ImageList1;
            this.oUp.Location = new System.Drawing.Point(270, 36);
            this.oUp.Margin = new System.Windows.Forms.Padding(2);
            this.oUp.Name = "oUp";
            this.oUp.Size = new System.Drawing.Size(20, 20);
            this.oUp.TabIndex = 4;
            this.oUp.UseVisualStyleBackColor = true;
            this.oUp.Click += new System.EventHandler(this.oUp_Click_1);
            // 
            // LOrder
            // 
            this.LOrder.FormattingEnabled = true;
            this.LOrder.Location = new System.Drawing.Point(0, 0);
            this.LOrder.Name = "LOrder";
            this.LOrder.Size = new System.Drawing.Size(265, 537);
            this.LOrder.TabIndex = 0;
            // 
            // QUERY_SETUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1041, 588);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LFields);
            this.Controls.Add(this.tabs);
            this.Name = "QUERY_SETUP";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.QUERY_SETUP_Load);
            this.tabs.ResumeLayout(false);
            this.fields.ResumeLayout(false);
            this.searching.ResumeLayout(false);
            this.oPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button DELETE;
        internal System.Windows.Forms.Button SAVE;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ListBox LFields;
        internal System.Windows.Forms.ListBox LSelect;
        internal System.Windows.Forms.TabControl tabs;
        internal System.Windows.Forms.TabPage fields;
        internal System.Windows.Forms.Button pDel;
        internal System.Windows.Forms.Button pDown;
        internal System.Windows.Forms.Button pUp;
        internal System.Windows.Forms.TabPage searching;
        internal System.Windows.Forms.Button sDelete;
        internal System.Windows.Forms.Button sDOWN;
        internal System.Windows.Forms.Button sUP;
        internal System.Windows.Forms.ListBox LSearch;
        internal System.Windows.Forms.TabPage oPage;
        internal System.Windows.Forms.Button oDel;
        internal System.Windows.Forms.Button oDown;
        internal System.Windows.Forms.Button oUp;
        internal System.Windows.Forms.ListBox LOrder;
        internal System.Windows.Forms.ImageList ImageList1;
    }
}