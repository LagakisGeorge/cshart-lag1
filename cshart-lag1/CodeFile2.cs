
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Data.OleDb;
using System.Net.NetworkInformation;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic.Compatibility;
using System.IO;

using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;






static class Globals
{
   
  //  public static DataTable sqlDT = new DataTable();
 //   public static DataSet sqlDaTaSet = new DataSet();
  //  public static DataTable sqlDTx = new DataTable();

  //  public static System.IO.Stream openedFileStream;

    public static string gSplitter = ";";

    // static int xsize;
          

    public static string gConnect;
    // public static string gConSQL;

   // public static int gMenu;

  
    //public static int gPHDHMAGENNA;
    //public static int gPHDHMAnextOXEIA;

    //public static int gAPOGnextOXEIA;




    //public static string sqlSTR;
    //public static string Rpt_SqlStr;
    //public static bool pass;
    //public static double VAT;
    //public static string username;
    //public static int xUser_ID;
    //public static string xUser_Access;
    //public static int Pending_ID;
    //public static int Pending_QTY;
    //public static int Pending_Item_ID;
    //public static byte[] dataBytes;
    //public static bool xpass;
    //public static int howx;


    public static int[] xid = new int[2];

    //public static bool xlock;
    //public static int iMin;
    //public static string tmpStr;
    //public static int LOGID;
    //public static int PreviousPage;
    //public static int NextPage;
    //public static int i_Print;

    //public static string gMHNAS;


















    public static string cNull(string c)
    {
        string functionReturnValue = null;
        if (Information.IsDBNull(c))
        {
            functionReturnValue = "";
        }
        else
        {
            functionReturnValue = c;
        }
        return functionReturnValue;


    }
}



public class functions
{


    public static System.Boolean IsNumeric(System.Object Expression)
    {
        if (Expression == null || Expression is DateTime)
            return false;

        if (Expression is Int16 || Expression is Int32 || Expression is Int64 || Expression is Decimal || Expression is Single || Expression is Double || Expression is Boolean)
            return true;

        try
        {
            if (Expression is string)
                Double.Parse(Expression as string);
            else
                Double.Parse(Expression.ToString());
            return true;
        }
        catch { } // just dismiss errors but return false
        return false;
    }



    public static void FillCheckedListBox(string sql, CheckedListBox cb)  // , ref Array ids)
    {
        DataTable dt = functions.ExecuteSQLQuery(sql);
        cb.Items.Clear();
        try
        {
            for (int k = 0; k <= dt.Rows.Count - 1; k++)
            {
                cb.Items.Add(dt.Rows[k]["PERIGRAFH"].ToString());
            }
        }
        catch (Exception ex)
        {
            //
        }
        finally
        {
            //
        }
    }

    public static void FillComboBox(string sql, ComboBox cb)  // , ref Array ids)
    {
        DataTable dt = functions.ExecuteSQLQuery(sql);
        cb.Items.Clear();
        try
        {
            for (int k = 0; k <= dt.Rows.Count - 1; k++)
            {
                cb.Items.Add(dt.Rows[k][0].ToString());
            }
        }
        catch (Exception ex)
        {
            //
        }
        finally
        {
            //
        }
    }

    //public void FillCheckedListBox(string sql, CheckedListBox cb)
    //{
    //    OleDbConnection conn = new OleDbConnection(functions.gConnect);
    //    cb.Items.Clear();
    //    try
    //    {
    //        conn.Open();
    //        OleDbCommand cmd = new OleDbCommand(sql, conn);
    //        OleDbDataReader rdr = cmd.ExecuteReader;
    //        while (rdr.Read)
    //        {
    //            cb.Items.Add(rdr(0).ToString + " - " + rdr(1).ToString);
    //        }
    //        rdr.Close();
    //    }
    //    catch (Exception ex)
    //    {
    //        Interaction.MsgBox("Error:" + ex.ToString);
    //    }
    //    finally
    //    {
    //        conn.Close();
    //    }
    //}











