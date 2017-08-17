/***************************************************
*创建人:rixiang.yu
*创建时间:2017/8/16 18:00:46
*功能说明:<Function>
*版权所有:<Copyright>
*Frameworkversion:4.6.1
*CLR版本：4.0.30319.42000
***************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Controls.Primitives;
using System.Collections.ObjectModel;

namespace MVVMGridDemo
{
    /// <summary>
    /// ViewModel
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<ItemData> _itemdatas;

        private string _texxt;
        public string TexxT
        {
            get { return this._texxt; }
            set
            {
                this._texxt = value;
                OnPropertyChanged("TexxT");
            }
        }
        public ObservableCollection<ItemData> ItemDatas
        {
            get { return _itemdatas; }
            set
            {
                this._itemdatas = value;
                OnPropertyChanged("ItemDatas");
            }
        }

        public ICommand ButtonClick
        {
            get
            {

                return new ActionCommand<DataGrid>(p => BClick(p));
            }
        }

        private void BClick(object obj)
        {

            DataGrid box = (DataGrid)obj;

            ItemDatas[0].Title = TexxT;
            box.Items.Refresh();

        }

    }
}


