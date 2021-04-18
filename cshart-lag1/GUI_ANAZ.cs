using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FocusedTextBox;
using Excel = Microsoft.Office.Interop.Excel;
// using Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Drawing.Printing;




using System.Collections;








namespace WindowsFormsApplication1
{
    public  partial class   GUI_ANAZ : Form
    {

       
        
        
        public GUI_ANAZ()
        {
            InitializeComponent();
        }

        static bool F_ShowGrid =false ;
        private int linesPrinted=1;
        private string[] lines;

        //private Point controlLocation = new Point(10, 50);
        int statheraMenuItems = 2;

        char[] charSeparators = new char[] { ';' };       
        //// = Split(D, ",")  'Split(TestString)
        string[] query_fields = new string[51];
        ////ο αριθμος των πεδιων αναζητησης
        int nFields;
        ////TextBox
        FocusedTextBox.FocusedTextBox[,] t1 = new FocusedTextBox.FocusedTextBox[31, 3];
        CheckedListBox[,] C1 = new CheckedListBox[31, 3];

        Button[] B1 = new Button[31];
        DataGridView GRIDVIEW1;
        //// το custom menu που πατήθηκε
        //string f_MENUNAME;

        ////= sqlDT.Rows(0)("TSQSELECT")
        string F_SQLSELECT;
        ////= sqlDT.Rows(0)("TSQORDER")
        string F_SQLORDER;

        //Declaration  the  global  variables

        PaperSize paperSize = new PaperSize("papersize", 150, 500);//set the paper size
        int totalnumber = 0;//this is for total number of items of the list or array
        int itemperpage = 0;//this is for no of item per page 
    //    C#
//Copy Code
     //PrintPreview button_click definition 

     private void btnprintpreview_Click(object sender, EventArgs e)

        {

        }

     //   C#
//Copy Code
 //Print button_click definition

 private void bnprint_Click(object sender, EventArgs e)
        {
           
        }
 //       C#
// Shrink ▲   Copy Code
//Define the  Printpage event of the printdocument

 private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float currentY = 10;// declare  one variable for height measurement
            e.Graphics.DrawString("Print in Multiple Pages", DefaultFont, Brushes.Black, 10, currentY);//this will print one heading/title in every page of the document
            currentY += 15;

            while (totalnumber <= 50) // check the number of items
            {
                e.Graphics.DrawString(totalnumber.ToString(), DefaultFont, Brushes.Black, 50, currentY);//print each item
                currentY += 20; // set a gap between every item
                totalnumber += 1; //increment count by 1
                if (itemperpage < 20) // check whether  the number of item(per page) is more than 20 or not
                {
                    itemperpage += 1; // increment itemperpage by 1
                    e.HasMorePages = false; // set the HasMorePages property to false , so that no other page will not be added

                }

                else // if the number of item(per page) is more than 20 then add one page
                {
                    itemperpage = 0; //initiate itemperpage to 0 .
                    e.HasMorePages = true; //e.HasMorePages raised the PrintPage event once per page .
                    return;//It will call PrintPage event again

                }
            }
        }

























        private int f_menuid; // Field declaration
        public int f_MENUID // Property declaration

        {
            get { return this.f_menuid; }
            set { this.f_menuid = value; } // Setter declaration
        }

        private string  f_tablename; // Field declaration
        public string f_TableName // Property declaration
        {
            get { return this.f_tablename; }
            set { this.f_tablename = value; } // Setter declaration
        }



        private string f_menuname; // Field declaration
        public string f_MENUNAME // Property declaration
        {
            get { return this.f_menuname; }
            set { this.f_menuname = value; } // Setter declaration
        }


        //=====================================================================================================
  
