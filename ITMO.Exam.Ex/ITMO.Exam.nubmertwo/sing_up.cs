using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ITMO.Exam.nubmertwo
{
    public partial class sing_up : Form
    {
        DataBase dataBase = new DataBase();
        public sing_up()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void sing_up_Load(object sender, EventArgs e)
        {
            textBox_password2.PasswordChar = '*';
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            var login = textBox_login2.Text;
            var password = textBox_password2.Text;

            string querystring = $"insert into register(login_user, password_user) values('{login}', '{password}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());

            dataBase.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!", "Успех!");
                log_in frm_login = new log_in();
                this.Hide();
                frm_login.ShowDialog();


            }
            else
            {
                MessageBox.Show("Аккаунт не создан!");
            }
            dataBase.closeConnection();
        }

        private Boolean checkuser()
        {
            var loginUser = textBox_login2.Text;
            var passUser = textBox_password2.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id_user, login_user, password_user from register where login_user = '{loginUser}' and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;
            }
            else
            {
                return false;
            }
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
