using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;


namespace MyBTP
{
    public partial class FormColaboradores : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "oB5d1kgCIUVJHHu2kgWz04gDhVXnhWNs5VvQHT2p",
            BasePath = "https://btpbase-7e0c8.firebaseio.com/"
        };

        IFirebaseClient Client;

        public FormColaboradores()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormColaboradores_Load(object sender, EventArgs e)
        {
            Client = new FireSharp.FirebaseClient(config);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                Nome = TXT_NOME.Text,
                CPF = TXT_CPF.Text,
                DATANASC = TXT_DTNASC.Text,
                SETOR = TXT_SETOR.Text,
                FUNCAO = TXT_FUNCAO.Text,
                CEP = TXT_CEP.Text,
                LOGIN = TXT_LOGIN.Text,
                SENHA = TXT_SENHA.Text,
                ISCALA = TXT_ESCALA.Text,
                TURMA = TXT_TURMA.Text,
                SCORE = TXT_SCORE.Text,
            };
            SetResponse response = await Client.SetTaskAsync("COLABORADOR/" + TXT_NOME.Text, data);
            Data result = response.ResultAs<Data>();

            MessageBox.Show("Colaborador inserido" + "  " + result.Nome);





        }
    }
}
