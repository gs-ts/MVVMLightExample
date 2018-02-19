using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MVVMLightExample.Model;
using MVVMLightExample.Repository;

namespace MVVMLightExample.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        private Section1Model _section1Model;
        private MockService service;
        private int _value1;
        private int _value2;
        private int _sum;

        public RelayCommand GenerateValuesCommand { get; private set; }
        public RelayCommand CalculateSumCommand { get; private set; }

        public MainViewModel()
        {
            GenerateValuesCommand = new RelayCommand(() => GenerateValuesExecute(), () => true);
            CalculateSumCommand = new RelayCommand(() => CalculateSumExecute(), () => true);

            service = new MockService();
            Section1Model = service.GenerateModel();
        }

        public void GenerateValuesExecute()
        {
            Section1Model = service.GenerateModel();
        }

        public void CalculateSumExecute()
        {
            Sum = Value1 + Value2;
        }

        public Section1Model Section1Model
        {
            get
            {
                return _section1Model;
            }
            set
            {
                _section1Model = value;
                RaisePropertyChanged(nameof(Section1Model));
            }
        }

        public int Value1
        {
            get
            {
                return _value1;
            }
            set
            {
                _value1 = value;
                RaisePropertyChanged(nameof(Value1));
            }
        }

        public int Value2
        {
            get
            {
                return _value2;
            }
            set
            {
                _value2 = value;
                RaisePropertyChanged(nameof(Value2));
            }
        }

        public int Sum
        {
            get
            {
                return _sum;
            }
            set
            {
                _sum = value;
                RaisePropertyChanged(nameof(Sum));
            }
        }

    }
}