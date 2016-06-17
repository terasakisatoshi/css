using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.ComponentModel.Composition;

namespace MyPrism
{
    /// <summary>
    /// SampleView.xaml の相互作用ロジック
    /// </summary>
    [Export("SampleView",typeof(SampleView))]
    public partial class SampleView : UserControl
    {
        public SampleView()
        {
            InitializeComponent();
        }
    }
}
