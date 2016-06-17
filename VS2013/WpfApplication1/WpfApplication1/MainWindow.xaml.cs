using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("HELLO");
        }
    }

    class MainWindowModel:INotifyPropertyChanged
    {
        public string Message { get { return "Hello from WPF"; } }

        public event PropertyChangedEventHandler PropertyChanged;

        void RaisePropertyChanged(params string[] propertyNames)
        {
            if (this.PropertyChanged != null)
            {
                foreach(string name in propertyNames)
                {
                    //property names 
                    this.PropertyChanged(this, new PropertyChangedEventArgs(name));
                }
            }
        }   

        bool isAgreed;
        public bool IsAgreed
        {
            get { return isAgreed; }
            set 
            {
                isAgreed = value;
                //実行するプロパティを入れなさい。
                this.RaisePropertyChanged("IsAgreed", "NextButtonVisibility","Hoge");
            }
        }

        public Visibility NextButtonVisibility
        {
            get { return this.IsAgreed ? Visibility.Visible : Visibility.Collapsed; }
        }

        private Visibility _hoge;
        public Visibility Hoge
        {
            get { return this.IsAgreed ? Visibility.Visible : Visibility.Collapsed; }
        }

    }
}

