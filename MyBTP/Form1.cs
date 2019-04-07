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
    public partial class Form_Principal : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "oB5d1kgCIUVJHHu2kgWz04gDhVXnhWNs5VvQHT2p",
            BasePath= "https://btpbase-7e0c8.firebaseio.com/"
        };

        IFirebaseClient client;

        public Form_Principal()
        {
            InitializeComponent();
        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                MessageBox.Show("Conexão bem sucedida");
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormColaboradores FormTrei = new FormColaboradores();
            FormTrei.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                //Navio = textBox_Navio.Text,
//Viagem = textBox_Viagem.Text,
               // Previsao = textBox_Previsao.Text
            };

            //SetResponse response = await client.SetTaskAsync("Operacoes/"+textBox_Navio.Text,data);
            // Data result = response.ResultAs<Data>();

            //  MessageBox.Show("Operãção inserida!" + result.Navio);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Treinamentos FormTrei = new Treinamentos();
            FormTrei.Show();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            FormResumem res = new FormResumem();
            res.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            FormRanking RNK = new FormRanking();
            RNK.ShowDialog();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            FormNavio RNK = new FormNavio();
            RNK.ShowDialog();
        }














    }
}
