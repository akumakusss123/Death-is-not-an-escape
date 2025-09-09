using System;
using System.Threading;

namespace Death_is_not_an_escape
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool hasBedArtifact = false; //  артефакт под кроватью
            bool hasVentArtifact = false; // артефакт из вентиляции  
            bool hasTableArtifact = false; // артефакт с тумбочки
            bool hasKey = false;  // ключ от ящика
            bool hasCrowbar = false; // отмычка от двери
            bool isFreeFromChains = false;// свободен от цепей


            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed; // Арт из символов by Sasha
            Console.WriteLine("================================================");
            Console.WriteLine("                 ESCAPE: ВЫХОД                  ");
            Console.WriteLine("================================================");
            Console.ResetColor();

            Console.WriteLine("┌─────────────────────────────────────────────────┐");
            Console.WriteLine("│         ╔═══════╗                               │");
            Console.WriteLine("│         ║   ╭─╮  ║     дверь                 ═ ═ ═ │");
            Console.WriteLine("│         ║   │ │  ║                        вентиляция ");
            Console.WriteLine("│         ║   ╰─╯  ║                           ═ ═ ═ │");
            Console.WriteLine("│         ║       ║                               │");
            Console.WriteLine("│         ║       ◉                               │");
            Console.WriteLine("│         ║       ║                               │");
            Console.WriteLine("│         ╚═══════╝                  ┌─────────┐  │");
            Console.WriteLine("│                                    │  ШКАФ   │  │");
            Console.WriteLine("│                  ∩―――――∩           │ ┌─┐ ┌─┐ │  │");
            Console.WriteLine("│                  │ ∧,,,∧ │       │  │ ││ │  │  │");
            Console.WriteLine("│                  │(˶-><-˶)│        │ └─┘ └─┘ │  │");
            Console.WriteLine("│                  |ﾉ￣づ⌒⌒￣ ＼     │         │  │");
            Console.WriteLine("│   тумбочка       (　ノ　⌒⌒ ヽ ＼   │  ┌──┐   │  │");
            Console.WriteLine("│▄▄▄▄▄▄▄▄           ＼   ノ││￣￣││   │  │  │   │  │");
            Console.WriteLine("│       █              ＼,ﾉ││￣￣││   │  └──┘   │  │");
            Console.WriteLine("│       █                            └─────────┘  │");
            Console.WriteLine("└───────█─────────────────────────────────────────┘");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Вы просыпаетесь в незнакомой комнате...");
            Console.WriteLine("Я я ничего не помню ... Черт моя голова раскалывается от боли...");
            Thread.Sleep(2000);
            Console.WriteLine("Вас окружает...");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Thread.Sleep(400);
            Console.WriteLine("Темнота.");
            Thread.Sleep(400);
            Console.WriteLine("Холод..");
            Thread.Sleep(400);
            Console.WriteLine("И.....");
            Thread.Sleep(800);
            Console.WriteLine("Глубокая тишина...");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(" Голос из ниоткуда: Как тебя зовут? ");
            Console.ResetColor();
            Console.WriteLine(" Как меня зовут? ");
            string name = Console.ReadLine();
            Console.WriteLine("Ваше имя: " + name);

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nВы лежите в неестественной позе на холодной каменной кровати");
            Thread.Sleep(1000);
            Console.WriteLine("Глаза медленно привыкают к темноте...");
            Thread.Sleep(1000);
            Console.WriteLine("В глубине комнаты угадываются смутные очертания...");
            Thread.Sleep(1000);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nВЫ ВИДИТЕ:");
            Console.WriteLine("1 - Массивную деревянную ДВЕРЬ с железными скобами");
            Console.WriteLine("2 - Высокий старинный ШКАФ с резными узорами");
            Console.ResetColor();

            Thread.Sleep(2000);
            Console.Write("\nЧто исследуешь сначала? (1/2): ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nВы пытаетесь подняться, чтобы подойти к двери...");
                Thread.Sleep(400);
                Console.ResetColor();
            }
            else if (choice == "2")
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\nВы пытаетесь подняться, чтобы подойти к шкафу...");
                Thread.Sleep(400);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nВы пытаетесь подняться...");
                Thread.Sleep(2000);
                Console.ResetColor();
            }

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Вы резко попытались встать,но тело не слушается...");
            Thread.Sleep(800);
            Console.WriteLine("ГОЛОВА ТЯЖЕЛЕЕ... в висках стучит.");
            Thread.Sleep(800);
            Console.WriteLine("\n Неосознанно вы дёргаете руками...");
            Thread.Sleep(800);
            Console.ResetColor();
            Console.WriteLine("- и понимаете встать с кровати вам,что то не даёт ! Что-то впиваеться вам в запястье...");
            Console.WriteLine("Сбросить одеяло? ( ДА )");
            string next = Console.ReadLine();
            Console.WriteLine("Сбросить одеяло..." + next);
            Thread.Sleep(400);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Под ним прикованные к заржавевшим кольцам на кровати болтаются массивные окровавленные цепи завязанные на одной из ваших рук...");
            Console.ResetColor();
            Thread.Sleep(1500);

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nЧто будем делать?");
                Console.WriteLine("1 - Заглянуть под кровать");
                Console.WriteLine("2 - Осмотреть шкаф");
                Console.WriteLine("3 - Попробовать открыть дверь");
                Console.WriteLine("4 - Осмотреть вентиляцию на шкафу");
                Console.WriteLine("5 - Осмотреть тумбочку");
                Console.Write("Выбери действие: ");
                Console.ResetColor();

                string action = Console.ReadLine();

                if (action == "1")
                {
                    if (!hasBedArtifact)
                    {
                        Console.WriteLine($"{name}, вы нашли старый ключ под кроватью!");
                        hasBedArtifact = true;
                    }
                    else
                    {
                        Console.WriteLine("Там больше ничего нет...");
                    }
                }
                else if (action == "2")
                {
                    if (!hasKey)
                    {
                        Console.WriteLine("Шкаф заперт. Нужен ключ.");
                    }
                    else if (!hasCrowbar)
                    {
                        Console.WriteLine($"{name}, вы открыли шкаф и нашли отмычку!");
                        hasCrowbar = true;
                    }
                    else
                    {
                        Console.WriteLine("Шкаф пуст.");
                    }
                }
                else if (action == "3")
                {
                    if (!isFreeFromChains)
                    {
                        Console.WriteLine("Сначала нужно освободиться от цепей!");
                    }
                    else if (!hasCrowbar)
                    {
                        Console.WriteLine("Дверь заперта. Нужна отмычка.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{name}, вы открыли дверь и сбежали! ");
                        Console.WriteLine(" ВЫ СПАСЛИСЬ!");
                        break;
                    }
                }
                else if (action == "4")
                {
                    if (!hasVentArtifact)
                    {
                        Console.WriteLine("Вентиляция не поддается. Попробуйте еще раз...");
                        Thread.Sleep(800);
                        Console.WriteLine("Пытаетесь открыть вентиляцию...");
                        Thread.Sleep(800);
                        Console.WriteLine("Еще попытка...");
                        Thread.Sleep(800);
                        Console.WriteLine($"{name}, вы открыли вентиляцию и нашли серебряный медальон!");
                        hasVentArtifact = true;
                    }
                    else
                    {
                        Console.WriteLine("Вентиляция уже открыта.");
                    }
                }
                else if (action == "5")
                {
                    if (!hasTableArtifact)
                    {
                        Console.WriteLine($"{name}, вы нашли золотой кулон на тумбочке!");
                        hasTableArtifact = true;
                    }
                    else
                    {
                        Console.WriteLine("Тумбочка пуста.");
                    }
                }
                else
                {
                    Console.WriteLine("Неизвестное действие. Выбери 1-5.");
                }

                if (hasBedArtifact && !isFreeFromChains)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nВы использовали ключ чтобы освободиться от цепей!");
                    Console.WriteLine("Теперь вы можете свободно перемещаться по комнате!");
                    isFreeFromChains = true;
                    Console.ResetColor();
                }

                if (hasBedArtifact && hasVentArtifact && hasTableArtifact && !hasKey)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nВсе артефакты собраны!");
                    Console.WriteLine("Серебряный медальон, золотой кулон и старый ключ соединяются в ваших руках!");
                    Console.WriteLine("Вы получаете ключ от шкафа!");
                    hasKey = true;
                    Thread.Sleep(1500);
                    Console.ResetColor();
                }

                if (isFreeFromChains && hasCrowbar)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nУ вас есть все необходимое для побега!");
                    Console.WriteLine("Попробуйте открыть дверь (3)");
                    Console.ResetColor();
                }

                Thread.Sleep(1000);
            }

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n================================================");
            Console.WriteLine("                 КОНЕЦ ИГРЫ                     ");
            Console.WriteLine("================================================");
            Console.ResetColor();
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}