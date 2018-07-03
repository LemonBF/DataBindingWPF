using DataBinding.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding.ViewModel
{
    class CancionViewModel: INotifyPropertyChanged
    {
        Cancion _cancion;
        public CancionViewModel()
        {
            _cancion = new Cancion("Pepe","Macarena");
        }

        public Cancion Cancion
        {
            get
            {
                return _cancion;
            }
            set
            {
                _cancion = value;
            }
        }

        public string Artista
        {
            get { return Cancion.Artista; }
            set
            {
                if (Cancion.Artista != value)
                {
                    Cancion.Artista = value;
                    RaisePropertyChanged("Artista");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string nombrePropiedad)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(nombrePropiedad));
            }
        }
    }
}
