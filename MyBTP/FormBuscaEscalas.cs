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
using FireSharp.Response;
using FireSharp.Interfaces;

namespace MyBTP
{
    public partial class FormBuscaEscalas : Form
    {
        DataTable dt = new DataTable();

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "oB5d1kgCIUVJHHu2kgWz04gDhVXnhWNs5VvQHT2p",
            BasePath = "https://btpbase-7e0c8.firebaseio.com/"
        };

        IFirebaseClient Client;

        public FormBuscaEscalas()
        {
            InitializeComponent();
        }

        private void FormBuscaEscalas_Load(object sender, EventArgs e)
        {
            Client = new FireSharp.FirebaseClient(config);

            dt.Columns.Add("Ref");
            dt.Columns.Add("ESCALA");
            dt.Columns.Add("JORNADA");

            dataGridView1.DataSource = dt;

            export();
        }

        public async void export()
       {
            try
            {
                FirebaseResponse resp = await Client.GetTaskAsync("ESCALAS");
                Data obj = resp.ResultAs<Data>();

                DataRow row = dt.NewRow();
                
             }
             catch
            {

            }


       }







    }
}
