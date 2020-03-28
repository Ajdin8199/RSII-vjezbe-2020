using System;
using System.Collections.Generic;
using System.Windows.Forms;
using eProdaja.Model;
using eProdaja.Model.Requests;
using Flurl.Http;

namespace eProdaja.WinUI
{
    public partial class frmKorisnici : Form
    {
        APIService korisniciService = new APIService("Korisnici");

        public frmKorisnici()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            KorisniciSearchRequest searchRequest = new KorisniciSearchRequest()
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text
            };
            var list = await korisniciService.GetAll<List<Korisnici>>(searchRequest);

            dgvKorisnici.DataSource = list;
        }

        private void dgvKorisnici_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvKorisnici.SelectedRows[0].DataBoundItem;

            frmKorisniciDetalji frm = new frmKorisniciDetalji(item as Korisnici);
            //frm.Show();
            frm.ShowDialog();
        }
    }
}
