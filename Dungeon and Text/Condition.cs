using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_and_Text
{
    internal class Condition : ItemData
    {
        private static Condition instance;

        public static Condition Getinstance()
        {
            if (instance == null)
            {
                instance = new Condition();
            }
            return instance;
        }

        static int lv = 1;
        static string name = "LaBa101";
        static string job = "궁수";
        static int atk;

        public Condition()
        {
            int baseAtk;
            baseAtk = 10;
            baseAtk += atk;

            Console.Clear();
            Console.WriteLine("상태 보기");
            Console.WriteLine("캐릭터의 정보가 표시됩니다.");
            Console.WriteLine();

            Console.WriteLine("캐릭터의 Lv : "+lv);
            Console.WriteLine(name + " ( " + job + " )");
            Console.WriteLine("공격력 : " + baseAtk);
            Console.WriteLine();

            Console.WriteLine("0. 나가기");
            int select = int.Parse(Console.ReadLine());

            while (true)
            {
                if (select == 0)
                {
                    Program program = new Program();
                    break;
                }
                else
                {
                    Condition condition = new Condition();
                    break;
                }

            }
            
        }

        public int EquipItem(int plus)
        {
            int plusAtk = 0;
            plusAtk += plus;

            return plusAtk;
        }
    }
}
