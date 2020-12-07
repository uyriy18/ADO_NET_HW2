using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ADO_NET_HW2
{
    public partial class Form1 : Form
    {
        static int count = 0;
        SqlDataAdapter adapter;
        DataSet set;
        DataTable table;
        ListView list;
        String connString = ConfigurationManager.ConnectionStrings["Liberary"].ConnectionString;
        String[] command;

        public Form1()
        {
            InitializeComponent();
            tbcl_MainTabControl.Visible = false;
            txbx_Querry.Text = "SELECT * FROM BOOKS; SELECT Firstname,Lastname FROM AUTHORS";
            cmbx_Table_List.SelectedItem = "Table";
        }

        private void btn_Fill_Click(object sender, EventArgs e)
        {        
            command = txbx_Querry.Text.Split(';');
            foreach(var item in command)
            {
                list = new ListView();
                list.Dock = DockStyle.Fill;
                list.GridLines = true;
                TabPage page = new TabPage();
                page.Controls.Add(list);
                page.Text = "Tab" + count++;
                tbcl_MainTabControl.Visible = true;
                tbcl_MainTabControl.Controls.Add(page);
                if(cmbx_Table_List.SelectedItem.ToString() == "Table")
                {
                    fillListVievAsDetales(item);
                }
                else
                {
                    fillListViewAsList(item);
                }
            }
        }

        void fillListVievAsDetales(string cmd)
        {
            list.View = View.Details;
            using (SqlConnection connection = new SqlConnection(connString)) 
            {
                try
                {
                    adapter = new SqlDataAdapter(cmd, connection);
                    set = new DataSet();
                    adapter.Fill(set,"MyTable");
                    table = set.Tables["MyTable"];
                    foreach(DataColumn item in table.Columns)
                    {
                        list.Columns.Add(item.ColumnName);                 
                    }
                    foreach (DataRow item in table.Rows)
                    {
                        ListViewItem listViewItem = new ListViewItem(item[0].ToString());
                        for (int i = 1; i < table.Columns.Count; i++)
                        {
                            listViewItem.SubItems.Add(item[i].ToString());
                        }
                        list.Items.Add(listViewItem);
                        list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
            
        }

        void fillListViewAsList(string cmd)
        {
            list.View = View.List;
            using(SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    adapter = new SqlDataAdapter(cmd, connection);
                    set = new DataSet();
                    adapter.Fill(set, "MyTable");
                    table = set.Tables["MyTable"];
                    string str = null;
                    foreach(DataRow item in table.Rows)
                    {
                        for(int i = 0; i < table.Columns.Count; i++)
                        {
                            str += $"{item[i].ToString()}  |  \t";
                        }
                        list.Items.Add(str);
                        str = "";
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
         
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
