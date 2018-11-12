using FSBeheer.Model;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSBeheer.ViewModel
{
    public class BaseViewModel : ViewModelBase
    {
        protected FSContext _Context;

        public object Items { get; set; }
        public object SelectedItem { get; set; }
    }
}