 /*     ayto doyleyei kanonika alla den exei check box  
        private void GUI_ANAZ_Load(object sender, EventArgs e)
        {
            //ΧΤΙΖΩ ΤΟ ContextMenuStrip3
            //μαρκάρω το default menu 
            //αποθηκεύω στο  c = sqlDT.Rows(N)("MENUNAME")
            //και σχεδιάζω τα controls αναζήτησης

            if (f_MENUID >= 1)
            {
                DataTable sqlDT=functions.ExecuteSQLQuery("SELECT * FROM NEWMENUS WHERE MENU_ID=" + f_MENUID.ToString());
                int N = 0;
                F_ShowGrid = false;
                string c = "";
                for (N = 0; N <= sqlDT.Rows.Count - 1; N++)
                {
                    ToolStripItem clsItem = ContextMenuStrip3.Items.Add(sqlDT.Rows[N]["MENUNAME"].ToString() );
                    clsItem.Tag = sqlDT.Rows[N]["MENUNAME"].ToString();

                    // AddHandler clsItem.Click, AddressOf CUSTOM_MENU_Click 'openReport
                    clsItem.Click += CUSTOM_MENU_Click;
                    
                    //openReport
                    // if(your value == System.DBNull.Value)
                    if  (!( sqlDT.Rows[N]["MENUDEFAULT"] ==   System.DBNull.Value))
                    {
                        if (sqlDT.Rows[N]["MENUDEFAULT"].ToString()  == true.ToString()  )
                        {
                            c = sqlDT.Rows[N]["MENUNAME"].ToString();
                            f_MENUNAME = c;
                            // το τρέχον μενου
   
                            clsItem.ForeColor = Color.Blue;
                            
                           // ((ToolStripMenuItem)menuItem).Checked = true;
                            ToolStripMenuItem ITM = new  ToolStripMenuItem();
                            //ITM = clsItem.Items[N + statheraMenuItems];
                            // ITM.Checked = true;
                        } 
                    }
                }
                if (c.Length  > 0)
                    draw_where(c);
                F_ShowGrid = true;
            }
        }

 */

        private void GUI_ANAZ_Load(object sender, EventArgs e)
        {



            // Write to richTextBox
            richTextBox1.Text = "                               " +
                DateTime.Now.Month + "/" + DateTime.Now.Day + "/" +
                DateTime.Now.Year + "\r\n\r\n";
            richTextBox1.AppendText("This is a greatly simplified Print " +
                "Document Method\r\n\r\n");
            richTextBox1.AppendText("We can write text to a richTextBox, " +
                "or use Append Text," + "\r\n" + "or Concatenate a String, and " +
                "write that textBox. The " + "\r\n" + "richTextBox does not " +
                "even have to be visible. " + "\r\n\r\n" + "Because we use a " +
                "richTextBox it's physical dimensions are " + "\r\n" +
                "irrelevant. We can place it anywhere on our form, and set the " +
                "\r\n" + "Visible Property to false.\r\n\r\n");
            richTextBox1.AppendText("This is the document we will print. The " +
                "rich TextBox serves " + "\r\n" + "as a Cache for our Report, " +
                "or any other text we wish to print.\r\n\r\n");
            richTextBox1.AppendText("I have also included Print Setup " +
                "and Print Preview. ");






            //   ΧΤΙΖΩ ΤΟ ContextMenuStrip3
            //   μαρκάρω το default menu 
            //   αποθηκεύω στο  c = sqlDT.Rows(N)("MENUNAME")
            //   και σχεδιάζω τα controls αναζήτησης
            if (f_MENUID >= 1)
            {



                ToolStripMenuItem[] items = new ToolStripMenuItem[50];  //  ("Exit");


                DataTable sqlDT = functions.ExecuteSQLQuery("SELECT * FROM NEWMENUS WHERE  MENU_ID=" + f_MENUID.ToString());
                int N = 0;
                F_ShowGrid = false;
                string c = "";
                for (N = 0; N <= sqlDT.Rows.Count - 1; N++)
                {

                   
                    items[N] = new ToolStripMenuItem();
                    items[N].Name = "dynamicItem" + N.ToString();
                    items[N].Tag = sqlDT.Rows[N]["MENUNAME"].ToString();
                    items[N].Text = sqlDT.Rows[N]["MENUNAME"].ToString();

                    ContextMenuStrip3.Items.Add(items[N]);

                    items[N].Click += new EventHandler(CUSTOM_MENU_Click);

                

                    //  clsItem.Tag = sqlDT.Rows[N]["MENUNAME"].ToString();
                    //  clsItem.Click += CUSTOM_MENU_Click;
                    if (!(sqlDT.Rows[N]["MENUDEFAULT"] == System.DBNull.Value))
                    {
                        if (sqlDT.Rows[N]["MENUDEFAULT"].ToString() == true.ToString())
                        {
                            c = sqlDT.Rows[N]["MENUNAME"].ToString();
                            f_MENUNAME = c;
                             items[N].ForeColor = Color.Blue;
                             items[N].CheckState = CheckState.Checked;
                        }
                    }
                
                
                }



                if (c.Length > 0)
                    draw_where(c);
                F_ShowGrid = true;
            }
        }







        
  /*      
        // Create high level menu container
    MenuStrip strip = new MenuStrip();
               //  Create a top level menu item called "File" with "F" being the access key (Alt + f)
    ToolStripMenuItem fileItem = new ToolStripMenuItem("&File");
    // Create one sub menu item on this menu
    fileItem.DropDownItems.Add("First Menu Item");
    // Add the high level menu item to the menu container
    strip.Items.Add(fileItem);
   // Add menu to form
    this.Controls.Add(strip);
*/



