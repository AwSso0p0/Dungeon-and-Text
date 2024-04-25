using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_and_Text
{
    internal class Inventory : ItemData
    {
        public Inventory()
        {
            Console.Clear();
            Console.WriteLine("[인벤토리]");
            Console.WriteLine("보유중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine();

            Console.WriteLine("[아이템 목록]");
            Console.WriteLine();
            Console.WriteLine("1. 장착 관리");
            Console.WriteLine("0. 나가기");

            Console.WriteLine("원하시는 행동을 입력해주세요.");

            int select = int.Parse(Console.ReadLine());

            if (select == 0)
            {
                Program program = new Program();
            }
            else if (select == 1)
            {
                
                
            }
        }
    }
}
