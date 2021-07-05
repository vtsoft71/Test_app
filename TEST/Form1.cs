using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class Form1 : Form
    {
        string sqlite_ConnectionString = "URI=file:" + @"C:\Users\Admin\Documents\Visual Studio 2015\Projects\VTNET\VTNET\vtdat.db";
        public Form1()
        {
            InitializeComponent();

            dataGridView1.DataSource = SelectCommand("Select * from listcomp");
        }

        private void sdfsd()
        {

        }
        public DataTable SelectCommand(string sql_cmd)
        {
            SQLiteConnection con = new SQLiteConnection(sqlite_ConnectionString);
            con.Open();
            DataTable tbl_select = new DataTable();
            using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql_cmd, con))
            {
                da.Fill(tbl_select);
            }
            con.Close();
            con.Dispose();
            return tbl_select;
        }
        public void RunSqlCommand(string sql_cmd)
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection(sqlite_ConnectionString);
                SQLiteCommand command = new SQLiteCommand(sql_cmd.Replace("N'", "'"), con);
                con.Open();
                command.ExecuteNonQuery();
                command.Dispose();
                con.Close();
                con.Dispose();
            }
            catch
            {
                MessageBox.Show("Sqlite: " + sql_cmd, "Sqlite error command", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
