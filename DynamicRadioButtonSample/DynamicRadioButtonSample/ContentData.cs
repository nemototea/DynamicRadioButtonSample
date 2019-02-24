using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicRadioButtonSample
{
    public class Data
    {
        private List<ContentData> sameTerminalList = null;
        // 同番端末リスト
        public List<ContentData> SameTerminalList
        {
            get
            {
                if (sameTerminalList == null)
                {
                    sameTerminalList = new List<ContentData>();
                }
                return sameTerminalList;

            }
            set
            {
                sameTerminalList = value;
            }
        }

        // コンストラクタ
        public Data()
        {
        }

    }


    // 設定したデータを保持するクラス
    // SameTerminalListにAddする際にnewする？
    public class ContentData
    {
        // 登録日
        public String DateOfRegisterdTerminal { get; set; }

        // 製造番号
        public String NumberOfTerminal { get; set; }

        // コンストラクタ
        public ContentData(String i_date, String i_number)
        {
            this.DateOfRegisterdTerminal = i_date;
            this.NumberOfTerminal = i_number;
        }
    }
}
