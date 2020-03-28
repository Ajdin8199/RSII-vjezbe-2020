using eProdaja.Model;
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
        private Korisnici _korisnik;

        public frmKorisniciDetalji(Korisnici korisnik = null)
        {
            InitializeComponent();
            _korisnik = korisnik;
        }

        private void frmKorisniciDetalji_Load(object sender, EventArgs e)
        {
            if (_korisnik != null)
            {
                txtIme.Text = _korisnik.Ime;
                txtPrezime.Text = _korisnik.Prezime;
                txtUsername.Text = _korisnik.KorisnickoIme;
            }
        }
    }
}
