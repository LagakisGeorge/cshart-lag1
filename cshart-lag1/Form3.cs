using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FocusedTextBox;
namespace WindowsFormsApplication1
{
    public partial class editing : Form
    {
        public editing()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TableLayoutPanel Table = new TableLayoutPanel();
            Table.Location = new Point(10, 40);
            Table.Size = new Size(620, 100);
            Table.AutoSize = true;
            // You should write the code to set Anchor property programmatically only in the Form_Load event
            Table.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            Table.Name = "Desk";
            Table.ColumnCount = 6;
            Table.RowCount = 0;
            Table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Table.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddRows;
            this.Controls.Add(Table);
            int row = 0;

            Table.Controls.Add(new Label() { Text = "Ετικέττα:", Anchor = AnchorStyles.Left, AutoSize = true }, 0, row);
            Table.Controls.Add(new ComboBox() { Width = 300, Dock = DockStyle.Fill }, 0, row + 1);


            Table.Controls.Add(new Label() { Text = "Τύπος:", Anchor = AnchorStyles.Left, AutoSize = true }, 1, row);
            Table.Controls.Add(new ComboBox() { Dock = DockStyle.Fill }, 1, row + 1);

            Table.Controls.Add(new Label() { Text = "λλΤύπος:", Anchor = AnchorStyles.Left, AutoSize = true }, 2, row);
            Table.Controls.Add(new FocusedTextBox.FocusedTextBox() { Name = "sss",EnterFocusColor = Color.Yellow, Dock = DockStyle.Fill }, 2, row + 1);
            
            Table.Controls.Add(new Label() { Text = "λλΤύπος:", Anchor = AnchorStyles.Left, AutoSize = true }, 3, row);
            Table.Controls.Add(new FocusedTextBox.FocusedTextBox() { Name = "sss", EnterFocusColor = Color.Yellow, Dock = DockStyle.Fill }, 3, row + 1);
          
            Table.Controls.Add(new Label() { Text = "λλΤύπος:", Anchor = AnchorStyles.Left, AutoSize = true }, 4, row);
            Table.Controls.Add(new FocusedTextBox.FocusedTextBox() { Name = "sss", EnterFocusColor = Color.Yellow, Dock = DockStyle.Fill }, 4, row + 1);


            row++;

            row++;

            Table.Controls.Add(new Label() { Text = "Ετικέττα:", Anchor = AnchorStyles.Left, AutoSize = true }, 0, row);
            Table.Controls.Add(new ComboBox() { Dock = DockStyle.Fill }, 0, row + 1);


            Table.Controls.Add(new Label() { Text = "Τύπος:", Anchor = AnchorStyles.Left, AutoSize = true }, 1, row);
            Table.Controls.Add(new ComboBox() { Dock = DockStyle.Fill }, 1, row + 1);

            Table.Controls.Add(new Label() { Text = "λλΤύπος:", Anchor = AnchorStyles.Left, AutoSize = true }, 2, row);
            Table.Controls.Add(new TextBox() { Name = "sss", Dock = DockStyle.Fill }, 2, row + 1);

        }
    }
}
