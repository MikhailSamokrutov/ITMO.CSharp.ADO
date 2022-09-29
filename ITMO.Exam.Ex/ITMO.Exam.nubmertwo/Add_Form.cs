﻿using System;
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
    public partial class Add_Form : Form
    {

        DataBase dataBase = new DataBase();

        public Add_Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataBase.openConnection();

            var type = textBox_type2.Text;
            var count = textBox_count2.Text;
            var postav = textBox_postav2.Text;
            int price;

            if(int.TryParse(textBox_price2.Text, out price))
            {
                var addQuery = $"insert into test_db (type_of, count_of, postavka, price) values ('{type}', '{count}', '{postav}', '{price}')";

                var command = new SqlCommand(addQuery, dataBase.GetConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Цена должна иметь числовой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dataBase.closeConnection();

        }
    }
}
