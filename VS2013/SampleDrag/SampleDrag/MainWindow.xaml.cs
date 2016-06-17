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

namespace SampleDrag
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

        private void printPos(UIElement e1)
        {
            int x = (int)Canvas.GetLeft(e1);
            int y = (int)Canvas.GetTop(e1);
            textPos.Text = string.Format("x:{0} y:{1}", x, y);
        }

        private bool _isDrag = false;
        private Point _dragOffset;

        /// <summary>
        /// ドラッグ開始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e1"></param>
        private void mark0_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            UIElement e1 = sender as UIElement;
            if (e1 != null)
            {
                _isDrag = true;
                _dragOffset = e.GetPosition(e1);
                e1.CaptureMouse();
            }
        }

        /// <summary>
        /// ドラッグ終了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mark0_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (_isDrag == true)
            {
                UIElement e1 = sender as UIElement;
                e1.ReleaseMouseCapture();
                _isDrag = false;
            }
        }

        /// <summary>
        /// ドラッグ中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mark0_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDrag == true)
            {
                Point pt = Mouse.GetPosition(board);
                UIElement e1 = sender as UIElement;
                Canvas.SetLeft(e1, pt.X - _dragOffset.X);
                Canvas.SetTop(e1, pt.Y - _dragOffset.Y);
                printPos(e1);
            }
        }
    }
}
