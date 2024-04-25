using Dungeon_and_Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_and_Text
{

    internal class Equip : ItemData
    {

        private static Equip instance;

        public static Equip Getinstance()
        {
            if (instance == null)
            {
                instance = new Equip();
            }
            return instance;
        }

            public Equip()
        {
            Console.Clear();
            Console.WriteLine("[인벤토리 - 장착관리]");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine();

            Console.WriteLine("[아이템 목록]");
            

        }
    }
}

internal class Shop : ItemData
{
    private static Shop instance;

    public static Shop Getinstance()
    {
        if (instance == null)
        {
            instance = new Shop();
        }
        return instance;
    }

    public Shop()
    {
        string getItemData = GetItemData();
        playergold = 800;
        Console.Clear();
        Console.WriteLine("[상점]");
        Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다");
        Console.WriteLine();

        Console.WriteLine("[보유 골드]");
        Console.WriteLine(playergold + "G");
        Console.WriteLine();

        Console.WriteLine("[아이템 목록]");
        Console.WriteLine(getItemData);
        Console.WriteLine();

        Console.WriteLine("1. 아이템 구매");
        Console.WriteLine("0. 나가기");

        int select = int.Parse(Console.ReadLine());

        if (select == 0)
        {
            Program program = new Program();
        }
        else if (select == 1)
        {
            BuyingRoom buyingRoom = new BuyingRoom();
        }
    }
}

internal class BuyingRoom : ItemData
{
    public BuyingRoom()
    {
        playergold = 800;
        int select = -1;
        string getItemData = GetItemData();
        var itemdata = 
        
        


        while (select != 0)
        {
            Console.Clear();
            Console.WriteLine("[상점 - 아이템 구매]");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine();

            Console.WriteLine("[보유 골드]");
            Console.WriteLine(playergold + "G");

            Console.WriteLine("[아이템 목록]");
            Console.WriteLine(getItemData);

            Console.WriteLine("구매하실 아이템의 번호를 입력해주세요");
            select = int.Parse(Console.ReadLine());

            if (select == 0)
            {
                Program program = new Program();
            }
            else if (select == 1)
            {
                if (playergold >= 3000)
                {
                    playergold -= 3000;
                    buying = true;
                }
                else 
                {
                    Console.WriteLine("Gold가 부족합니다!");
                    Console.ReadLine();
                    BuyingRoom buyingRoom = new BuyingRoom();
                }
            }
            else if (select == 2)
            {
                if (playergold >= 1000)
                {
                    playergold -= 1000;
                    itemList[1].buying = true;
                }
                else
                {
                    Console.WriteLine("Gold가 부족합니다!");
                    Console.ReadLine();
                    BuyingRoom buyingRoom = new BuyingRoom();
                }
            }
            else if (select == 3)
            {
                if (playergold >= 5000)
                {
                    playergold -= 5000;
                    buying = true;
                }
                else
                {
                    Console.WriteLine("Gold가 부족합니다!");
                    Console.ReadLine();
                    BuyingRoom buyingRoom = new BuyingRoom();
                }
            }
            else if (select == 4)
            {
                if (playergold >= 500)
                {
                    playergold -= 500;
                    buying = true;
                }
                else
                {
                    Console.WriteLine("Gold가 부족합니다!");
                    Console.ReadLine();
                    BuyingRoom buyingRoom = new BuyingRoom();
                }
            }
        }    
    }
}
