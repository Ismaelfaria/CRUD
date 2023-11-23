using Microsoft.Win32.SafeHandles;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Crud
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        string sql = "datasource=localhost;username=root;password=123456;database=db_agenda";
        public Form1()
        {
            InitializeComponent();

            listaContatos.View = View.Details;
            listaContatos.LabelEdit = true;
            listaContatos.AllowColumnReorder = true;
            listaContatos.FullRowSelect = true;
            listaContatos.GridLines = true;

            listaContatos.Columns.Add("Id",30, HorizontalAlignment.Left);
            listaContatos.Columns.Add("Nome",150, HorizontalAlignment.Left);
            listaContatos.Columns.Add("E-mail",150, HorizontalAlignment.Left);
            listaContatos.Columns.Add("Telefone",150, HorizontalAlignment.Left);
        }

        private void SalvarContato_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(sql);

                var comandInsert = "INSERT INTO contato (nome, email, telefone) " +
                    "VALUES " +
                    "('" + txtName.Text + "', '" +
                           txtEmail.Text + "', '" +
                           txtTelefone.Text + "')";

                MySqlCommand commandInsert = new MySqlCommand(comandInsert, conn);

                conn.Open();
                commandInsert.ExecuteReader();

                MessageBox.Show("Deu certo, contato agendado!!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void BuscarContatos_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(sql);

                conn.Open();

                string query = "'%"+txtBuscar.Text+ "%'";

                string comandSelect = "SELECT * FROM contato WHERE nome LIKE " + query
                    + " OR email LIKE " + query;

                MySqlCommand commandSelect = new MySqlCommand(comandSelect, conn);

                MySqlDataReader reader = commandSelect.ExecuteReader();

                listaContatos.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };

                    var linha_listView = new ListViewItem(row);

                    listaContatos.Items.Add(linha_listView);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
