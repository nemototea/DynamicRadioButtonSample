using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicRadioButtonSample
{
    public class SelectSameTerminalViewModel
    {
        // メンバ変数
        private String m_DateHead = "登録日 ： ";
        private String m_NumberHead = "製造番号 : ";

        #region Binfingプロパティ
        // ラジオボタン内容
        private List<tempData> sameterminalvalue = null;
        public List<tempData> SameTerminalValue
        {
            get
            {
                if (sameterminalvalue == null)
                {
                    sameterminalvalue = new List<tempData>();
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
        public SelectSameTerminalViewModel(Data i_data)
        {
            //SameTerminalValue = i_data.SameTerminalList;
            ConvertTerminalInfoForContent(i_data.SameTerminalList);
        }

        private void ConvertTerminalInfoForContent(List<ContentData> i_data)
        {
            String tempDate;
            String tempNumber;
            String result;

            for (Int32 i = 0; i < i_data.Count; i++)
            {
                tempDate = i_data[i].DateOfRegisterdTerminal;
                tempNumber = i_data[i].NumberOfTerminal;
                result = m_DateHead + tempDate + Environment.NewLine +
                     m_NumberHead + tempNumber;

                SameTerminalValue.Add(new tempData(result));
                    
            }
        }
    }
}
