using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicRadioButtonSample
{
    // ☆★☆単にDataクラスに追加した情報を表示させてみたいだけ
    public class MainWindowViewModel
    {
        // メンバ変数
        private String m_DateHead = "登録日 : ";
        private String m_NumberHead = "製造番号 : ";

        #region Binfingプロパティ
        // ラジオボタンのコンテンツ
        private ObservableCollection<tempData> sameterminalvalue = null;
        public ObservableCollection<tempData> SameTerminalValue
        {
            get
            {
                if (sameterminalvalue == null)
                {
                    sameterminalvalue = new ObservableCollection<tempData>();
                }

                return sameterminalvalue;
            }
            set
            {
                sameterminalvalue = value;
            }
        }
        #endregion

        // コンストラクタ
        public MainWindowViewModel()
        {
        }

        public void AddRadioButton(String i_date, String i_number)
        {
            // Content用文字列作成
            String result = CombineText(i_date, i_number);

            // stackpanelの要素に追加する
            SameTerminalValue.Add(new tempData(result));
        }


        private String CombineText(String i_date, String i_number)
        {
            // 初期化
            String result = String.Empty;

            // RadioButtonのContentに表示する内容を作成。
            result = m_DateHead + i_date + Environment.NewLine +
                     m_NumberHead + i_number;

            return result;
        }
    }

    public class tempData
    {
        public String radioContent { get; set; }

        public tempData(String i_content)
        {
            this.radioContent = i_content;
        }
    }
}
