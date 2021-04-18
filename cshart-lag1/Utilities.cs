using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Utilities : Form
    {
        public Utilities()
        {
            InitializeComponent();
        }

        private void SQL_Click(object sender, EventArgs e)
        {
            
//OleDbConnection conn = new OleDbConnection();
//conn.ConnectionString = gConnect;
//conn.Open();


            DataTable dt = functions.ExecuteSQLQuery(TextBox1.Text);

            DataGridView1.ClearSelection();
            DataGridView1.DataSource = dt;

//    DataGridView1.ClearSelection();
//    DataGridView1.DataSource = ds;
//    DataGridView1.DataMember = "PEL";

//    //GridView1.Columns(STHLHTOY_ID).Width = 0
//    // DataGridView1.Columns(STHLHTOY_ID).Visible = False

//} catch (SqlException ex) {
//    Interaction.MsgBox(ex.ToString);
//} finally {
//    // Close connection
//    conn.Close();

      }

        private void button1_Click(object sender, EventArgs e)
        {
         //   private void WhatIsChecked_Click(object sender, System.EventArgs e) {
    // Display in a message box all the items that are checked. 

    // First show the index and check state of all selected items. 
    foreach(int indexChecked in checkedListBox1.CheckedIndices)
    {
        // The indexChecked variable contains the index of the item.
        MessageBox.Show("Index#: " + indexChecked.ToString() + ", is checked. Checked state is:" +
                        checkedListBox1.GetItemCheckState(indexChecked).ToString() + ".");
    }

    // Next show the object title and check state for each item selected. 
    foreach(object itemChecked in checkedListBox1.CheckedItems)
    {

        // Use the IndexOf method to get the index of an item.
        MessageBox.Show("Στοιχείο  with title: \"" + itemChecked.ToString() + 
                        "\", is checked. Checked state is: " + 
                        checkedListBox1.GetItemCheckState(checkedListBox1.Items.IndexOf(itemChecked)).ToString() + ".");
    }


        }
  }
}
