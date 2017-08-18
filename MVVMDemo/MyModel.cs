using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemo{
    public class MyModel {

        public MyModel(string name, int age) {
            Name = name;
            Age = age;
        }

        public string Name {
            get;
            set;
        }

        int _Age;
        public int Age {
            get { return _Age; }
            set {
                if (value > 0) {
                    _Age = value;
                } else {
                    throw new ArgumentException("Age must be greater than zero.");
                }
            }
        }
    }
}
