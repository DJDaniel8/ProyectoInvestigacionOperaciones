using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoInvestigacionOperaciones.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            informacionViewModel = new InformacionViewModel();
            maximizacionViewModel = new MaximizacionViewModel();
            minimizacionViewModel = new MinimizacionViewModel();
            dualViewModel = new DualViewModel();
            maximizacionViewModel.ControlVisibility = System.Windows.Visibility.Collapsed;
        }
        public InformacionViewModel informacionViewModel { get; set; }
        public MaximizacionViewModel maximizacionViewModel { get; set; }
        public MinimizacionViewModel minimizacionViewModel { get; set; }
        public DualViewModel dualViewModel { get; set; }

        private bool _InformacionChecked = true;
        public bool InformacionChecked
        {
            get
            {
                return _InformacionChecked;
            }
            set
            {
                _InformacionChecked = value;
                if (value) informacionViewModel.ControlVisibility = System.Windows.Visibility.Visible;
                else informacionViewModel.ControlVisibility = System.Windows.Visibility.Collapsed;
                OnPropertyChanged(nameof(InformacionChecked));
            }
        }

        private bool _MaximizacionChecked = false;
        public bool MaximizacionChecked
        {
            get
            {
                return _MaximizacionChecked;
            }
            set
            {
                _MaximizacionChecked = value;
                if (value) maximizacionViewModel.ControlVisibility = System.Windows.Visibility.Visible;
                else maximizacionViewModel.ControlVisibility = System.Windows.Visibility.Collapsed;
                OnPropertyChanged(nameof(MaximizacionChecked));
            }
        }

        private bool _MinimizacionChecked = false;
        public bool MinimizacionChecked
        {
            get
            {
                return _MinimizacionChecked;
            }
            set
            {
                _MinimizacionChecked = value;
                if (value) minimizacionViewModel.ControlVisibility = System.Windows.Visibility.Visible;
                else minimizacionViewModel.ControlVisibility = System.Windows.Visibility.Collapsed;
                OnPropertyChanged(nameof(MinimizacionChecked));
            }
        }

        private bool _DualChecked = false;
        public bool DualChecked
        {
            get
            {
                return _DualChecked;
            }
            set
            {
                _DualChecked = value;
                if (value) dualViewModel.ControlVisibility = System.Windows.Visibility.Visible;
                else dualViewModel.ControlVisibility = System.Windows.Visibility.Collapsed;
                OnPropertyChanged(nameof(DualChecked));
            }
        }
    }
}
