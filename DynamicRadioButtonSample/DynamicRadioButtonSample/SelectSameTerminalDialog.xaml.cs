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
using System.Windows.Shapes;

namespace DynamicRadioButtonSample
{
    /// <summary>
    /// SelectSameTerminalDialog.xaml の相互作用ロジック
    /// </summary>
    public partial class SelectSameTerminalDialog : Window
    {
        SelectSameTerminalViewModel ssViewModel;

        public SelectSameTerminalDialog(Data i_data)
        {
            InitializeComponent();

            // ViewModelのインスタンス生成
            ssViewModel = new SelectSameTerminalViewModel(i_data);

            this.DataContext = ssViewModel;
            this.SameTerminalListBox.ItemsSource = ssViewModel.SameTerminalValue;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // 閉じる
            this.Close();
        }
    }
}
