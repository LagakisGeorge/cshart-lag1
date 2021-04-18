namespace WindowsFormsApplication1
{
    partial class GUI_ANAZ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_ANAZ));
            this.ΣχεδίασηToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ΠροεπιλογToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ContextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ANAZHTHSH = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.ContextMenuStrip3.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ΣχεδίασηToolStripMenuItem
            // 
            this.ΣχεδίασηToolStripMenuItem.Name = "ΣχεδίασηToolStripMenuItem";
            this.ΣχεδίασηToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.ΣχεδίασηToolStripMenuItem.Text = "Σχεδίαση";
            this.ΣχεδίασηToolStripMenuItem.Click += new System.EventHandler(this.ΣχεδίασηToolStripMenuItem_Click_1);
            // 
            // ΠροεπιλογToolStripMenuItem
            // 
            this.ΠροεπιλογToolStripMenuItem.Name = "ΠροεπιλογToolStripMenuItem";
            this.ΠροεπιλογToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.ΠροεπιλογToolStripMenuItem.Text = "Προεπιλογή";
            this.ΠροεπιλογToolStripMenuItem.Click += new System.EventHandler(this.ΠροεπιλογToolStripMenuItem_Click_1);
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "organize.ico");
            this.ImageList1.Images.SetKeyName(1, "cubes.ico");
            this.ImageList1.Images.SetKeyName(2, "1433811956_blue_arrow_down.ico");
            this.ImageList1.Images.SetKeyName(3, "1433812344_arrow_full_down.ico");
            this.ImageList1.Images.SetKeyName(4, "1433812688_arrow_sans_down.ico");
            // 
            // ContextMenuStrip3
            // 
            this.ContextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ΠροεπιλογToolStripMenuItem,
            this.ΣχεδίασηToolStripMenuItem});
            this.ContextMenuStrip3.Name = "ContextMenuStrip3";
            this.ContextMenuStrip3.ShowCheckMargin = true;
            this.ContextMenuStrip3.Size = new System.Drawing.Size(162, 48);
            // 
            // Panel1
            // 
            this.Panel1.Location = new System.Drawing.Point(9, 49);
            this.Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(806, 335);
            this.Panel1.TabIndex = 1;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Panel2.Controls.Add(this.button3);
            this.Panel2.Controls.Add(this.button1);
            this.Panel2.Controls.Add(this.button2);
            this.Panel2.Controls.Add(this.ANAZHTHSH);
            this.Panel2.Location = new System.Drawing.Point(9, 2);
            this.Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(806, 41);
            this.Panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(83, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ANAZHTHSH
            // 
            this.ANAZHTHSH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ANAZHTHSH.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ANAZHTHSH.ImageIndex = 4;
            this.ANAZHTHSH.ImageList = this.ImageList1;
            this.ANAZHTHSH.Location = new System.Drawing.Point(2, 3);
            this.ANAZHTHSH.Margin = new System.Windows.Forms.Padding(2);
            this.ANAZHTHSH.Name = "ANAZHTHSH";
            this.ANAZHTHSH.Size = new System.Drawing.Size(76, 36);
            this.ANAZHTHSH.TabIndex = 0;
            this.ANAZHTHSH.Text = "Ευρετήριο";
            this.ANAZHTHSH.UseVisualStyleBackColor = true;
            this.ANAZHTHSH.Click += new System.EventHandler(this.ANAZHTHSH_Click);
            this.ANAZHTHSH.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ANAZHTHSH_MouseUp_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(821, 48);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(140, 42);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(297, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "PrintPreview";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // GUI_ANAZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 706);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GUI_ANAZ";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GUI_ANAZ_Load);
            this.Resize += new System.EventHandler(this.GUI_ANAZ_Resize_1);
            this.ContextMenuStrip3.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ToolStripMenuItem ΣχεδίασηToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ΠροεπιλογToolStripMenuItem;
        internal System.Windows.Forms.ImageList ImageList1;
        internal System.Windows.Forms.ContextMenuStrip ContextMenuStrip3;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ANAZHTHSH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}