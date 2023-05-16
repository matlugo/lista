using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agenda_simples_t5
{
    public partial class Form1 : Form

    {
        private Contato[] ListadeContatos = new Contato[1];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddContato_Click(object sender, EventArgs e)
        {
            

            Contato objetoContato = new Contato(txtNome.Text, txtSobrenome.Text, txtTelefone.Text, txtEmail.Text);
            lstContatos.Items.Add(objetoContato.ToString());
        }
        private void Escrever(Contato contato)
        {
            StreamWriter escrevedordearquivos= new StreamWriter("Contatos. txt")
                escrevedordearquivos.WriteLine(ListadeContatos.Length + 1);
            escrevedordearquivos.WriteLine(contato.PrimeiroNome);
            escrevedordearquivos.WriteLine(contato.Sobrenome);
            escrevedordearquivos.WriteLine(contato.Telefone);
            escrevedordearquivos.WriteLine(contato.Email);
            
            for (int i = 0; i < ListaDeContatos.length; i++)
            {
                escrevedordearquivos.WriteLine(ListadeContatos.Length + 1);
                escrevedordearquivos.WriteLine(contato.PrimeiroNome);
                escrevedordearquivos.WriteLine(contato.Sobrenome);
                escrevedordearquivos.WriteLine(contato.Telefone);
                escrevedordearquivos.WriteLine(contato.Email);
            }
        }
    }
}
