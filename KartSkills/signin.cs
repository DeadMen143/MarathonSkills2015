﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartSkills
{
    public partial class signin : Template
    {
        public signin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((tb_email.Text == "admin") && (tb_password.Text == "123"))
            {
                MessageBox.Show("Вы авторизовались!");

            }
            else
            {
                MessageBox.Show("Польтзователь не найден");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Создаем новый экземпляр для окна main и отображаем его
            new main().Show();
            //Скрываем текущее окно(форму)
            Hide();

        }
    }
}
