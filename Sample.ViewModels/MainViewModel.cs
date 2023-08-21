using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Sample.MVVM;


namespace Sample.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public string MyText { get; set; }

        public int Counter { get; set; }
        public ICommand CoundUpCommand { get; set; }

        public MainViewModel()
        {
            this.Counter = 0;
            this.CoundUpCommand = new RelayCommand(this.CountUp);
        }

        public void CountUp()
        {
            this.Counter += 1;
        }
    }
}
