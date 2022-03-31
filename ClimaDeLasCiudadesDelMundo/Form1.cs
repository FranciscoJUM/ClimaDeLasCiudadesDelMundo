using ClimaDeLasCiudadesDelMundo.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClimaDeLasCiudadesDelMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string CityName;
        string Key = "261b1433bf8b33139675ceea61baed5e";
       
       
        private  void Form1_Load(object sender, EventArgs e)
        {
            condicion.Visible = false;
            label2.Visible = false;
            amanecer.Visible = false;
            atardecer.Visible = false;
            Viento.Visible = false;
            Presion.Visible = false;
           
            
        }
       
        public async Task<string> GetHttp()
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?q={city name}&appid={API key}";
            WebRequest webRequest= WebRequest.Create(url);
            WebResponse webResponse=  webRequest.GetResponse();
            StreamReader sr = new StreamReader(webResponse.GetResponseStream());
            return await sr.ReadToEndAsync();

        }

        void GetWeather()
        {
            try 
            {

                using (WebClient webClient = new WebClient())
                {
                    string url = string.Format($"https://api.openweathermap.org/data/2.5/weather?q={TBCiudad.Text}&appid={Key}");
                    var json = webClient.DownloadString(url);
                    PostView.root info = JsonConvert.DeserializeObject<PostView.root>(json);

                    pictureBox1.ImageLocation = "https://openweathermap.org/img/w/" + info.weather[0].icon + ".png";
                    condicion.Text = info.weather[0].main;
                    label2.Text = info.weather[0].description;
                    atardecer.Text = Convertir(info.sys.sunset).ToShortTimeString();
                    amanecer.Text = Convertir(info.sys.sunrise).ToShortTimeString();

                    Viento.Text = info.wind.speed.ToString();
                    Presion.Text = info.main.pressure.ToString();


                }


            }
            catch(System.Net.WebException ex ) 
            { MessageBox.Show(ex.Message); }
           
            

        }

        private void BTBuscar_Click(object sender, EventArgs e)
        {
            condicion.Visible = true;
            label2.Visible = true;
            amanecer.Visible = true;
            atardecer.Visible = true;
            Viento.Visible = true;
            Presion.Visible = true;
            GetWeather();
            TBCiudad.Text = "";
            
        }


        DateTime Convertir(long millisec) 
        {
            DateTime day = new DateTime(1970,1,1,0,0,0,0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(millisec).ToLocalTime();
            return day;

        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString("h:mm:ss");
            LblFecha.Text = DateTime.Now.ToLongDateString();    

        }

        private void TBCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                condicion.Visible = true;
                label2.Visible = true;
                amanecer.Visible = true;
                atardecer.Visible = true;
                Viento.Visible = true;
                Presion.Visible = true;
               
                GetWeather();
                TBCiudad.Text = "";
            }
        }
    }
}