                private void CUSTOM_MENU_Click(object sender, EventArgs e)
                {
                    //πατηθηκε κάποιο custom Menu
                    //το όνομα του μενού ειναι :
                    //CType(sender, ContextMenuStrip).Tag.ToString
                    // 
                    if (sender is ToolStripItem)
                    {
                        string c = ((ToolStripItem)sender).Tag.ToString();

                        //KRYBO TO PANEL TOY DATAGRIDVIEW1
                        // Panel3.Location = New Point(11, 251)

                        f_MENUNAME = c;
                        draw_where(c);
                    }
                }






        //public void openReport(System.Object Sender, System.EventArgs e)
        //{
        //    string sReportPath = ((ToolStripItem)Sender).Tag.ToString();
        //    MessageBox.Show(sReportPath);
        //}
      
        //// AFOI KOTSANH IKE  / YP.ENOIK.DOM-ETH.AMYNHS 31 DRAMA-8554373-DRAMAS


                private void draw_where(string c)
                {
                    //ΖΩΓΡΑΦΙΖΩ ΤΑ ΚΟΥΤΑΚΙΑ ΤΗΣ ΑΝΑΖΗΤΗΣΗΣ

                    Panel1.Visible = false;
                    //ΚΑΘΑΡΙΖΩ ΤΟ PANEL
                    Panel1.Controls.Clear();
                    Panel1.Visible = true;


                  DataTable   sqlDT=functions.ExecuteSQLQuery("select * from NEWMENUS WHERE MENU_ID=" + f_MENUID.ToString() + " AND MENUNAME='" + c + "'");
                    string D = null;
                    //ΖΩΓΡΑΦΙΖΩ ΤΗΝ ΑΝΑΖΗΤΗΣΗ
                    D = sqlDT.Rows[0]["TSQLWHERE"].ToString ();
                    string CC = null;
                    int Y = 12;
                    
                    string[] TestArray = D.Split(charSeparators, StringSplitOptions.None);
                    //Split(TestString)
                    int LastNonEmpty = 0; // -1;
                    for (int i = 0; i <= TestArray.Length - 1; i++)
                    {
                        if (!string.IsNullOrEmpty(TestArray[i]))
                        {
                            LastNonEmpty += 1;
                              nFields = LastNonEmpty;
                            CC = TestArray[i];
                             query_fields[i] = TestArray[i].ToString();
                            if (query_fields[i].Substring ( 220, 1) == "B")
                            {
                                ADD_COMBOBOX(Y, CC, i, 0, 1, query_fields[i].Substring( 230, 100).Trim() );
                            }
                            if (query_fields[i].Substring( 220, 1) == "C")
                            {
                                ADD_LABELTEXT(Y, CC, i, 0, 1);
                            }
                            if (query_fields[i].Substring( 220, 1) == "N")
                            {
                                ADD_LABELTEXT(Y, CC, i, 0, 1);
                                ADD_LABELTEXT(Y, CC, i, 400, 2);
                            }
                            Y = Y + 30;
                        }
                    }

                   
                    // ΜΑΖΕΥΩ ΤΟ SELECT & ORDER
                    F_SQLSELECT = sqlDT.Rows[0]["SQL1"].ToString ();
                    F_SQLORDER = sqlDT.Rows[0]["SQL2"].ToString ();
                }