     public static  bool CheckServer()
    {
        string c = null;
        c = Application.StartupPath + "\\Config.ini";
        c = "c:\\mercvb\\Config.ini";

       // c = "Config.ini";
        byte[] ddd = ReadFile(c);

        char[] charSeparators = new char[] { ':' };

        string[] result;




        //    FileStream fileStream = new FileStream(@"c:\mercvb\config.ini", FileMode.Open);
        string tmpStr = System.Text.Encoding.UTF8.GetString(ddd);



        result = tmpStr.Split(charSeparators, StringSplitOptions.None);
        Show2(result);




        //   string[] result = tmpStr.Split(charSeparators, StringSplitOptions.None);

        if ( result[4]   == "1")
        // {
        /*
         gConnect = "Provider=SQLOLEDB.1;;Password=" + Strings.Split(tmpStr, ":")(3) + 
             ";Persist Security Info=True ;" + ";User Id=" + Strings.Split(tmpStr, ":")(2) + 
             ";Initial Catalog=" + Strings.Trim(Strings.Split(tmpStr, ":")(5)) +
             ";Data Source=" + Strings.Split(tmpStr, ":")(1);
         */

        //  }

        //  fileStream.Close();

        Globals.gConnect = "Provider=SQLOLEDB.1;;Password=" + result[3] +
            ";Persist Security Info=True ;" + ";User Id=" + result[2] +
            ";Initial Catalog=" + result[5].Trim() +
            ";Data Source=" + result[1].Trim();
         
        else

         Globals.gConnect = "Provider=SQLOLEDB;Server=" + result[1] + ";Database=" + result[5] + "; Trusted_Connection=yes;";


        OleDbConnection sqlCon = new OleDbConnection();
        sqlCon.ConnectionString = Globals.gConnect;
        sqlCon.Open();
        
        sqlCon.Close();
         return true;
    }


    public static void Show2(string[] entries)
    {
        Console.WriteLine("The return value contains these {0} elements:", entries.Length);
        foreach (string entry in entries)
        {
            Console.Write("<{0}>", entry);
        }
        Console.Write("\n\n");
    }


    //==========================================================================
    public static byte[] ReadFile(string filePath)
    {
        byte[] buffer;
        FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
        try
        {
            int length = (int)fileStream.Length;  // get file length
            buffer = new byte[length];            // create buffer
            int count;                            // actual number of bytes read
            int sum = 0;                          // total number of bytes read

            // read until Read method returns 0 (end of the stream has been reached)
            while ((count = fileStream.Read(buffer, sum, length - sum)) > 0)
                sum += count;  // sum is a buffer offset for next reading
        }
        finally
        {
            fileStream.Close();
        }
        return buffer;
    }


    public static DataTable ExecuteSQLQuery(string SQLQuery)
    {
        DataTable sqlDT2 = new System.Data.DataTable();


        try
        {
            OleDbConnection sqlCon = new OleDbConnection(Globals.gConnect);

            OleDbDataAdapter sqlDA = new OleDbDataAdapter(SQLQuery, sqlCon);

            OleDbCommandBuilder sqlCB = new OleDbCommandBuilder(sqlDA);
            // DataTable sqlDT=new DataTable ; //.Reset();
           // DataTable sqlDT2 = new System.Data.DataTable();
            // refresh 
            sqlDA.Fill(sqlDT2);
            int sql = sqlDT2.Rows.Count;


            //rowsAffected = command.ExecuteNonQuery();
            // sqlDA.Fill(sqlDaTaSet, "PEL")

        }
        catch (Exception ex)
        {
            //Interaction.MsgBox("Error: " + ex.ToString);
            //if (Err.Number == 5)
            //{
            //    Interaction.MsgBox("Invalid Database, Configure TCP/IP", MsgBoxStyle.Exclamation, "Sales and Inventory");
            //}
            //else
            //{
            //    Interaction.MsgBox("Error : " + ex.Message);
            //}
            //Interaction.MsgBox("Error No. " + Err.Number + " Invalid database or no database found !! Adjust settings first", MsgBoxStyle.Critical, "Sales And Inventory");
            //Interaction.MsgBox(SQLQuery);
        }
        return sqlDT2;
    }























}
