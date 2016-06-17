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
using System.IO;

namespace WpfDragDropApplication
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

        private void label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //start drag and drop
            DragDrop.DoDragDrop(sender as Label, (sender as Label).Content.ToString(), DragDropEffects.Copy);
        }

        private void label_DragOver(object sender, DragEventArgs e)
        {
            //ドラッグされているものがテキストの場合だけ受け入れる
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effects = DragDropEffects.Copy;
            }
        }

        private void label_Drop(object sender, DragEventArgs e)
        {
            //Drop されたテキストを Content に割り当て
            (sender as Label).Content = e.Data.GetData(DataFormats.Text);
        }

        private void tbox3_PreviewDragOver(object sender, DragEventArgs e)
        {
            //ファイルをドロップされた場合のみe.HandledをTrueにする。
            e.Handled = e.Data.GetDataPresent(DataFormats.FileDrop);
        }

        private void tbox3_Drop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files != null)
            {
                //最初のファイルをSJISテキストとして読み込む
                using (var reader = new StreamReader(files[0], Encoding.GetEncoding("SJIS"))) tbox3.Text = reader.ReadToEnd();
            }
        }
    }
}
