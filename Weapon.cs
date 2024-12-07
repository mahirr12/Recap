using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_work
{
    //    Weapon deyə class yaradılır.
    //Darağın güllə tutumu, Daraqdakı güllə sayı,atış modu(təkli, üçlü(burst) və ya avtomatik) propertileri verilir.

    //Bütün məlumatları doldurmadan obyekt yaratmaq olmasın.
    public class Weapon
    {
        public int BulletCapacity { get; set; }

        private int _currentBullet;
        public int CurrentBullet
        {
            get => _currentBullet;
            set
            {
                if (value <= BulletCapacity) _currentBullet = value;
                else
                {
                    _currentBullet = BulletCapacity;
                    Console.WriteLine($"Max bullet amount must be {BulletCapacity}.\r\nBullet amount setted to {BulletCapacity}");
                }
            }
        }
        public Mode WeaponMode { get; set; }

        public Weapon(int capacity, int current)
        {
            BulletCapacity = capacity;
            CurrentBullet = current;
            ChangeFireMode();
        }

        //Shoot() - metodu hər çağırıldıqda 1 güllə atır(Ekranda bunu bildirir)
        public void Shoot()
        {
            if (CurrentBullet != 0)
            {
                CurrentBullet -= 1;
                Console.WriteLine("Shoot");
            }
            else Console.WriteLine("Empty weapon");
        }
        //Fire() - metodu daraqdakı güllələr hamısı atəşlənir. (mod üçlüdürsə(burst) 3 güllə atacaq)
        public void Fire()
        {
            if (CurrentBullet != 0)
            {
                if (WeaponMode == Mode.Automatic)
                {
                    Console.WriteLine($"Fire {CurrentBullet} times");
                    CurrentBullet = 0;
                }
                else if (WeaponMode == Mode.Burst)
                {
                    if (CurrentBullet >= 3)
                    {
                        Console.WriteLine("Fire 3 times");
                        CurrentBullet -= 3;
                    }
                    else
                    {
                        Console.WriteLine($"Fire {CurrentBullet} times");
                        CurrentBullet = 0;
                    }

                }
                else Shoot();

            }
            else Console.WriteLine("Empty weapon");
        }

        //GetRemainBulletCount() - darağın tam dolması üçün lazım olan güllə sayını qaytarır.
        public int GetRemainBulletCount()
        {
            return BulletCapacity - CurrentBullet;
        }
        //Reload() - darağı yenidən doldurur.
        public void Reload()
        {
            CurrentBullet = BulletCapacity;
        }
        //ChangeFireMode() - Atış modunu dəyişir.
        public void ChangeFireMode()
        {
            Console.WriteLine("Select weapon mode:");
            Console.WriteLine("1 - Single\r\n2 - Burst\r\n3 - Automatic");
            int mode = Convert.ToInt32(Console.ReadLine());
            WeaponMode = (Mode)mode - 1;
        }

        public override string ToString()
        {
            return $"Capacity - {BulletCapacity}\r\nCurrent bullet - {CurrentBullet}\r\nMode - {WeaponMode}";
        }

    }
}
