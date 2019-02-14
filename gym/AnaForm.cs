using gym.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym
{
    public partial class AnaForm : Form
    {
        #region panelsecme
        public string access_token = "";
        string secilen = "";
        public AnaForm()
        {
            InitializeComponent();

            // Panelleri butonlarla ilişkilendir
            btn1.Tag = pnl1;
            btn2.Tag = pnl2;
            btn3.Tag = pnl3;
            btn4.Tag = pnl4;
            //     btn3.Tag = pnl3;

            // Butonlara tıklayınca panelSec fonksiyonunu çağır
            btn1.Click += new EventHandler(panelsec);
            btn2.Click += new EventHandler(panelsec);
            btn3.Click += new EventHandler(panelsec);
            btn4.Click += new EventHandler(panelsec);
        }

        private void panelsec(object sender, EventArgs e)
        {
            // Tıklanan butonu al
            Button buton = (Button)sender;

            // Tüm panelleri gizle
            Panel[] tumPaneller = { pnl1, pnl2, pnl3, pnl4/*,pnl4  , ... */ };
            foreach (Panel p in tumPaneller) p.Visible = false;

            // Butonun Tag özelliğinde panel belirtilmişse görünür yap
            if (buton.Tag is Panel)
            {

                ((Panel)buton.Tag).Visible = true;

            }

            tparola.Text = islemler.newPassM(); ;

            ((Panel)buton.Tag).Location = new Point(0, 0);
            ((Panel)buton.Tag).Height = 561;
            ((Panel)buton.Tag).Width = 984;
            ((Panel)buton.Tag).Visible = true;


            //  984; 561
        }
        #endregion

        islemler islemler = new islemler();

        #region ana sayfa
        private void AnaForm_Load(object sender, EventArgs e)
        {

            #region DateNow
            girisdate.MinDate = DateTime.Now;
            cikisdate.MinDate = DateTime.Now;

            #endregion

            listeledata.Font = new System.Drawing.Font("Microsoft PhagsPa", 15);

            if (eggun.SelectedItem != null)
            {
                int x = int.Parse(eggun.SelectedItem.ToString());
            }
            else
            { }

            diyetad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            diyetad.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            diyetad.AutoCompleteSource = AutoCompleteSource.ListItems;

            egad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            egad.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            egad.AutoCompleteSource = AutoCompleteSource.ListItems;

            plogin.Height = 561;
            plogin.Width = 984;
            plogin.Location = new Point(0, 0);

            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;

        }
        #endregion

        #region GeriButonResim
        private void g_login_MouseEnter(object sender, EventArgs e)
        {
            g_login.BackgroundImage = Properties.Resources.ico2;
        }
        private void g_login_MouseLeave(object sender, EventArgs e)
        {
            g_login.BackgroundImage = Properties.Resources.ico1;
        }
        private void g1_MouseEnter(object sender, EventArgs e)
        {
            g1.BackgroundImage = Properties.Resources.ico2;
        }
        private void g1_MouseLeave(object sender, EventArgs e)
        {
            g1.BackgroundImage = Properties.Resources.ico1;
        }
        private void g2_MouseEnter(object sender, EventArgs e)
        {
            g2.BackgroundImage = Properties.Resources.ico2;
        }
        private void g2_MouseLeave(object sender, EventArgs e)
        {
            g2.BackgroundImage = Properties.Resources.ico1;
        }
        private void g3_MouseEnter(object sender, EventArgs e)
        {
            g3.BackgroundImage = Properties.Resources.ico2;
        }
        private void g3_MouseLeave(object sender, EventArgs e)
        {
            g3.BackgroundImage = Properties.Resources.ico1;
        }
        private void g4_MouseEnter(object sender, EventArgs e)
        {
            g4.BackgroundImage = Properties.Resources.ico2;
        }
        private void g4_MouseLeave(object sender, EventArgs e)
        {
            g4.BackgroundImage = Properties.Resources.ico1;
        }
        private void g2_guncel_MouseEnter(object sender, EventArgs e)
        {
            g2_guncel.BackgroundImage = Properties.Resources.ico2;
        }
        private void g2_guncel_MouseLeave(object sender, EventArgs e)
        {
            g2_guncel.BackgroundImage = Properties.Resources.ico1;
        }

        #endregion

        #region AnaButonResim
        private void btn1_MouseEnter(object sender, EventArgs e)
        {
            btn1.BackgroundImage = Properties.Resources.btn1hover;
        }
        private void btn1_MouseLeave(object sender, EventArgs e)
        {
            btn1.BackgroundImage = Properties.Resources.btn1;
        }
        private void btn2_MouseEnter(object sender, EventArgs e)
        {
            btn2.BackgroundImage = Properties.Resources.btn2hover;
        }
        private void btn2_MouseLeave(object sender, EventArgs e)
        {
            btn2.BackgroundImage = Properties.Resources.btn2;
        }
        private void btn3_MouseEnter(object sender, EventArgs e)
        {
            btn3.BackgroundImage = Properties.Resources.btn3hover;
        }
        private void btn3_MouseLeave(object sender, EventArgs e)
        {
            btn3.BackgroundImage = Properties.Resources.btn3;
        }
        private void btn4_MouseEnter(object sender, EventArgs e)
        {
            btn4.BackgroundImage = Properties.Resources.btn4hover;
        }
        private void btn4_MouseLeave(object sender, EventArgs e)
        {
            btn4.BackgroundImage = Properties.Resources.btn4;
        }
        #endregion

        #region geriButoClick
        private void g1_Click(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
        }
        private void g2_Click(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
        }
        private void g3_Click(object sender, EventArgs e)
        {
            kahvaltiTxt.Text = "";
            kahvaltiDate.Text = "";
            kuslukTxt.Text = "";
            kuslukDate.Text = "";
            ogleTxt.Text = "";
            ogleDate.Text = "";
            ikindiTxt.Text = ""; ;
            ikindiDate.Text = "";
            aksamTxt.Text = "";
            aksamDate.Text = "";
            araTxt.Text = "";
            araDate.Text = "";
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
        }
        private void g4_Click(object sender, EventArgs e)
        {
            eggun.Text = "";
            egbolge.Text = "";
            eghareket.Text = "";
            egset.Text = "";
            egtekrar.Text = "";
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
        }
        private async void g2_guncel_Click(object sender, EventArgs e)
        {
            try
            {
                ploading.Visible = true;
                guncelle.Enabled = false;
                islemler.token = access_token;
                var yeni = await islemler.ApiGet("admin/users");
                var result = JsonConvert.DeserializeObject<List<Users>>(yeni.ToString());
                listeledata.DataSource = result;

                listeledata.Columns["id"].Visible = false;
                listeledata.Columns[1].HeaderText = "Ad Soyad";
                listeledata.Columns[2].HeaderText = "Telefon";
                listeledata.Columns[3].HeaderText = "E-Mail";

                pnl1.Visible = false;
                pnl2.Visible = true;
                pnl3.Visible = false;
                pnl4.Visible = false;
                pnl5.Visible = false;
                ploading.Visible = false;
                guncelle.Enabled = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Bi Problem Oluştu.");
            }

        }
        #endregion



        #region SifreYenıleme
        private void sifredegistirme_Click(object sender, EventArgs e)
        {
            sifredegistirme.Visible = false;
            plogin.Visible = false;
            pSifre.Visible = true;
            pSifre.Height = 561;
            pSifre.Width = 984;
            pSifre.Location = new Point(0, 0);
            lblMail.Text = loginmail.Text;
            label15.Font = new Font(label15.Font.Name, label15.Font.SizeInPoints, FontStyle.Underline);
        }

        private void gSifre_Click(object sender, EventArgs e)
        {
            sifredegistirme.Visible = true;
            pSifre.Visible = false;
            plogin.Height = 561;
            plogin.Width = 984;
            plogin.Location = new Point(0, 0);
        }
        #endregion

        private async void loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (loginbtn.Text == " Giriş")
                {
                    loginload.Visible = true;
                    loginmail.Enabled = false;
                    loginparola.Enabled = false;
                    loginbtn.Enabled = false;
                    yenisifre.Enabled = false;

                    var values = new Dictionary<string, string>
                 {
                     { "email",   loginmail.Text },
                     { "password", loginparola.Text }
                 };
                    var result = await islemler.ApiPost("login", values);
                    islemler.token = result.access_token.ToString();
                    access_token = result.access_token.ToString();
                    if (result != null)
                    {
                        var result2 = await islemler.ApiGet("mobile/user");
                        if (result2.admin == true)
                        {
                            sifredegistirme.Visible = true;
                            plogin.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Admin değil");
                        }
                    }
                }
                else
                {
                    islemler.token = access_token;

                    var values = new Dictionary<string, string>
            {
                { "email", loginmail.Text},
            };
                    ploading.Visible = true;
                    var response = await islemler.ApiPost("passwordReset", values);
                    if (response)
                    {
                        ploading.Visible = false;
                        MessageBox.Show("Parola Gönderildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Parola Gönderilmedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanında Bir Problem Oluştu.");
            }

        }
        private void yenisifre_Click(object sender, EventArgs e)
        {
            // 540; 336
            loginbtn.Location = new Point(540, 335);
            loginbtn.ImageKey = "02.ico";
            loginbtn.Width = 144;
            g_login.Visible = true;
            loginparola.Visible = false;
            yenisifre.Visible = false;
            lbparola.Visible = false;
            loginbtn.Text = "Gönder";
        }
        private void g_login_Click(object sender, EventArgs e)
        {
            loginbtn.Location = new Point(560, 380);
            loginbtn.Width = 124;
            loginbtn.Height = 52;
            loginbtn.ImageKey = "2.png";
            g_login.Visible = false;
            loginparola.Visible = true;
            yenisifre.Visible = true;
            lbparola.Visible = true;
            loginbtn.Text = " Giriş";
            LoginLogo.Visible = true;
        }

        private void btndegis_Click(object sender, EventArgs e)
        {
            tparola.Text = islemler.newPassM(); ;
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch (FormatException ex)
            {
                return false;
            }
        }

        private async void kayitbtn_Click(object sender, EventArgs e)
        {
            string mail = loginmail.Text;
            try
            {
                ploading.Visible = true;
                if (IsValidEmail(tmail.Text))
                {
                    var values = new Dictionary<string, string>
               {
                { "name", tad.Text },
                { "phone_number", mtel.Text },
                { "email", tmail.Text },
                { "password", tparola.Text },
                { "start_date",  Convert.ToDateTime(girisdate.Text).ToString("yyyy-MM-dd")},
                { "end_date", Convert.ToDateTime(cikisdate.Text).ToString("yyyy-MM-dd") }
                };
                    var response = await islemler.ApiPost("admin/users/ekle", values);

                    if (response.durum == true)
                    {
                        ploading.Visible = false;
                        MessageBox.Show("Yeni kullanıcı başarıyla eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Kişi eklenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    tad.Text = "";
                    tmail.Text = "";
                    mtel.Text = "";
                    tparola.Text = islemler.newPassM(); ;
                    girisdate.Text = "";
                    cikisdate.Text = "";
                }
                else
                {
                    MessageBox.Show("Yanlış veya Hatalı Mail");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Boş Bırakılamaz!");
            }
        }

        string sec = "";
        private void listeledata_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                secilen = listeledata.CurrentRow.Cells[0].Value.ToString();
                sec = listeledata.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception)
            {

            }

        }

        private void listeledata_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow dgvrow in listeledata.Rows)
            {
                dgvrow.DefaultCellStyle.BackColor = Color.DimGray;
            }
        }

        public class Users
        {
            public int id { get; set; }
            public string name { get; set; }
            public string phone_number { get; set; }
            public string email { get; set; }
            public string start_date { get; set; }
            public string end_date { get; set; }
            public string days { get; set; }
        }
        private async void btn2_Click(object sender, EventArgs e)
        {
            ploading.Visible = true;
            btnsil.Enabled = false;
            btnguncel.Enabled = false;
            islemler.token = access_token;

            var response = await islemler.ApiGet("admin/users");
            var result = JsonConvert.DeserializeObject<List<Users>>(response.ToString());
            listeledata.DataSource = result;

            listeledata.Columns["id"].Visible = false;
            listeledata.Columns[1].HeaderText = "Ad Soyad";
            listeledata.Columns[2].HeaderText = "Telefon";
            listeledata.Columns[3].HeaderText = "E-Mail";
            listeledata.Columns[4].HeaderText = "Başlangıç Tarihi";
            listeledata.Columns[5].HeaderText = "Bitiş Tarihi";
            listeledata.Columns[6].HeaderText = "Kalan Gün";
            ploading.Visible = false;
            btnsil.Enabled = true;
            btnguncel.Enabled = true;
        }

        private async void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult a = MessageBox.Show(sec + " kişisi silmek istediğinize emin misiniz.", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                ploading.Visible = true;
                if (a == DialogResult.Yes)
                {
                    var response = await islemler.ApiGet("admin/users/sil/" + secilen);
                    if (response.durum == true)
                    {
                        islemler.token = access_token;
                        var yeni = await islemler.ApiGet("admin/users");
                        var result = JsonConvert.DeserializeObject<List<Users>>(yeni.ToString());
                        listeledata.DataSource = result;

                        listeledata.Columns["id"].Visible = false;
                        listeledata.Columns[1].HeaderText = "Ad Soyad";
                        listeledata.Columns[2].HeaderText = "Telefon";
                        listeledata.Columns[3].HeaderText = "E-Mail";
                        ploading.Visible = false;
                        MessageBox.Show("Kişi başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sec = "";
                        secilen = "";
                    }
                    else
                    {
                        ploading.Visible = false;
                        MessageBox.Show("Kişi silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanında Bir Problem Oluştu.");
            }

        }

        private void btnguncel_Click(object sender, EventArgs e)
        {
            try
            {
                guncelle.Enabled = true;
                pnl5.Location = new Point(0, 0);
                pnl5.Height = 561;
                pnl5.Width = 984;

                gad.Text = string.Format("{0}", listeledata.SelectedRows[0].Cells[1].Value);
                gtel.Text = string.Format("{0}", listeledata.SelectedRows[0].Cells[2].Value);
                gmail.Text = string.Format("{0}", listeledata.SelectedRows[0].Cells[3].Value);
                ggiris.Text = string.Format("{0}", Convert.ToDateTime(listeledata.SelectedRows[0].Cells[4].Value).ToString("dd MMMM yyyy dddd"));
                gcikis.Text = string.Format("{0}", Convert.ToDateTime(listeledata.SelectedRows[0].Cells[5].Value).ToString("dd MMMM yyyy dddd"));

                pnl1.Visible = false;
                pnl2.Visible = false;
                pnl3.Visible = false;
                pnl4.Visible = false;
                pnl5.Visible = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Bir Problem Oluştu.");
            }
        }

        private async void guncelle_Click(object sender, EventArgs e)
        {
           
            try
            {
                guncelle.Enabled = false;
                ploading.Visible = true;
                var values = new Dictionary<string, string>
            {
                { "name", gad.Text},
                { "phone_number", gtel.Text },
                { "email", gmail.Text },
                { "start_date",  Convert.ToDateTime(ggiris.Text).ToString("yyyy-MM-dd")},
                { "end_date", Convert.ToDateTime(gcikis.Text).ToString("yyyy-MM-dd") }

            };
                var response = await islemler.ApiPost("admin/users/guncelle/" + secilen, values);
                if (response.durum == true)
                {
                    guncelle.Enabled = true;
                    ploading.Visible = false;
                    MessageBox.Show("Güncelleme Başarılı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Güncelleme Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanında Bir Problem Oluştu.");
            }
        }


        private async void btn3_Click(object sender, EventArgs e)
        {
            islemler.token = access_token;
            var response = await islemler.ApiGet("admin/users");
            var result = JsonConvert.DeserializeObject<List<Users>>(response.ToString());
            diyetad.ValueMember = "id";
            diyetad.DisplayMember = "name";
            diyetad.DataSource = result;
        }

        private async void diyetekle_Click(object sender, EventArgs e)
        {

            try
            {             
                ploading.Visible = true;
                var values = new Dictionary<string, string>
            {
                { "user_id", diyetad.SelectedValue.ToString()},
                { "ctrl", "1"},
                { "type", diyettur.SelectedItem.ToString() },
                { "meal", "Kahvaltı" },
                { "content", kahvaltiTxt.Text },

                { "time", kahvaltiDate.Text.Substring(0,5) },

                { "start_date", Convert.ToDateTime(baslangicDate.Text).ToString("yyyy-MM-dd") },
                { "end_date", Convert.ToDateTime(bitisDate.Text).ToString("yyyy-MM-dd") },
            };

                var response = await islemler.ApiPost("admin/diet/ekle", values);
                if (response.durum == true)
                {
                    var values2 = new Dictionary<string, string>
                {
                { "user_id", diyetad.SelectedValue.ToString()},
                { "type", diyettur.SelectedItem.ToString() },
                { "meal", "Kuşluk" },
                { "content", kuslukTxt.Text },


                { "time", kuslukDate.Text.Substring(0,5) },

                { "start_date", Convert.ToDateTime(baslangicDate.Text).ToString("yyyy-MM-dd") },
                { "end_date", Convert.ToDateTime(bitisDate.Text).ToString("yyyy-MM-dd") },
                };
                    var response2 = await islemler.ApiPost("admin/diet/ekle", values2);
                    if (response2.durum == true)
                    {
                        var values3 = new Dictionary<string, string>
                    {
                        { "user_id", diyetad.SelectedValue.ToString()},
                        { "type", diyettur.SelectedItem.ToString() },
                        { "meal", "Öğle" },
                        { "content", ogleTxt.Text },


                        { "time", ogleDate.Text.Substring(0,5) },

                       { "start_date", Convert.ToDateTime(baslangicDate.Text).ToString("yyyy-MM-dd") },
                       { "end_date", Convert.ToDateTime(bitisDate.Text).ToString("yyyy-MM-dd") },
                    };
                        var response3 = await islemler.ApiPost("admin/diet/ekle", values3);
                        if (response3.durum == true)
                        {
                            var values4 = new Dictionary<string, string>
                        {
                            { "user_id", diyetad.SelectedValue.ToString()},
                            { "type", diyettur.SelectedItem.ToString() },
                            { "meal", "İkindi" },
                            { "content", ikindiTxt.Text },

                            { "time", ikindiDate.Text.Substring(0,5) },


                            { "start_date", Convert.ToDateTime(baslangicDate.Text).ToString("yyyy-MM-dd") },
                            { "end_date", Convert.ToDateTime(bitisDate.Text).ToString("yyyy-MM-dd") },
                        };
                            var response4 = await islemler.ApiPost("admin/diet/ekle", values4);
                            if (response4.durum == true)
                            {
                                var values5 = new Dictionary<string, string>
                            {
                                { "user_id", diyetad.SelectedValue.ToString()},
                                { "type", diyettur.SelectedItem.ToString() },
                                { "meal", "Akşam" },
                                { "content", aksamTxt.Text },

                                { "time", aksamDate.Text.Substring(0,5) },

                                 { "start_date", Convert.ToDateTime(baslangicDate.Text).ToString("yyyy-MM-dd") },
                                 { "end_date", Convert.ToDateTime(bitisDate.Text).ToString("yyyy-MM-dd") },
                            };
                                var response5 = await islemler.ApiPost("admin/diet/ekle", values5);
                                if (response5.durum == true)
                                {
                                    var values6 = new Dictionary<string, string>
                                {
                                    { "user_id", diyetad.SelectedValue.ToString()},
                                    { "type", diyettur.SelectedItem.ToString() },
                                    { "meal", "Ara" },
                                    { "content", araTxt.Text },

                                    { "time", araDate.Text.Substring(0,5) },
                                    { "start_date", Convert.ToDateTime(baslangicDate.Text).ToString("yyyy-MM-dd") },
                                    { "end_date", Convert.ToDateTime(bitisDate.Text).ToString("yyyy-MM-dd") },
                                };
                                    var response6 = await islemler.ApiPost("admin/diet/ekle", values6);

                                    if (response6.durum == true)
                                    {
                                        MessageBox.Show("Diyet başarıyla eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        ploading.Visible = false;
                                        kahvaltiTxt.Text = "";
                                        kahvaltiDate.Text = "";
                                        kuslukTxt.Text = "";
                                        kuslukDate.Text = "";
                                        ogleTxt.Text = "";
                                        ogleDate.Text = "";
                                        ikindiTxt.Text = ""; ;
                                        ikindiDate.Text = "";
                                        aksamTxt.Text = "";
                                        aksamDate.Text = "";
                                        araTxt.Text = "";
                                        araDate.Text = "";
                                    }
                                    else
                                    {
                                        MessageBox.Show("Diyet eklenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir Problem Oluştu.");
               
            }

        }

        private async void btn4_Click(object sender, EventArgs e)
        {
            islemler.token = access_token;
            var response = await islemler.ApiGet("admin/users");
            var result = JsonConvert.DeserializeObject<List<Users>>(response.ToString());
            egad.ValueMember = "id";
            egad.DisplayMember = "name";
            egad.DataSource = result;
        }
        //egzersiz

        private async void egkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                ploading.Visible = true;
                egkaydet.Enabled = false;
                egguncel.Enabled = false;
                egsil.Enabled = false;
                egsec.Enabled = false;
                g4.Enabled = false;
                var values = new Dictionary<string, string>
            {
                { "exercise_id",eghareket.SelectedValue.ToString()},
                { "user_id", egad.SelectedValue.ToString() },
                { "exercise_day",eggun.SelectedItem.ToString() },
                { "sets", egset.SelectedItem.ToString() },
                { "reps", egtekrar.SelectedItem.ToString() },
                };
                var response = await islemler.ApiPost("admin/exercise/ekle", values);
                islemler.token = access_token;
                if (response.durum == true)
                {
                    ploading.Visible = false;
                    egkaydet.Enabled = true;
                    egguncel.Enabled = true;
                    g4.Enabled = true;
                    egsec.Enabled = true;
                    egsil.Enabled = true;

                    eggun.Text = "";
                    egbolge.Text = "";
                    eghareket.Text = "";
                    egset.Text = "";
                    egtekrar.Text = "";
                }
                else
                {
                    MessageBox.Show("Egzersiz eklenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //DataGride Cekme
                egdata.Visible = true;

                islemler.token = access_token;
                var response2 = await islemler.ApiGet("admin/exercise/" + egad.SelectedValue.ToString());
                var result2 = JsonConvert.DeserializeObject<List<Exercise2>>(response2.ToString());
                egdata.DataSource = result2;

                egdata.Columns["id"].Visible = false;
                egdata.Columns["exercise_id"].Visible = false;
                egdata.Columns[1].HeaderText = "Bölge";
                egdata.Columns[2].HeaderText = "Hareket";
                egdata.Columns[3].HeaderText = "Gün";
                egdata.Columns[4].HeaderText = "Set";
                egdata.Columns[5].HeaderText = "Tekrar";

            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanında Bir Problem Oluştu.");
            }


        }

        #region EgzersizRes
        private void egbuyut_Click(object sender, EventArgs e)
        {
            egres.Height = 199;
            egres.Width = 253;

            egbuyut.Visible = false;
            egkucult.Visible = true;

        }
        private void egkucult_Click(object sender, EventArgs e)
        {
            egres.Height = 150;
            egres.Width = 190;

            egbuyut.Visible = true;
            egkucult.Visible = false;
        }
        #endregion

        public class Exercise
        {
            public int id { get; set; }
            public string exercise_name { get; set; }

        }
        private async void egbolge_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ctrlHareket == false)
            {
                islemler.token = access_token;
                var response = await islemler.ApiGet("admin/exercise/bolgeCek/" + egbolge.SelectedItem.ToString());
                var result = JsonConvert.DeserializeObject<List<Exercise>>(response.ToString());
                eghareket.ValueMember = "id";
                eghareket.DisplayMember = "exercise_name";
                eghareket.DataSource = result;
                //eghareket.Text = string.Format("{0}", egdata.SelectedRows[0].Cells[2].Value);
            }
            else
            {
                islemler.token = access_token;
                var response = await islemler.ApiGet("admin/exercise/bolgeCek/" + egbolge.SelectedItem.ToString());
                var result = JsonConvert.DeserializeObject<List<Exercise>>(response.ToString());
                eghareket.ValueMember = "id";
                eghareket.DisplayMember = "exercise_name";
                eghareket.DataSource = result;
                eghareket.Text = string.Format("{0}", egdata.SelectedRows[0].Cells[2].Value);
            }
        }

        private void eghareket_SelectedIndexChanged(object sender, EventArgs e)
        {
            egbuyut.Visible = true;
            object O = Resources.ResourceManager.GetObject("_" + eghareket.SelectedValue.ToString());
            egres.Image = (Image)O;
        }
        public class Exercise2
        {
            public int id { get; set; }
            public string region { get; set; }
            public string exercise_name { get; set; }
            public int exercise_day { get; set; }
            public int sets { get; set; }
            public int reps { get; set; }
            public string exercise_id { get; set; }
        }

        private async void egad_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataGride Cekme
            egdata.Visible = true;
            ploading.Visible = true;

            islemler.token = access_token;
            var response2 = await islemler.ApiGet("admin/exercise/" + egad.SelectedValue.ToString());
            var result2 = JsonConvert.DeserializeObject<List<Exercise2>>(response2.ToString());
            egdata.DataSource = result2;

            egdata.Columns["id"].Visible = false;
            egdata.Columns["exercise_id"].Visible = false;
            egdata.Columns[1].HeaderText = "Bölge";
            egdata.Columns[2].HeaderText = "Hareket";
            egdata.Columns[3].HeaderText = "Gün";
            egdata.Columns[4].HeaderText = "Set";
            egdata.Columns[5].HeaderText = "Tekrar";
            ploading.Visible = false;
        }
        private async void egguncel_Click(object sender, EventArgs e)
        {
            try
            {
                ploading.Visible = true;
                egsil.Enabled = false;
                egsec.Enabled = false;
                egguncel.Enabled = false;
                egkaydet.Enabled = false;
                g4.Enabled = false;
                secilen = egdata.CurrentRow.Cells[0].Value.ToString();
                var values = new Dictionary<string, string>
            {
                { "exercise_id",eghareket.SelectedValue.ToString()},
                { "user_id", egad.SelectedValue.ToString() },
                { "exercise_day",eggun.SelectedItem.ToString() },
                { "sets", egset.SelectedItem.ToString() },
                { "reps", egtekrar.SelectedItem.ToString() },
            };
                var response = await islemler.ApiPost("admin/exercise/guncelle/" + secilen, values);
                if (response.durum == true)
                {
                    ploading.Visible = false;
                    egsec.Enabled = true;
                    egguncel.Enabled = true;
                    egkaydet.Enabled = true;
                    g4.Enabled = true;
                    egsil.Enabled = true;

                    eggun.Text = "";
                    egbolge.Text = "";
                    eghareket.Text = "";
                    egset.Text = "";
                    egtekrar.Text = "";
                }
                else
                {
                    MessageBox.Show("Güncelleme Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //DataGride Cekme
                egdata.Visible = true;

                islemler.token = access_token;
                var response2 = await islemler.ApiGet("admin/exercise/" + egad.SelectedValue.ToString());
                var result2 = JsonConvert.DeserializeObject<List<Exercise2>>(response2.ToString());
                egdata.DataSource = result2;

                egdata.Columns["id"].Visible = false;
                egdata.Columns["exercise_id"].Visible = false;
                egdata.Columns[1].HeaderText = "Bölge";
                egdata.Columns[2].HeaderText = "Hareket";
                egdata.Columns[3].HeaderText = "Gün";
                egdata.Columns[4].HeaderText = "Set";
                egdata.Columns[5].HeaderText = "Tekrar";

            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanında Bir Problem Oluştu.");

            }


        }
        bool ctrlHareket = false;
        private void egsec_Click(object sender, EventArgs e)
        {
            egkaydet.Enabled = false;
            ctrlHareket = true;
            egbolge.Text = string.Format("{0}", egdata.SelectedRows[0].Cells[1].Value);
            eghareket.Text = string.Format("{0}", egdata.SelectedRows[0].Cells[2].Value);
            eggun.Text = string.Format("{0}", egdata.SelectedRows[0].Cells[3].Value);
            egset.Text = string.Format("{0}", egdata.SelectedRows[0].Cells[4].Value);
            egtekrar.Text = string.Format("{0}", egdata.SelectedRows[0].Cells[5].Value);
            object O = Resources.ResourceManager.GetObject("_" + egdata.SelectedRows[0].Cells[6].Value);
            egres.Image = (Image)O;
            ctrlHareket = false;

        }

        private async void btnYenile_Click(object sender, EventArgs e)
        {
            try
            {
                ploading.Visible = true;
                islemler.token = access_token;
                var values = new Dictionary<string, string>
            {
                { "oldPassword", txteskiParola.Text},
                { "password", txtyeniParola.Text},
                { "password_confirmation", txtyeniTekrar.Text},
            };
                var response = await islemler.ApiPost("passwordChange", values);
                if (response)
                {
                    MessageBox.Show("Şifreniz değiştirildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ploading.Visible = false;
                    txteskiParola.Text = "";
                    txtyeniParola.Text = "";
                    txtyeniTekrar.Text = "";
                }
                else
                {
                    MessageBox.Show("Şifreniz değiştirilemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanında Bir Problem Oluştu.");
            }
        }

        public class DietType
        {
            public string type { get; set; }
            public string meal { get; set; }
            public string content { get; set; }
            public string time { get; set; }
            public string start_date { get; set; }
            public string end_date { get; set; }
        }
        bool Diyetdegis = false;
        private async void diyetad_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                ploading.Visible = true;
                islemler.token = access_token;
                var response = await islemler.ApiGet("admin/diet/" + diyetad.SelectedValue.ToString());

                var result = JsonConvert.DeserializeObject<List<DietType>>(response.ToString());

                if (result != null)
                {
                    kahvaltiTxt.Text = "";
                    kahvaltiDate.Text = "";
                    kuslukTxt.Text = "";
                    kuslukDate.Text = "";
                    ogleTxt.Text = "";
                    ogleDate.Text = "";
                    ikindiTxt.Text = ""; ;
                    ikindiDate.Text = "";
                    aksamTxt.Text = "";
                    aksamDate.Text = "";
                    araTxt.Text = "";
                    araDate.Text = "";
                    Diyetdegis = true;

                    foreach (var item in result)
                    {
                        baslangicDate.Text = Convert.ToDateTime(item.start_date).ToString("dd MMMM yyyy dddd");
                        bitisDate.Text = Convert.ToDateTime(item.end_date).ToString("dd MMMM yyyy dddd");
                        if (item.type == "Kilo Verme")
                        {
                            diyettur.SelectedItem = "Kilo Verme";
                        }
                        if (item.type == "Kilo Alma")
                        {
                            diyettur.SelectedItem = "Kilo Alma";
                        }
                        if (item.type == "Definasyon")
                        {
                            diyettur.SelectedItem = "Definasyon";
                        }
                        if (item.meal == "Kahvaltı")
                        {
                            kahvaltiTxt.Text = item.content;
                            kahvaltiDate.Text = item.time;

                        }
                        if (item.meal == "Kuşluk")
                        {
                            kuslukTxt.Text = item.content;
                            kuslukDate.Text = item.time;

                        }
                        if (item.meal == "Öğle")
                        {
                            ogleTxt.Text = item.content;
                            ogleDate.Text = item.time;

                        }
                        if (item.meal == "İkindi")
                        {
                            ikindiTxt.Text = item.content;
                            ikindiDate.Text = item.time;

                        }
                        if (item.meal == "Akşam")
                        {
                            aksamTxt.Text = item.content;
                            aksamDate.Text = item.time;

                        }
                        if (item.meal == "Ara")
                        {
                            araTxt.Text = item.content;
                            araDate.Text = item.time;

                        }
                    }
                }
                Diyetdegis = false;
                ploading.Visible = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanında Bir Problem Oluştu.");
            }
        }

        private async void diyettur_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Diyetdegis == false)
                {
                    kahvaltiTxt.Text = "";
                    kahvaltiDate.Text = "";
                    kuslukTxt.Text = "";
                    kuslukDate.Text = "";
                    ogleTxt.Text = "";
                    ogleDate.Text = "";
                    ikindiTxt.Text = ""; ;
                    ikindiDate.Text = "";
                    aksamTxt.Text = "";
                    aksamDate.Text = "";
                    araTxt.Text = "";
                    araDate.Text = "";
                    islemler.token = access_token;
                    var response = await islemler.ApiGet("admin/diet/getType/" + diyettur.SelectedItem.ToString());
                    var result = JsonConvert.DeserializeObject<List<DietType>>(response.ToString());

                    foreach (var item in result)
                    {
                        if (item.type == "Kilo Verme")
                        {
                            diyettur.SelectedItem = "Kilo Verme";
                        }
                        if (item.type == "Kilo Alma")
                        {
                            diyettur.SelectedItem = "Kilo Alma";
                        }
                        if (item.type == "Definasyon")
                        {
                            diyettur.SelectedItem = "Definasyon";
                        }
                        if (item.meal == "Kahvaltı")
                        {
                            kahvaltiTxt.Text = item.content;
                            kahvaltiDate.Text = item.time;
                        }
                        if (item.meal == "Kuşluk")
                        {
                            kuslukTxt.Text = item.content;
                            kuslukDate.Text = item.time;
                        }
                        if (item.meal == "Öğle")
                        {
                            ogleTxt.Text = item.content;
                            ogleDate.Text = item.time;
                        }
                        if (item.meal == "İkindi")
                        {
                            ikindiTxt.Text = item.content;
                            ikindiDate.Text = item.time;
                        }
                        if (item.meal == "Akşam")
                        {
                            aksamTxt.Text = item.content;
                            aksamDate.Text = item.time;
                        }
                        if (item.meal == "Ara")
                        {
                            araTxt.Text = item.content;
                            araDate.Text = item.time;
                        }
                    }
                    if (kahvaltiTxt.Text == "")
                    {
                        kahvaltiTxt.Text = "Bu öğünde yiyeceğiniz bulunmamaktadır.";
                    }
                    if (kuslukTxt.Text == "")
                    {
                        kuslukTxt.Text = "Bu öğünde yiyeceğiniz bulunmamaktadır.";
                    }
                    if (ogleTxt.Text == "")
                    {
                        ogleTxt.Text = "Bu öğünde yiyeceğiniz bulunmamaktadır.";
                    }
                    if (ikindiTxt.Text == "")
                    {
                        ikindiTxt.Text = "Bu öğünde yiyeceğiniz bulunmamaktadır.";
                    }
                    if (aksamTxt.Text == "")
                    {
                        aksamTxt.Text = "Bu öğünde yiyeceğiniz bulunmamaktadır.";
                    }
                    if (araTxt.Text == "")
                    {
                        araTxt.Text = "Bu öğünde yiyeceğiniz bulunmamaktadır.";
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanında Bir Problem Oluştu.");
            }
        }

        private void egdata_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow dgvrow2 in egdata.Rows)
            {
                dgvrow2.DefaultCellStyle.BackColor = Color.LightGray;
            }
        }

        private async void egsil_Click(object sender, EventArgs e)
        {
            try
            {
                sec = egdata.CurrentRow.Cells[2].Value.ToString();
                DialogResult a = MessageBox.Show(sec + " egzersizi silmek istediğinize emin misiniz.", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                ploading.Visible = true;
                egkaydet.Enabled = false;
                egguncel.Enabled = false;
                egsec.Enabled = false;
                g4.Enabled = false;
                egsil.Enabled = false;
                if (a == DialogResult.Yes)
                {
                    secilen = egdata.CurrentRow.Cells[0].Value.ToString();
                    var response = await islemler.ApiGet("admin/exercise/sil/" + secilen);
                    if (response.durum == true)
                    {
                        egdata.Columns["id"].Visible = false;
                        egdata.Columns["exercise_id"].Visible = false;
                        egdata.Columns[1].HeaderText = "Bölge";
                        egdata.Columns[2].HeaderText = "Hareket";
                        egdata.Columns[3].HeaderText = "Gün";
                        egdata.Columns[4].HeaderText = "Set";
                        egdata.Columns[5].HeaderText = "Tekrar";
                        ploading.Visible = false;
                        MessageBox.Show("Egzersiz başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ploading.Visible = false;
                        egkaydet.Enabled = true;
                        egguncel.Enabled = true;
                        g4.Enabled = true;
                        egsec.Enabled = true;
                        egsil.Enabled = true;
                        sec = "";
                        secilen = "";
                    }

                    //DataGride Cekme
                    egdata.Visible = true;

                    islemler.token = access_token;
                    var response2 = await islemler.ApiGet("admin/exercise/" + egad.SelectedValue.ToString());
                    var result2 = JsonConvert.DeserializeObject<List<Exercise2>>(response2.ToString());
                    egdata.DataSource = result2;

                    egdata.Columns["id"].Visible = false;
                    egdata.Columns["exercise_id"].Visible = false;
                    egdata.Columns[1].HeaderText = "Bölge";
                    egdata.Columns[2].HeaderText = "Hareket";
                    egdata.Columns[3].HeaderText = "Gün";
                    egdata.Columns[4].HeaderText = "Set";
                    egdata.Columns[5].HeaderText = "Tekrar";
                }

                else
                {
                    MessageBox.Show("Egzersiz silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanında Bir Problem Oluştu.");
            }

        }
    }
}
