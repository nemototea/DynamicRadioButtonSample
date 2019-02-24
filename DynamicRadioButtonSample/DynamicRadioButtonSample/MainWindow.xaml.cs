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
using System.Collections.ObjectModel;

namespace DynamicRadioButtonSample
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel viewModel;
        public Data data;

        // ☆★☆単に、サーバーから同番リスト取得＆格納して画面表示する部分の前処理を代替してるだけの画面！！！
        public MainWindow()
        {
            InitializeComponent();

            // とりあえず親画面がデータリストのクラス生成
            data = new Data();

            // ViewModelのインスタンス作成＆DataContextに設定。
            viewModel = new MainWindowViewModel();
            this.DataContext = viewModel;
            this.SameTerminalListBox.ItemsSource = viewModel.SameTerminalValue;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // ホントはVMのCommandで実行するイメージ。面倒なのでイベント処理。

            // テキストボックスの入力値をデータクラスに格納
            //// ★本来、DataContextに設定したViewModelのプロパティのgetで取得する
            data.SameTerminalList.Add(new ContentData(textBox1.Text, textBox2.Text));

            // ラジオボタン追加処理
            viewModel.AddRadioButton(textBox1.Text, textBox2.Text);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            SelectSameTerminalDialog sameTerminalDialog = new SelectSameTerminalDialog(data);
            sameTerminalDialog.ShowDialog();
        }
    }

}
