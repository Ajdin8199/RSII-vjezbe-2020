using eProdaja.Model;
using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eProdaja.Mobile.ViewModels
{
    public class ProizvodiViewModel : BaseViewModel
    {
        private readonly APIService _proizvodiService = new APIService("Proizvod");
        private readonly APIService _vrsteProizvodaService = new APIService("VrsteProizvoda");

        public ProizvodiViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Proizvod> ProizvodiList { get; set; } = new ObservableCollection<Proizvod>();
        public ObservableCollection<VrsteProizvoda> VrsteProizvodaList { get; set; } = new ObservableCollection<VrsteProizvoda>();

        VrsteProizvoda _selectedVrstaProizvoda = null;
        public VrsteProizvoda SelectedVrstaProizvoda
        {
            get { return _selectedVrstaProizvoda; }
            set { 
                SetProperty(ref _selectedVrstaProizvoda, value);
                if (value != null)
                    InitCommand.Execute(null);
            }
        }

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            if(VrsteProizvodaList.Count() == 0)
            {
                var listVrsteProizvodi = await _vrsteProizvodaService.Get<List<VrsteProizvoda>>(null);

                foreach (var vrsteProizvoda in listVrsteProizvodi)
                {
                    VrsteProizvodaList.Add(vrsteProizvoda);
                }
            }

            if(SelectedVrstaProizvoda != null)
            {
                ProizvodiSearchRequest request = new ProizvodiSearchRequest
                {
                    VrstaId = SelectedVrstaProizvoda.VrstaId
                };

                var listProizvodi = await _proizvodiService.Get<IEnumerable<Proizvod>>(request);

                ProizvodiList.Clear();
                foreach (var proizvod in listProizvodi)
                {
                    ProizvodiList.Add(proizvod);
                }
                return;
            }

            var listProizvodii = await _proizvodiService.Get<IEnumerable<Proizvod>>(null);

            ProizvodiList.Clear();
            foreach (var proizvod in listProizvodii)
            {
                ProizvodiList.Add(proizvod);
            }
        }
    }
}
