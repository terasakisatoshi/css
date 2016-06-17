using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonTest();
            MyClassTest();
        }

        public static void PersonTest()
        {
            Console.WriteLine("Hello from Person ");
            var p = new Person();
            p.PropertyChanged += NameChanged;
            p.PropertyChanged += AgeChanged;
            p.Name = "Gomachan";
            p.Age = 100;
            p.Test = "word Test";
            Console.WriteLine("p.Test={0}", p.Test);

        }
        public static void MyClassTest()
        {
            Console.WriteLine("Hello from MyClass");
            var mycls = new MyClass();
            mycls.MyStr = "Hi";
            
        }

        private static void NameChanged(object sender, PropertyChangedEventArgs e)
        {
            Console.WriteLine("EventHandernamed NameChanged is called");
            if (e.PropertyName != "Name")
            {
                return;
            }

            var p = (Person)sender;

            //Do something
            Console.WriteLine("Namge changed....{0}", p.Name);
        }

        private static void AgeChanged(object sender, PropertyChangedEventArgs e)
        {
            Console.WriteLine("EventHandernamed AgeChanged is called");
            if (e.PropertyName != "Age")
            {
                return;
            }

            var p = (Person)sender;
            //Do something
            Console.WriteLine("Age changed....{0}", p.Age);
        }
    }

    public class Person : INotifyPropertyChanged
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (Equals(_name, value))
                {
                    return;
                }

                _name = value;
                OnPropertyChanged("Name");

            }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (Equals(_age, value))
                {
                    return;
                }

                _age = value;
                OnPropertyChanged("Age");
            }
        }

        private string _test;
        public string Test
        {
            get {
                Console.WriteLine("Hello from Test get");
                OnPropertyChanged("Test");
                return _test; 
            }
            set 
            { 
                _test = value;
                Console.WriteLine("Hello from Test set");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged == null)
            {
                return;
            }

            this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }

    public class MyClass:INotifyPropertyChanged
    {
        private string _mystr;
        public string MyStr
        {
            set 
            { 
                _mystr = value;
                RaisePropertyChanged("MyStr");
            }
            get 
            {
                Console.WriteLine("Hello from MyStr property");
                return _mystr;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void RaisePropertyChanged(params string[] propertyNames)
        {
            if (this.PropertyChanged != null)
            {
                foreach (string name in propertyNames)
                {
                    //property names 
                    this.PropertyChanged(this, new PropertyChangedEventArgs(name));
                }
            }
        }   

    }
}
