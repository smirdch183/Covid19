using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Covid19.ViewModels.Base;

namespace Covid19.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _Title = "Анализ статистики Cv19";
        public string Title
        {
            get => _Title;
            //set
            //{
            //    if (Equals(_Title, value)) return;
            //    _Title = value;
            //    OnPropertyChanged();
            //    Set(ref _Title, value);
            //}
            set => Set(ref _Title, value);
        }
    }
}
