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
    public partial class FormEscala : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "oB5d1kgCIUVJHHu2kgWz04gDhVXnhWNs5VvQHT2p",
            BasePath = "https://btpbase-7e0c8.firebaseio.com/"
        };

        IFirebaseClient Client;

        public FormEscala()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormEscala_Load(object sender, EventArgs e)
        {
            Client = new FireSharp.FirebaseClient(config);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                REFHORARIO = txt_refhorario.Text,  
                ESCALA = txtescala.Text,
                JORNADA = txtjornada.Text,
                AM1 = checkBox_AM1.Checked,
                AM2 = checkBox_AM2.Checked,
                AM3 = checkBox_AM3.Checked,
                AM4 = checkBox_AM4.Checked,
                AM5 = checkBox_AM5.Checked,
                AM6 = checkBox_AM6.Checked,
                AM7 = checkBox_AM7.Checked,
                AM8 = checkBox_AM8.Checked,
                AM9 = checkBox_AM9.Checked,
                AM10 = checkBox_AM10.Checked,
                AM11 = checkBox_AM11.Checked,
                PM1 = checkBox_PM1.Checked,
                PM2 = checkBox_PM2.Checked,
                PM3 = checkBox_PM3.Checked,
                PM4 = checkBox_PM4.Checked,
                PM5 = checkBox_PM5.Checked,
                PM6 = checkBox_PM6.Checked,
                PM7 = checkBox_PM7.Checked,
                PM8 = checkBox_PM8.Checked,
                PM9 = checkBox_PM9.Checked,
                PM10 = checkBox_PM10.Checked,
            };

            SetResponse response = await Client.SetTaskAsync("ESCALAS/" + txt_refhorario.Text, data);
            Data result = response.ResultAs<Data>();

            MessageBox.Show("ESCALA CADASTRADA COM SUCESSO" + "  " + result.REFHORARIO);




        }
    }
}
