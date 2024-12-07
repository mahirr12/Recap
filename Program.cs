namespace Class_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bütün məlumatları doldurmadan obyekt yaratmaq olmasın.
            Console.WriteLine("Enter bullet capacity: ");
            int capacity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter current bullet:");
            int current = Convert.ToInt32(Console.ReadLine());
            Weapon weapon1 = new Weapon(capacity, current);

            //0 - İnformasiya almaq üçün
            //1 - Shoot metodu üçün
            //2 - Fire metodu üçün
            //3 - GetRemainBulletCount metodu üçün
            //4 - Reload metodu üçün
            //5 - ChangeFireMode metodu üçün
            //6 - Proqramdan dayandırmaq üçün
            //qısayoldur.

            bool menu = true;
            Console.Clear();
            do
            {
                Console.WriteLine("0 - Info\r\n1 - Shoot\r\n2 - Fire\r\n3 - Remain bullet count\r\n4 - Reload\r\n5 - Change fire mode\r\n6 - Exit\r\n7 - Edit");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        Console.Clear();
                        Console.WriteLine(weapon1);
                        break;
                    case "1":
                        Console.Clear();
                        weapon1.Shoot();
                        break;
                    case "2":
                        Console.Clear();
                        weapon1.Fire();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine(weapon1.GetRemainBulletCount());
                        break;
                    case "4":
                        Console.Clear();
                        weapon1.Reload();
                        break;
                    case "5":
                        Console.Clear();
                        weapon1.ChangeFireMode();
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Exit");
                        menu = false;
                        break;
                    //   7 - Edit :
                    //1 - Tutumu dəyişsin evvelden 30 idise indi 40 olsun
                    //2 - Güllə sayı deyissin
                    case "7":
                        Console.Clear();
                        Console.WriteLine("1 - Change capacity\r\n2 - Change bullet amount");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.WriteLine("Enter new capacity:");
                                weapon1.BulletCapacity = Convert.ToInt32(Console.ReadLine());
                                if (weapon1.BulletCapacity < weapon1.CurrentBullet) weapon1.CurrentBullet = weapon1.BulletCapacity;
                                break;
                            case "2":
                                Console.WriteLine("Enter bullet amount");
                                weapon1.CurrentBullet = Convert.ToInt32(Console.ReadLine());
                                break;
                            default:
                                Console.WriteLine("Invalid input");
                                break;
                        }
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid input");
                        break;
                }
            } while (menu);

        }
    }
}
