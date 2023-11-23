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

                var query = "'%"+txtBuscar.Text+"%'";
                var comandSelect = "SELECT * FROM contato WHERE nome LIKE "+ query
                    + " OR email LIKE "+ query;

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

                    var linhaListContatos = new ListViewItem(row);

                    listaContatos.Items.Add(linhaListContatos);
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
