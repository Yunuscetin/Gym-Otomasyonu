using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Net;
using System.Data;
using System.Net.NetworkInformation;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace gym
{
    class islemler
    {
        public string token = "";
        static HttpClient client = new HttpClient();

        public islemler()
        {
            try
            {
                /*AnaForm ana = new AnaForm();
                MessageBox.Show("geldim:\n" + ana.access_token);
                /* using (var handler = new HttpClientHandler())
                 using (var client = new HttpClient(handler))
                 {
                     client.BaseAddress = new Uri("https://gymtracking.herokuapp.com/api/");
                 }
                //client.BaseAddress = new Uri("https://gymtracking.herokuapp.com/api/");
                client.DefaultRequestHeaders.Accept.Clear();

                client.DefaultRequestHeaders.Add("ContentType", "application/json");
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", ana.access_token);*/

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public async Task<dynamic> ApiPost(string url, Object data)
        {
            try
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Add("ContentType", "application/json");
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);


                HttpResponseMessage response = await client.PostAsJsonAsync("https://gymtrackingapp.herokuapp.com/api/" + url, data);

                dynamic obj = JsonConvert.DeserializeObject<dynamic>(response.Content.ReadAsStringAsync().Result);


                if (response.StatusCode != HttpStatusCode.OK)
                {
                    return errorsMesaj(obj);
                }
                else
                {
                    return obj;
                }
            }
            catch (Exception e)
            {
                return MessageBox.Show(e.ToString());
            }
        }
        
        public async Task<dynamic> ApiGet(string url)
        {
            try
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Add("ContentType", "application/json");
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);


                HttpResponseMessage response = await client.GetAsync("https://gymtrackingapp.herokuapp.com/api/" + url);
                dynamic obj = JsonConvert.DeserializeObject<dynamic>(response.Content.ReadAsStringAsync().Result);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    return errorsMesaj(obj);
                }
                else
                {
                    return obj;
                }
            }
            catch (Exception e)
            {
                return MessageBox.Show(e.ToString());
            }
        }

        public dynamic errorsMesaj(dynamic error)
        {
            if (NetworkInterface.GetIsNetworkAvailable() != true)
            {
                MessageBox.Show("İnternet bağlantısı yok.");
            }
            else if (error.message.ToString() == "Unauthenticated.")
            {
                /*ApiGet("logout");
                delRegister("access_token");
                delRegister("refresh_token");
                LoginForm lg = new LoginForm();
                lg.ShowDialog();*/

                MessageBox.Show("Kimlik doğrulanmadı.");

            }
            else if (error.error.ToString())
            {
                MessageBox.Show(error.DynamicBody.error);
            }
            else if (error.errors)
            {
                var errors = error.errors;

                string errorsText = "";

                foreach (var errorText in errors)
                {
                    errorsText = errorsText + "\n" + errorText.errors.ToString();
                }

            }
            else
            {
                MessageBox.Show("Hata oluştu: " + error.ToString());
            }
            return null;
        }

        public string newPassM()
        {
            Random rnd = new Random();
            string harf = "abcdefghijklmnoprstuvyz1234567890";
            string uret = "";
            for (int i = 0; i < 7; i++)
            {
                uret = uret + harf[rnd.Next(harf.Length)];
            }
            return uret;
        }
    }
}