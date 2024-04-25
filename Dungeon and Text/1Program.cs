namespace Dungeon_and_Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
        }

        public Program()
        {
            Console.Clear();
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.\n");

            Console.WriteLine("1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");

            Console.WriteLine("원하시는 행동을 입력해주세요.");

            int select = int.Parse(Console.ReadLine());

            if (select == 1)
            {
                Condition condition = new Condition();
            }
            else if (select == 2)
            {
                Inventory inventory = new Inventory();
            }
            else if (select == 3)
            {
                Shop shop = new Shop();
            }
        }
    }
}