        private void GUI_ANAZ_Resize_1(object sender, EventArgs e)
        {
            Panel1.Width = this.Width;
            Panel1.Width = this.Width;
            Panel2.Width = this.Width;
            Panel1.Height = this.Height - Panel2.Height;
            int N = 0;
            for (N = 0; N <= Panel1.Controls.Count - 1; N++)
            {
                if (Panel1.Controls[N].Name == "GRIDVIEW1")
                {
                    GRIDVIEW1.Width = Panel1.Width;
                    GRIDVIEW1.Height = Panel1.Height;
                }
            }





        }



        //private void Button1_ContextMenuStripChanged(object sender, System.EventArgs e)
        //{
        //    int a = 0;
        //    a = 1;
        //}



       





        public void ADD_COMBOBOX(int Y, string C, int N, int LEFTLOC, int STHLH, string comboQuery)
        {
            //FIRSTCOL =1 ΠΡΩΤΗ ΣΤΗΛΗ  //// STHLH=2 ΔΕΥΤΕΡΗ ΣΤΗΛΗ 

            //TextBox() 232,56   W227,H20
            //BUT() 459,55  W13,21
            //ListBox() 232,80   W227,94

            Label L1 = new Label();
            //LEFTLOC =160
            //ΕΠΩΝΥΜΟ                                                                                                                                                                                                 EPO                 C"
            L1.Text = C.Substring( 1, 200).Trim() ;
            L1.Name = "L1";
            L1.Location = new Point(LEFTLOC, Y);
            //64, 13) 'controlLocation.X + 50, controlLocation.Y)
            L1.Size = new Size(64, 13);
            Panel1.Controls.Add(L1);


            t1[N, STHLH] = new FocusedTextBox.FocusedTextBox();
            //TextBox
            t1[N, STHLH].Text = "";
            //+ Str(controlCount)
            t1[N, STHLH].Name = (C.Substring ( 201, 20).Trim ());
            //"T1"
            t1[N, STHLH].Location = new Point(LEFTLOC + 130, Y - 3);
            //controlLocation.X + 350, controlLocation.Y)
            t1[N, STHLH].Size = new Size(200, 20);
            //T1.Height)
            // Add the TextBox to the controls collection.
            Panel1.Controls.Add(t1[N, STHLH]);




            B1[N] = new Button();
            B1[N].Text = N.ToString ();
            B1[N].Name = ("L" + C).Substring( 201, 20).Trim();
            B1[N].Location = new Point(LEFTLOC + 330, Y - 3);
            //controlLocation.X + 350, controlLocation.Y)
            B1[N].Size = new Size(13, 21);
            //T1.Height)
            B1[N].Tag = N.ToString();

            // Add the TextBox to the controls collection.
            Panel1.Controls.Add(B1[N]);

            //If F_FIRST = 1 Then
            //    Me.Controls.Add(btn(k))
            B1[N].Click += AllButtons_Click;
            //    AddHandler btn(k).MouseMove, AddressOf AllButtons_mousemove
            //End If




            //LEFTLOC = 400

            C1[N, STHLH] = new CheckedListBox();
            C1[N, STHLH].Text = "";
            //+ Str(controlCount)
            C1[N, STHLH].Name = (("L" + C).Substring( 201, 20).Trim());
            //"T1"

            C1[N, STHLH].Location = new Point(LEFTLOC + 130, 24 + Y - 3);
            //controlLocation.X + 350, controlLocation.Y)
            C1[N, STHLH].Size = new Size(200, 94);
            //T1.Height)

            // Add the TextBox to the controls collection.
            Panel1.Controls.Add(C1[N, STHLH]);

            //"SELECT PERIGRAFH,ID FROM PINAKES"

            functions.FillCheckedListBox(comboQuery, C1[N, STHLH]);
            C1[N, STHLH].Visible = false;
        }


        //static void FillCheckedListBox(string sql, CheckedListBox cb)  // , ref Array ids)
        //{
        //    DataTable dt = functions.ExecuteSQLQuery(sql);
        //    cb.Items.Clear();
        //    try
        //    {
        //     for (int k=0;k<=dt.Rows.Count-1;k++)
        //        {
        //            cb.Items.Add(dt.Rows[k]["PERIGRAFH"].ToString());
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //      //
        //    }
        //    finally
        //    {
        //      //
        //    }
        //}





