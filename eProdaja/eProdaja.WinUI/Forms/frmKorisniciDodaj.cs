using eProdaja.Model.Requests;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace eProdaja.WinUI.Forms
{
    public partial class frmKorisniciDodaj : Form
    {
        APIService korisniciService = new APIService("Korisnici");

        public frmKorisniciDodaj()
        {
            InitializeComponent();
        }

        private void frmKorisniciDodaj_Load(object sender, EventArgs e)
        {

        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            // ne radi
            //KorisniciInsertRequest req = new KorisniciInsertRequest
            //{
            //    Ime = txtIme.Text,
            //    Prezime = txtPrezime.Text,
            //    Email = txtEmail.Text,
            //    KorisnickoIme = txtKorisnickoIme.Text,
            //    Status = ckbStatus.Checked,
            //    Telefon = txtTelefon.Text,
            //    Password = "test",
            //    PasswordPotvrda = "test"
            //};

            //var entity = await korisniciService.Post<Model.Korisnici>(req);

            // radi
            var req = new
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Email = txtEmail.Text,
                KorisnickoIme = txtKorisnickoIme.Text,
                Status = ckbStatus.Checked,
                Telefon = txtTelefon.Text,
                Password = "test",
                PasswordPotvrda = "test"
            };

            var entity = await korisniciService.Post<Model.Korisnici>(req);

            if (entity != null)
                MessageBox.Show("Uspjesno dodano!");

            Close();
        }
    }
}
