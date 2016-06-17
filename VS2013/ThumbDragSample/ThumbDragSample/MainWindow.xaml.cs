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
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;


namespace ThumbDragSample
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

        private void onDragStarted(object sender, DragStartedEventArgs e)
        {
            myThumb.Background = Brushes.Orange;
            Cursor = Cursors.Hand;
        }

        void onDragDelta(object sender, DragDeltaEventArgs e)
        {
            double yAdjust = myCanvas.Height + e.VerticalChange;
            double xAdjust = myCanvas.Width + e.HorizontalChange;
            if ((xAdjust >= 0) && (yAdjust >= 0))
            {
                myCanvas.Width = xAdjust;
                myCanvas.Height = yAdjust;
            }
        }
        void onDragCompleted(object sender, DragCompletedEventArgs e)
        {
            myThumb.Background = Brushes.CadetBlue;
            Cursor = Cursors.Arrow;
        }
    }
}