        // AllButtons_Click is a sub I created, note that it doesn't have a "handles" statement at the end
        // ΠΑΤΑΩ ΤΟ Button ΚΑΙ ΑΠΛΩΝΕΙ ΤΟ CHECKEDLISTBOX  (C1[System.Convert.ToInt32(TempButton.Tag), 1].    )
        // ΠΑΤΑΩ ΤΟ Button ΚΑΙ MAZEYEI ΤΟ CHECKEDLISTBOX
        private void AllButtons_Click(System.Object sender, System.EventArgs e)
        {
            Button TempButton = default(Button);
            TempButton = (Button)sender;
            int ii = System.Convert.ToInt32(TempButton.Tag);  // για να καταλάβω σε ποιά σειρά είμαι


            if (C1[ii, 1].Visible == false)
                C1[ii, 1].Visible = true;
            else
            {

                
                // μαζεύω τις επιλογές που έχουν γίνει στο textbox
                int kk;
                string ss = "";
                foreach (object itemChecked in C1[ii, 1].CheckedItems)
                {

                    ss = ss + itemChecked.ToString();
                    // Use the IndexOf method to get the index of an item.
                   // MessageBox.Show("Στοιχείο  with title: \"" + itemChecked.ToString() +
                     //               "\", is checked. Checked state is: " +
                       //             checkedListBox1.GetItemCheckState(checkedListBox1.Items.IndexOf(itemChecked)).ToString() + ".");
                }
                t1[ii, 1].Text  = ss;
                // t1[N, STHLH].Text = ss;
                MessageBox.Show(ss);


                //for (kk = 0; kk < C1[System.Convert.ToInt32(TempButton.Tag), 1].Items.Count - 1; kk++)
                //{
                   
                //    // if (C1[System.Convert.ToInt32(TempButton.Tag), 1].Items[kk]
                //}   

                C1[ii, 1].Visible = false;
            }
        
        }


        private void ADD_LABELTEXT(int Y, string C, int N, int LEFTLOC, int STHLH)
        {
            //FIRSTCOL =1 ΠΡΩΤΗ ΣΤΗΛΗ  //// STHLH=2 ΔΕΥΤΕΡΗ ΣΤΗΛΗ 
            Label L1 = new Label();
            //LEFTLOC =160
            //ΕΠΩΝΥΜΟ                                                                                                                                                                                                 EPO                 C"
            L1.Text = (C.Substring( 0, 200).Trim());
            L1.Name = "L1";



            L1.Location = new Point(LEFTLOC, Y);
            L1.Size = new Size(64, 14);
            Panel1.Controls.Add(L1);
            t1[N, STHLH] = new FocusedTextBox.FocusedTextBox();
            t1[N, STHLH].Text = "";
            t1[N, STHLH].EnterFocusColor = Color.Yellow;
            t1[N, STHLH].Name = (C.Substring(201, 20).Trim());
            t1[N, STHLH].Location = new Point(LEFTLOC + 130, Y - 3);
            t1[N, STHLH].Size = new Size(200, 350);
            Panel1.Controls.Add(t1[N, STHLH]);

        }
      
       
       
        private void paint_ergasies(string SQLqry)

        {
           DataTable MDS = new System.Data.DataTable();
           try
            {
                GRIDVIEW1.ClearSelection();
                MDS=functions.ExecuteSQLQuery(SQLqry);
                GRIDVIEW1.DataSource = MDS;
                
                int LL = 0;
                LL = GRIDVIEW1.ColumnCount;
                int FARDOS = 0;
                FARDOS = 0;
                int J = 0;
                for (J = 0; J <= LL - 2; J++)
                {
                    FARDOS = FARDOS + GRIDVIEW1.Columns[J].Width;
                }
                if (LL > 2)
                {
                    GRIDVIEW1.Columns[LL - 1].Width = GRIDVIEW1.Width-FARDOS + 500;
                }
                // GRIDVIEW1.DataSource = MDS;


                StretchLastColumn(GRIDVIEW1);

                GRIDVIEW1.Refresh();




                //GridView1.Refresh()
            }
            catch //(SqlException ex)
            {
                MessageBox.Show("--");
            }
            finally
            {
                // Close connection
                // conn.Close()
            }
        }

         
        //------------------------------------------------------

