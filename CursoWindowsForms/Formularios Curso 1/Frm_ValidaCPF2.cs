using CursoWindowsFormsBiblioteca;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_ValidaCPF2 : Form
    {
        public Frm_ValidaCPF2()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, System.EventArgs e)
        {
            Msk_CPF.Text = "";
        }

        private void Btn_Valida_Click(object sender, System.EventArgs e)
        {
            string vConteudo;
            vConteudo = Msk_CPF.Text;
            vConteudo = vConteudo.Replace(".", "").Replace("-", "");
            vConteudo = vConteudo.Trim();


            if(vConteudo == "")
            {
                MessageBox.Show("CPF não contém texto!", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(vConteudo.Length !=11){
                MessageBox.Show("CPF não está completo!", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(MessageBox.Show
                ("Você deseja realmente validar o CPF?",
                "Mensagem de Validação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool validaCPF = false;
                    validaCPF = Cls_Uteis.Valida(Msk_CPF.Text);
                    if(validaCPF == true)
                    {
                        MessageBox.Show("CPF Válido!", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("CPF Inválido!", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            

        }
    }
}
