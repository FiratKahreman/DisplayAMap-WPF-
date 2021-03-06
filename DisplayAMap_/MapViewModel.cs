using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esri.ArcGISRuntime.Geometry;
using Esri.ArcGISRuntime.Mapping;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DisplayAMap_
{
    class MapViewModel : INotifyPropertyChanged
    {
        public MapViewModel()
        {
            SetupMap();
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Map _map;
        public Map Map
        { get { return _map; }
            set
            {
                _map = value;
                OnPropertyChanged();
            }
        }

        private void SetupMap()
        {
            Map = new Map(BasemapStyle.ArcGISTopographic);
        }

    }
}
