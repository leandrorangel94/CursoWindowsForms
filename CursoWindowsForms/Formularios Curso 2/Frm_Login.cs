﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Login : Form
    {
        public string senha { get; set; }
        public string login { get; set; }


        public Frm_Login()
        {
            InitializeComponent();

            Lbl_Login.Text = "Usuário:";
            Lbl_Password.Text = "Senha:";
            Btn_Cancel.Text = "Cancelar";
            Btn_Ok.Text = "OK";

        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            senha = Txt_Password.Text;
            login = Txt_Login.Text;

            this.Close();
        }
    }
}
