using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eProdaja.WinUI.Forms
{
    public partial class frmProizvodi : Form
    {
        private APIService _vrsteProizvoda = new APIService("VrsteProizvoda");
        private APIService _jediniceMjere = new APIService("JediniceMjere");
        private APIService _proizvodi = new APIService("Proizvod");

        public frmProizvodi()
        {
            InitializeComponent();
        }

        private async void frmProizvodi_Load(object sender, EventArgs e)
        {
            await LoadVrsteProizvoda();
            await LoadJediniceMjere();
            await LoadProizvod(0);
        }

        public async Task LoadVrsteProizvoda()
        {
            var result = await _vrsteProizvoda.GetAll<List<Model.VrsteProizvoda>>(null);
            result.Insert(0, new Model.VrsteProizvoda());
            cmbVrProizvoda.DisplayMember = "Naziv";
            cmbVrProizvoda.ValueMember = "VrstaId";
            cmbVrProizvoda.DataSource = result;
        }

        public async Task LoadJediniceMjere()
        {
            var result = await _jediniceMjere.GetAll<List<Model.JediniceMjere>>(null);
            result.Insert(0, new Model.JediniceMjere());
            cmbJedMjere.DisplayMember = "Naziv";
            cmbJedMjere.ValueMember = "JedinicaMjereId";
            cmbJedMjere.DataSource = result;
        }

        private async void cmbVrProizvoda_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbVrProizvoda.SelectedValue;

            if(int.TryParse(idObj.ToString(),out int id))
            {
                await LoadProizvod(id);
            }
        }

        public async Task LoadProizvod(int vrstaId)
        {
            var result = await _proizvodi.GetAll<List<Model.Proizvod>>(new ProizvodiSearchRequest
            {
                VrstaId = vrstaId
            });

            dgvProizvodi.DataSource = result;
        }

        ProizvodiInsertRequest r = new ProizvodiInsertRequest();

        private async void btn_Sacuvaj_Click(object sender, EventArgs e)
        {

            r.Cijena = decimal.Parse(txtCijena.Text);
            r.Naziv = txtNaziv.Text;
            r.Sifra = txtSifra.Text;
            r.Status = true;

            var idJedMjereObj = cmbVrProizvoda.SelectedValue;

            if (int.TryParse(idJedMjereObj.ToString(), out int idJedMjere))
            {
                r.JedinicaMjereId = idJedMjere;
            }

            var idVrProizvodaObj = cmbVrProizvoda.SelectedValue;

            if (int.TryParse(idVrProizvodaObj.ToString(), out int idVrProizvoda))
            {
                r.VrstaId = idVrProizvoda;
            }


            await _proizvodi.Insert<Model.Proizvod>(r);
            MessageBox.Show("Operacija uspjesna");
        }

        private void btn_DodajImg_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if(result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);
                r.Slika = file;
                txtSlika.Text = fileName;

                Image img = Image.FromFile(fileName);
                pictureBox1.Image = img;
            }
        }
    }
}
