using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MVVMDemo{
    public class MyViewModel : ViewModelBase {

        public MyViewModel() {
            MyList = new ObservableCollection<MyModel>();
            MyList.Add(new MyModel("ABC", 12));
            MyList.Add(new MyModel("DEF", 13));
        }

        ObservableCollection<MyModel> _MyList;
        public ObservableCollection<MyModel> MyList {
            get {
                if (_MyList == null) {
                    _MyList = new ObservableCollection<MyModel>();
                }
                return _MyList;
            }
            set {
                _MyList = value;
                OnPropertyChanged("MyList");
            }
        }

        void AddRow() {
            MyList.Add(new MyModel("Somebody", 2));
        }
        RelayCommand _AddRowCommand;
        public ICommand AddRowCommand {
            get {
                if (_AddRowCommand == null) {
                    _AddRowCommand = new RelayCommand(x=>AddRow());
                }
                return _AddRowCommand;
            }
        }
    }
}
