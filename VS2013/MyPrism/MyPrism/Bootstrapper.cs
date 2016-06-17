using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.MefExtensions;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;

namespace MyPrism
{
    public class Bootstrapper:MefBootstrapper
    {
        //MEFカタログ初期化
        protected override void ConfigureAggregateCatalog()
        {
            base.ConfigureAggregateCatalog();
            this.AggregateCatalog.Catalogs.Add(
                new AssemblyCatalog(Assembly.GetExecutingAssembly()));
            this.AggregateCatalog.Catalogs.Add(new DirectoryCatalog("."));
        }
        //Shellの作成
        protected override DependencyObject CreateShell()
        {
            return this.Container.GetExportedValue<Shell>();
        }
        //Windowの作成
        protected override void InitializeShell()
        {
            base.InitializeShell();
            Application.Current.MainWindow = this.Shell as Window;
            Application.Current.MainWindow.Show();
        }


    }
}
