using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMGridDemo
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainViewModel mode = new MainViewModel();
            mode.ItemDatas = new ObservableCollection<ItemData>();
            mode.ItemDatas.Add(new ItemData { Title = "TST", Content = "sss" });
            mode.ItemDatas.Add(new ItemData { Title = "2TST", Content = "2sss" });
            
            MainWindow main = new MVVMGridDemo.MainWindow();
            main.DataContext = mode;
            main.Show();
        }
    }
}
