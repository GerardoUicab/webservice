using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webservice.ServiceReference1;
using System.Windows.Forms;
using System.IO;

namespace webservice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalWeatherSoapClient obj = new GlobalWeatherSoapClient();
            string resultado = obj.GetCitiesByCountry(textBox1.Text);
            DataSet resul = new DataSet();
            StringReader lectura = new StringReader(resultado);
            resul.ReadXml(lectura);
            comboBox1.DataSource = resul.Tables[0];
            comboBox1.DisplayMember = "city";
        }
    }
}
