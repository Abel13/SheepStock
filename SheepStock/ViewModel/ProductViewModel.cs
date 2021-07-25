using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheepStock.ViewModel
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; NotifyPropertyChanged("Name"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