         private void ANAZHTHSH_Click(object sender, EventArgs e)
        
        {
            string sql = null;
            
            //ΕΑΝ ΕΙΝΑΙ ΑΠΛΩΜΕΝΟ ΤΟ DATAGRIDVIEW1 DEIXNEI TA TEXTBOXES ΓΙΑ ΑΝΑΖΗΤΗΣΗ
            //If Panel3.Location.Y = 51 Then
            if (F_ShowGrid == false)
            {
                 draw_where(f_MENUNAME);
                F_ShowGrid = true;
                return;
            }
            //GridView1.Visible = True
            F_ShowGrid = false;
            //flag
            Panel1.Controls.Clear();

            GRIDVIEW1 = new DataGridView();
            GRIDVIEW1.Name = "GRIDVIEW1";
            GRIDVIEW1.Location = new Point(0, 0);
            GRIDVIEW1.Size = new Size(100, 300);
            Panel1.Controls.Add(GRIDVIEW1);


            GRIDVIEW1.Click += new EventHandler(GRIDVIEW1click);


            sql = F_SQLSELECT;
            string where_query = "";
            int energa = 0;
            int n;
            //-----------------------------------------------------------------------------------
            for (n = 0; n <= nFields-1; n++)
            {
                //
                if (query_fields[n].Substring( 220, 1) == "C" & t1[n, 1].Text.Trim().Length> 0)
                {
                    string mFIELD = query_fields[n].Substring( 200, 19).Trim();
                    energa = energa + 1;
                    where_query = where_query + (energa == 1 ? "" : " and ") + mFIELD + " like '" + t1[n, 1].Text + "%'";
                }
            
                
                //
                if (query_fields[n].Substring( 220, 1) == "N" & t1[n, 1].Text.Trim().Length  > 0)
                {
                    string mFIELD = query_fields[n].Substring( 200, 19).Trim();
                    energa = energa + 1;
                    where_query = where_query + (energa == 1 ? "" : " and ")  + mFIELD;
                    where_query = where_query + ">=" + (t1[n, 1].Text.Trim().Length  == 0 ? "0" : t1[n, 1].Text);
                    where_query = where_query + " AND " + mFIELD + "<=0" + ( t1[n, 2].Text.Trim().Length == 0 ? "0" : t1[n, 2].Text);
                }
                //
                if (query_fields[n].Substring( 220, 1) == "B" & t1[n, 1].Text.Trim().Length > 0)
                {
                    string mFIELD = query_fields[n].Substring(200, 19).Trim();
                    energa = energa + 1;
                    where_query = where_query + (energa == 1 ? "" : " and ") + mFIELD + " in ('" + t1[n, 1].Text + "') ";
                }
            }

            if (where_query.Trim().Length  > 0)
            {
                sql = sql + " where " + where_query + " " + F_SQLORDER;
            }
            else
            {
                sql = sql + " " + F_SQLORDER;
            }

            Panel1.Visible = false;
            //Panel1.Location = New Point(7, 66)
            Panel1.Location = new Point(0, 44);
            Panel1.Visible = true;
            GRIDVIEW1.Visible = true;
            // Panel3.Location = New Point(11, 51)
            GRIDVIEW1.Width = Panel1.Width;
            GRIDVIEW1.Height = Panel1.Height;

            var _with1 = this.GRIDVIEW1;
            _with1.RowsDefaultCellStyle.BackColor = Color.Bisque;
            _with1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;


            // Resize the master DataGridView columns to fit the newly loaded data.
            GRIDVIEW1.AutoResizeColumns();


            // Configure the details DataGridView so that its columns automatically 
            // adjust their widths when the data changes.
            GRIDVIEW1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; 
          paint_ergasies(sql);
        }


