using System;
using System.Drawing;
using System.Windows.Forms;
using static CursoWindowsFormsBiblioteca.Cls_Uteis;

namespace CursoWindowsForms
{
    public partial class Frm_ValidaSenha : Form
    {
        bool VerSenhaTxt = false;

        public Frm_ValidaSenha()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = "";
            Txt_Senha.Text = "";
        }

        private void Txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            ChecaForcaSenha verifica = new ChecaForcaSenha();
            ChecaForcaSenha.ForcaDaSenha forca;
            forca = verifica.GetForcaDaSenha(Txt_Senha.Text);
            Lbl_Resultado.Text = forca.ToString();

            if(Lbl_Resultado.Text == "Inaceitavel" | Lbl_Resultado.Text == "Fraca")
            {
                Lbl_Resultado.ForeColor = Color.DarkRed;
            }
            else if(Lbl_Resultado.Text == "Aceitavel")
            {
                Lbl_Resultado.ForeColor = Color.DarkOrange;
            }
            else if(Lbl_Resultado.Text == "Forte")
            {
                Lbl_Resultado.ForeColor = Color.DarkSeaGreen;
            }
            else if(Lbl_Resultado.Text == "Segura")
            {
                Lbl_Resultado.ForeColor = Color.DarkGreen;
            }

        }

        private void Btn_VerSenha_Click(object sender, EventArgs e)
        {
            if(VerSenhaTxt == false)
            {
                Txt_Senha.PasswordChar = '\0';
                VerSenhaTxt = true;
                Btn_VerSenha.Text = "Ocultar Senha";
            }
            else
            {
                Txt_Senha.PasswordChar = '*';
                VerSenhaTxt = false;
                Btn_VerSenha.Text = "Exibir Senha";

            }
        }
    }

   
}
