using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_and_Text
{
    internal class ItemData
    {

        private static ItemData instance;

        public static ItemData Getinstance()
        {
            if (instance == null)
            {
                instance = new ItemData();
            }
            return instance;
        }

        public int gold;
        static public int playergold;
        public int idx;
        public string itemName;
        public int atk;
        public int def;
        public string description;
        public bool buying;


        public ItemData()
        {
            playergold = 800;
        }

        static public List<ItemData> itemData1()
        {
            List<ItemData> dt = new List<ItemData>();
            dt.Add(new ItemData() { idx = 1, itemName = "창", atk = 10, def = 0, description = "일반적인 창이다.",buying = false, gold = 3000});
            dt.Add(new ItemData() { idx = 2, itemName = "단검", atk = 5, def = 0, description = "짧은 검이다.",buying = false, gold = 500});
            dt.Add(new ItemData() { idx = 3, itemName = "사각방패", atk = 0, def = 10, description = "방패의 면적이 넓다.", buying = false, gold = 5000});
            dt.Add(new ItemData() { idx = 4, itemName = "삼각방패", atk = 0, def = 8, description = "사각 방패보다는 작다.", buying = false, gold = 300});
            dt.Add(new ItemData() { idx = 5, itemName = "혈혜도", atk = 150, def = 0, description = "\"인간이 가장 지혜로워 질 때는 피를 흘릴때다\" 라고 쓰여있다.", buying = false, gold = 3000000});
            dt.Add(new ItemData() { idx = 6, itemName = "에트의 정령", atk = 1000, def = 0, description = "에트의 정령을 받아들인다.", buying = false, gold = 50000000});

            return dt;
        }
        public string GetItemData()
        {
            List<ItemData> itemList = itemData1();
            
            StringBuilder sb = new StringBuilder();
            foreach (ItemData item in itemList)
            {
                sb.AppendLine(string.Format("{0} | {1} | {2} | {3} {4}", item.idx, item.itemName, item.atk == 0 ? "Def" + item.def : "Atk" + item.atk, item.description, item.buying ? "구매 완료" : ""));
            }
            return sb.ToString();
        }

        public void Buying()
        {
            
            playergold -= gold;
        }
    }
}
