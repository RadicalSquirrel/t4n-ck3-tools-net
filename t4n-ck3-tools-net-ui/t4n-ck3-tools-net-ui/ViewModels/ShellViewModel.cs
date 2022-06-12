using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace t4n_ck3_tools_net_ui.ViewModels
{
    class ShellViewModel : Screen
    {
        private string _cultureGroupname = "Default_Culture_Group";
        public string CultureGroupName
        {
            get { return _cultureGroupname; }
            set
            {
                _cultureGroupname = value;
                NotifyOfPropertyChange(() => CultureGroupName);
            }
        }
        private string _cultureName = "Default Culture";

        public string CultureName
        {
            get { return _cultureName; }
            set {
                _cultureName = value;
                NotifyOfPropertyChange(() => CultureName);
            }
        }

        private int _cultureColor1 = 0;

        public int CultureColor1
        {
            get { return _cultureColor1; }
            set { _cultureColor1 = value;
                NotifyOfPropertyChange(() => CultureColor1);
                NotifyOfPropertyChange(() => CultureColor);
            }
        }

        private int _cultureColor2;

        public int CultureColor2
        {
            get { return _cultureColor2; }
            set { _cultureColor2 = value;
                NotifyOfPropertyChange(() => CultureColor2);
                NotifyOfPropertyChange(() => CultureColor);
            }
        }

        private int _cultureColor3;

        public int CultureColor3
        {
            get { return _cultureColor3; }
            set
            {
                _cultureColor3 = value;
                NotifyOfPropertyChange(() => CultureColor3);
                NotifyOfPropertyChange(() => CultureColor);
            }
        }
        
        public string CultureColor
        {
            get { return $"{CultureColor1} {CultureColor2} {CultureColor3}"; }
        }

    }
}
