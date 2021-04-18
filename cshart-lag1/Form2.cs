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
    public partial class Form2 : Form
    {
        private int age; // Field declaration
        public int Age // Property declaration
        {
            get { return this.age; }
            set { this.age = value; } // Setter declaration
        }
        
        
        
        public Form2()
        {
            InitializeComponent();
        }





       // Declare the ContextMenuStrip control. 
    private ContextMenuStrip FFFFF;

   

    public void menus()
    {
        // Create a new ContextMenuStrip control.
        FFFFF = new ContextMenuStrip();

        // Attach an event handler for the  
        // ContextMenuStrip control's Opening event.
        FFFFF.Opening += new System.ComponentModel.CancelEventHandler(cms_Opening);



        /*
        // Create a new ToolStrip control.
        ToolStrip ts = new ToolStrip();

        // Create a ToolStripDropDownButton control and add it 
        // to the ToolStrip control's Items collections.
        ToolStripDropDownButton fruitToolStripDropDownButton = new ToolStripDropDownButton("φρουτα", null, null, "ΦΡΟΥΤΑt");
        ts.Items.Add(fruitToolStripDropDownButton);

        // Dock the ToolStrip control to the top of the form.
        ts.Dock = DockStyle.Top;
        */


        // Assign the ContextMenuStrip control as the  
        // ToolStripDropDownButton control's DropDown menu.
       // fruitToolStripDropDownButton.DropDown = FFFFF;

        // Create a new MenuStrip control and add a ToolStripMenuItem.
     //   MenuStrip ms = new MenuStrip();
       
  

        // ToolStripMenuItem fruitToolStripMenuItem = new ToolStripMenuItem("φρουτακια", null, null, "φρ");
        // ms.Items.Add(fruitToolStripMenuItem);

        //// Dock the MenuStrip control to the top of the form.
        //ms.Dock = DockStyle.Top;

        // Assign the MenuStrip control as the  
        // ToolStripMenuItem's DropDown menu.
       // fruitToolStripMenuItem.DropDown = FFFFF;

        // Assign the ContextMenuStrip to the form's  
        // ContextMenuStrip property. 
        //  this.ContextMenuStrip = FFFFF;
        button1.ContextMenuStrip = FFFFF;
        // Add the ToolStrip control to the Controls collection. 
     //    this.Controls.Add(ts);

         return;

/*
        //Add a Button to the form and assign its ContextMenuStrip.
        Button b = new Button();
        b.Location = new System.Drawing.Point(60, 60);
        this.Controls.Add(b);

        b.ContextMenuStrip = FFFFF;




        // Add the MenuStrip control last. 
        // This is important for correct placement in the z-order. 
        this.Controls.Add(ms);

        
        */
    }



    // This event handler is invoked when the ContextMenuStrip 
    // control's Opening event is raised. It demonstrates 
    // dynamic item addition and dynamic SourceControl  
    // determination with reuse. 
    void cms_Opening(object sender, System.ComponentModel.CancelEventArgs e)
    {
        // Acquire references to the owning control and item.
        Control c = FFFFF.SourceControl as Control;
        ToolStripDropDownItem tsi = FFFFF.OwnerItem as ToolStripDropDownItem;

        // Clear the ContextMenuStrip control's Items collection.
        FFFFF.Items.Clear();

        // Check the source control first. 
        if (c != null)
        {
            // Add custom item (Form)
            FFFFF.Items.Add("Πηγή: " + c.GetType().ToString());
        }
        else if (tsi != null)
        {
            // Add custom item (ToolStripDropDownButton or ToolStripMenuItem)
            FFFFF.Items.Add("Source: " + tsi.GetType().ToString());
        }

        // Populate the ContextMenuStrip control with its default items.
        FFFFF.Items.Add("-");
        FFFFF.Items.Add("Apples");
        FFFFF.Items.Add("Oranges");
        FFFFF.Items.Add("Pears");
        

        

        // Set Cancel to false.  
        // It is optimized to true based on empty entry.
        e.Cancel = false;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        menus();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        CreateContextMenu();
    }



/*    ok 
        private void CreateContextMenu()
{
     ContextMenuStrip menuStrip = new ContextMenuStrip();
     
     ToolStripMenuItem menuItem = new ToolStripMenuItem("Exit");
     menuItem.Click += new EventHandler(menuItem_Click);
     menuItem.Name = "Exit";
     
      menuStrip.Items.Add(menuItem);


      ToolStripMenuItem menu2Item = new ToolStripMenuItem("ffffff");
     // menu2Item.Click += new EventHandler(menuItem_Click);
      menu2Item.Name = "2Exit";
      menu2Item.Tag = 123;

            menu2Item.Checked = true;
            menu2Item.CheckState = CheckState.Checked;

      menuStrip.Items.Add(menu2Item);








     this.ContextMenuStrip = menuStrip;
}

void menuItem_Click(object sender, EventArgs e)
{
     ToolStripItem menuItem = (ToolStripItem)sender;
     if (menuItem.Name == "Exit")
     {
          Application.Exit();
     }
}

*/


    private void CreateContextMenu()
    {
        ContextMenuStrip menuStrip = new ContextMenuStrip();

       ToolStripMenuItem[] items =new ToolStripMenuItem[9];  //  ("Exit");


        for (int i = 0; i < items.Length; i++)
        {
            items[i] = new ToolStripMenuItem();
            items[i].Name = "dynamicItem" + i.ToString();
            items[i].Tag = i.ToString();
            items[i].Text = "Visib "+ i.ToString();

            menuStrip.Items.Add(items[i]);
            items[i].Click += new EventHandler(menuItem_Click);

        }
       // menuItem.Click += new EventHandler(menuItem_Click);
      //  menuItem.Name = "Exit";
       
        this.ContextMenuStrip = menuStrip;
    }

    void menuItem_Click(object sender, EventArgs e)
    {
        ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
        button1.Text = menuItem.Tag.ToString ();
        
        if (menuItem.Tag.ToString() == "1")
        {
            Application.Exit();
        }
    }






















        //================================================================================
    //   The way I do it is to create an array of ToolStripMenuItems and populate
    //    that array with the items I'm adding. I create one method to handle the click events 
    //    and have it check something unique about each item I create at run-time. 
    //        You might try using the Name or Tag properties of each ToolStripMenuItem. 
    //    Then use AddRange on the spot in the menu you're adding to. 
    //    So your code might look something like this:

private void BuildMenuItems()
{

        ContextMenuStrip menuStrip = new ContextMenuStrip();


    ToolStripMenuItem[] items = new ToolStripMenuItem[2]; // You would obviously calculate this value at runtime
    for (int i = 0; i < items.Length; i++)
    {
        items[i] = new ToolStripMenuItem();
        items[i].Name = "dynamicItem" + i.ToString();
        items[i].Tag = "specialDataHere";
        items[i].Text = "Visible Menu Text Here";    
        items[i].Click += new EventHandler(MenuItemClickHandler);
    }

   // myMenu.DropDownItems.AddRange(items);
}

private void MenuItemClickHandler(object sender, EventArgs e)
{
    ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
    // Take some action based on the data in clickedItem
}

private void button3_Click(object sender, EventArgs e)
{
    TableLayoutPanel Table = new TableLayoutPanel();
    Table.Location = new Point(10, 40);
    Table.Size = new Size(620, 100);
    Table.AutoSize = true;
    Table.Name = "Desk";
    Table.ColumnCount = 4;
    Table.RowCount = 0;
    Table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
    Table.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddRows;
    this.Controls.Add(Table);
    int row = 0;

    Table.Controls.Add(new Label() { Text = "Ετικέττα:", Anchor = AnchorStyles.Left, AutoSize = true }, 0, row);
    Table.Controls.Add(new ComboBox() {Width=300, Dock = DockStyle.Fill }, 0, row+1);


    Table.Controls.Add(new Label() { Text = "Τύπος:", Anchor = AnchorStyles.Left, AutoSize = true }, 1, row);
    Table.Controls.Add(new ComboBox() { Dock = DockStyle.Fill }, 1, row+1);

    Table.Controls.Add(new Label() { Text = "λλΤύπος:", Anchor = AnchorStyles.Left, AutoSize = true }, 2, row);
    Table.Controls.Add(new TextBox () { Name="sss",Dock = DockStyle.Fill }, 2, row+1);



    row++;

    row++;

    Table.Controls.Add(new Label() { Text = "Ετικέττα:", Anchor = AnchorStyles.Left, AutoSize = true }, 0, row);
    Table.Controls.Add(new ComboBox() { Dock = DockStyle.Fill }, 0, row + 1);


    Table.Controls.Add(new Label() { Text = "Τύπος:", Anchor = AnchorStyles.Left, AutoSize = true }, 1, row);
    Table.Controls.Add(new ComboBox() { Dock = DockStyle.Fill }, 1, row + 1);

    Table.Controls.Add(new Label() { Text = "λλΤύπος:", Anchor = AnchorStyles.Left, AutoSize = true }, 2, row);
    Table.Controls.Add(new TextBox() { Name = "sss", Dock = DockStyle.Fill }, 2, row + 1);




}



private void addtextbox(int x, int j)
{
    int rowIndex = AddTableRow();
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));

    Label lbl = new Label();
    lbl.Text  = "Κωδικός";

    TextBox Text1 = new TextBox();




    Label lbl2 = new Label();
    lbl2.Text  = "Περιγραφή";

    TextBox Text2 = new TextBox();

    Label lbl3 = new Label();
    lbl3.Text = "Περιγραφή";

    TextBox Text3 = new TextBox();

    Label lbl4 = new Label();
    TextBox Text4 = new TextBox();
    lbl.Text = rowIndex.ToString();
    tableLayoutPanel1.Controls.Add(lbl, 0, rowIndex);
    tableLayoutPanel1.Controls.Add(Text1, 1, rowIndex);


    tableLayoutPanel1.Controls.Add(lbl2, 2, rowIndex);
    tableLayoutPanel1.Controls.Add(Text2, 3, rowIndex);

    tableLayoutPanel1.Controls.Add(lbl3, 4, rowIndex);
    tableLayoutPanel1.Controls.Add(Text3, 5, rowIndex);

    //tableLayoutPanel1.Controls.Add(lbl, 0, rowIndex);
    //tableLayoutPanel1.Controls.Add(Text4, 4, rowIndex);
    //MessageBox.Show(tableLayoutPanel1.Controls. );

}
private int AddTableRow()
{
    int index = this.tableLayoutPanel1.RowCount++;
    RowStyle style = new RowStyle(SizeType.AutoSize);
    tableLayoutPanel1.RowStyles.Add(style);
    //detailTable.RowStyles.Add(style);
    return index;
}

private void button4_Click(object sender, EventArgs e)
{
    addtextbox(1,1);
}









    }

   
}
