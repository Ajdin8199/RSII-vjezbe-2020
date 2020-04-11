using eProdaja.Model;
using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eProdaja.WinUI
{
    public partial class frmKorisniciDetalji : Form
    {
        APIService korisniciService = new APIService("Korisnici");
        APIService ulogeService = new APIService("Uloge");

        private Korisnici _korisnik;

        public frmKorisniciDetalji(Korisnici korisnik = null)
        {
            InitializeComponent();
            _korisnik = korisnik;
        }

        private async void frmKorisniciDetalji_Load(object sender, EventArgs e)
        {
            await LoadUloge();
            if (_korisnik != null)
            {
                var korisnik = await korisniciService.GetById<Model.Korisnici>(_korisnik.KorisnikId);
                txtIme.Text = _korisnik.Ime;
                txtPrezime.Text = _korisnik.Prezime;
                txtUsername.Text = _korisnik.KorisnickoIme;
                txtEmail.Text = _korisnik.Email;
                chkStatus.Checked = _korisnik.Status.GetValueOrDefault(false);
                txtTelefon.Text = _korisnik.Telefon;
                txtPassword.ReadOnly = true;
                txtPotvrda.ReadOnly = true;
                txtUsername.ReadOnly = true;
            }
        }

        private async Task LoadUloge()
        {
            var uloge = await ulogeService.GetAll<List<Uloge>>();
            clbUloge.DataSource = uloge;
            clbUloge.DisplayMember = "Naziv";
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (_korisnik == null)
                {
                    var ulogeList = clbUloge.CheckedItems.Cast<Uloge>();
                    var ulogeIdList = ulogeList.Select(x => x.UlogaId).ToList();
                    // insert
                    KorisniciInsertRequest request = new KorisniciInsertRequest
                    {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        Email = txtEmail.Text,
                        KorisnickoIme = txtUsername.Text,
                        Password = txtPassword.Text,
                        PasswordPotvrda = txtPotvrda.Text,
                        Status = chkStatus.Checked,
                        Telefon = txtTelefon.Text,
                        Uloge = ulogeIdList
                    };
                    var korisnik = await korisniciService.Insert<Korisnici>(request);
                }
                else
                {
                    var ulogeList = clbUloge.CheckedItems.Cast<Uloge>();
                    var ulogeIdList = ulogeList.Select(x => x.UlogaId).ToList();
                    // update
                    KorisniciUpdateRequest request = new KorisniciUpdateRequest
                    {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        Status = chkStatus.Checked,
                        Telefon = txtTelefon.Text,
                        Email = txtEmail.Text,
                        Uloge = ulogeIdList
                    };

                    var korisnik = await korisniciService.Update<Korisnici>(_korisnik.KorisnikId, request);
                }

                MessageBox.Show("Operacija uspjesna");
                this.Close();
            }
        }


        // VALIDACIJA

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                errorProvider.SetError(txtIme, Properties.Resources.Validation_Key);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                errorProvider.SetError(txtPrezime, Properties.Resources.Validation_Key);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, Properties.Resources.Validation_Key);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if(_korisnik == null)
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text) || txtUsername.Text.Length <= 3)
                {
                    errorProvider.SetError(txtUsername, "Obavezno polje i minimalno 4 karaktera");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(txtUsername, null);
                }
            }
        }
        
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (_korisnik == null)
            {
                if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text.Length <= 3)
                {
                    errorProvider.SetError(txtPassword, "Obavezno polje i minimalno 4 karaktera");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(txtPassword, null);
                }
            }
        }

        private void txtPotvrda_Validating(object sender, CancelEventArgs e)
        {
            if (_korisnik == null)
            {
                if (string.IsNullOrWhiteSpace(txtPotvrda.Text) || txtPotvrda.Text.Length <= 3)
                {
                    errorProvider.SetError(txtPotvrda, "Obavezno polje i minimalno 4 karaktera");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(txtPotvrda, null);
                }
            }
        }
    }
}