         public void GRIDVIEW1click(object sender, EventArgs e)
         {
      

            // 'ΠΙΑΝΩ ΤΟ ID ΤΗΣ ΤΡΕΧΟΥΣΑΣ ΕΓΓΡΑΦΗΣ//
             string C = GRIDVIEW1.CurrentRow.Cells[0].Value.ToString();
            //   '  GDB.Execute("update PATIENTDETAIL SET PATIENT_ID=0")
             //f_MENUNAME
             if (functions.IsNumeric(C) )  // C == "") { } else
             {
             editing ChildForm = new editing();
             ChildForm.MdiParent =MdiParent;
             ChildForm.f_MENUNAME = f_MENUNAME;
             ChildForm.f_TableName = f_TableName;
             ChildForm.f_ID = Convert.ToInt16  (C);
             ChildForm.Text = GRIDVIEW1.CurrentRow.Cells[1].Value.ToString();
             ChildForm.Show();
              }
         }


 
         public void StretchLastColumn(DataGridView dataGridView)
         {
             int lastColIndex = dataGridView.Columns.Count - 1;
             dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
             dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
             dataGridView.Columns[lastColIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

         }

        private void ΣχεδίασηToolStripMenuItem_Click_1(object sender, EventArgs e)
            //======================================================================================================
        {
            //allagh sxediashw

            //1 arxikh sxediash me adeia listboxes
            QUERY_SETUP ChildForm = new QUERY_SETUP();
            //System.Windows.Forms.Form
            
            
            // Make it a child of this MDI form before showing it.
            //  ChildForm.MdiParent = ff;
            ChildForm.Text = "Ρύθμιση Εκτύπωσης ";
            
            DataTable dt=functions.ExecuteSQLQuery("select * from TABLEFIELDS WHERE TABLENAME='"+f_TableName+"' and  NOT (FIELDDESCRIPTION is NULL)");
            int n = 0;
            string c = null;
             for (n = 0; n <= dt.Rows.Count - 1; n++)
            {

                 string c1=new string(' ', 200);
                c = (dt.Rows[n]["FIELDDESCRIPTION"].ToString()+c1).Substring(0, 200);

                string c2 =new  string(' ', 20);
                c = c + (dt.Rows[n]["FIELDNAME"].ToString()+c2).Substring(0, 20);

                 c = c + dt.Rows[n]["FIELDTYPE"].ToString().Substring( 0, 1);
                ChildForm.LFields.Items.Add(c);
            }

            //2. listboxes select , where k.l.p.
            DataTable sqlDT=functions.ExecuteSQLQuery("SELECT * FROM NEWMENUS WHERE MENUNAME='" + f_MENUNAME + "' and MENU_ID=" + f_MENUID.ToString() );
            string MENUID =sqlDT.Rows[0]["MENU_ID"].ToString ();
            
            c = sqlDT.Rows[0]["TSQLSELECT"].ToString ();

            string[] TestArray = c.Split(charSeparators, StringSplitOptions.None);
            //Split(TestString)
            for (int i = 0; i <= TestArray.Length - 1; i++)
            {
                if (!string.IsNullOrEmpty(TestArray[i]))
                {
                    ChildForm.LSelect.Items.Add(TestArray[i]);
                }
            }

            //WHERE
            c = sqlDT.Rows[0]["TSQLWHERE"].ToString ();
            string[] TestArray2 = c.Split(charSeparators, StringSplitOptions.None);
            //Split(TestString)
            for (int i = 0; i <= TestArray2.Length - 1; i++)
            {
                if (!string.IsNullOrEmpty(TestArray2[i]))
                {
                    ChildForm.LSearch.Items.Add(TestArray2[i]);
                }
            }

            // ORDER
            c = sqlDT.Rows[0]["TSQLORDER"].ToString ();
            string[] TestArray3 = c.Split(charSeparators, StringSplitOptions.None);
            //Split(TestString)
            for (int i = 0; i <= TestArray3.Length - 1; i++)
            {
                if (!string.IsNullOrEmpty(TestArray3[i]))
                {
                    ChildForm.LOrder.Items.Add(TestArray3[i]);
                }
            }


            //f_MENUNAME
            ChildForm.f_MENUNAME = f_MENUNAME;
            ChildForm.f_TableName = f_TableName;
           // ChildForm.Text=GRIDVIEW1.CurrentRow.Cells[1].Value.ToString();
            ChildForm.f_MENUID = System.Convert.ToInt32(MENUID);
            ChildForm.MdiParent = MdiParent;
            ChildForm.Show();
        }

        private void Button1_Click(System.Object sender, System.EventArgs e)
        {
            // Cx1.Items.Add("aaaaaa", True)

        }

        private void ANAZHTHSH_MouseUp_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //do something here
                ContextMenuStrip3.Show(ANAZHTHSH, 0, ANAZHTHSH.Height);
                
            }
            else//left or middle click
            {
                //do something here
            }
        }

        private void ΠροεπιλογToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           //ΚΑΝΩ ΟΛΑ ΤΑ ΜΕΝOY MENUDEFAULT=0 GIA NA EXO MONO ENA DEFAULT
            DataTable sqlDT = functions.ExecuteSQLQuery("update NEWMENUS set MENUDEFAULT=0 WHERE  MENU_ID=" + f_MENUID.ToString());

            DataTable sql2DT = functions.ExecuteSQLQuery("update NEWMENUS set MENUDEFAULT=1 WHERE  MENU_ID=" + f_MENUID.ToString() + " AND  MENUNAME='" + f_MENUNAME + "'");
        }

        private void button2_Click(object sender, EventArgs e)
        {

           


           // Excel.Application xlApp;
           // Excel.Workbook xlWorkBook;
           // Excel.Worksheet xlWorkSheet;
           // object misValue = System.Reflection.Missing.Value;

           // xlApp = new Excel.Application();
           // // xlWorkBook = xlApp.Workbooks.add;// Open("c:\ektyp.xls", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
           //// xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

           // MessageBox.Show(xlWorkSheet.get_Range("A1", "A1").Value2.ToString());

           // xlWorkBook.Close(true, misValue, misValue);
           // xlApp.Quit();

            //releaseObject(xlWorkSheet);
            //releaseObject(xlWorkBook);
            //releaseObject(xlApp);





            Excel.Application objexcel;
            Excel.Workbook wbexcel;
           
            Excel.Worksheet objsht;
            objsht= new Excel.Worksheet();

            Excel.Range objrange;

            objexcel = new Excel.Application();
            string[] query_fields = new string[51];

            
            
            
            // OK ANOIGEI EXCEL C:\EKTYP.XLS 
               // wbexcel = objexcel.Workbooks.Open("c:\\ektyp.xls", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);

           
            //ok dhmioyrgei neo excel
            wbexcel = objexcel.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);

            //objsht = wbexcel.ActiveSheet;
            objsht = (Excel.Worksheet)wbexcel.Worksheets.get_Item(1);

            
            // Microsoft.Office.Interop.Excel.Worksheet[] WS=new Microsoft.Office.Interop.Excel.Worksheet[30];
            objsht.Cells[1, 1] = 3454;


            // Excel.Sheets excelSheets = wbexcel.Worksheets;
            
            //if (Directory("C:\\csharp\\error report1.xls") = "")
            //{
            //   wbexcel.NewSheet();
            //}

            //else
            //{
            //    wbexcel.Open("C:\\csharp\\error report1.xls");
            //     objsht = ("sheet1");
            //}

            objexcel.Visible=true;
              
            






        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();  // αν δεν υπαρχει ο εκτυπωτης βγαζει rpc error
            }
          

        }

        private void OnBeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           
            
        }

        static int pageNum;
        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {

            
            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;
            Brush brush = new SolidBrush(richTextBox1.ForeColor);

            e.Graphics.DrawString("Page : "+(pageNum + 1).ToString(),
                   richTextBox1.Font, brush, 700, 1050) ;

            pageNum++;
            while (linesPrinted < lines.Length)
            {
                e.Graphics.DrawString(lines[linesPrinted++],
                    richTextBox1.Font, brush, x, y);
                y += 185;
                if (y >= e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            linesPrinted = 0;
            e.HasMorePages = false;
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            char[] param = { '\n' };

            if (printDialog1.PrinterSettings.PrintRange == PrintRange.Selection)
            {
                lines = richTextBox1.SelectedText.Split(param);
            }
            else
            {
                lines = richTextBox1.Text.Split(param);
            }

            int i = 0;
            char[] trimParam = { '\r' };
            foreach (string s in lines)
            {
                lines[i++] = s.TrimEnd(trimParam);
            }   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}

