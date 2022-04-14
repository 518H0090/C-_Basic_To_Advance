using System;
using CS0008_Class;
using CS0008_Class2;
using CS0008_Class3;
using CS0008_Class4;
using CS0008_Class5;

namespace CS0008
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            // Chơi theo java
            Weapon weapon = new Weapon();
            weapon.setNameWeapon("Súng lục");
            weapon.setDamageAttack(20);
            weapon.Attack();

            // Chơi theo C#
            WeaponC weaponC = new WeaponC();
            weaponC.name = "Súng trường";
            weaponC.damageAttack = 50;
            weaponC.Attack();

            // Getter - Setter
            TestGetSet testGetSet = new TestGetSet("haha", 20);
            Console.WriteLine(testGetSet.ageValue);

            // Destroy object by method
            // for (int i = 0; i < 10000; i++)
            // {
            //     Student student = new Student("Name" + i, "Student " + i);
            // }


            // Destory by IDispoable
            using (DestoryByDispobale destoryByDispobale = new DestoryByDispobale("Haha"))
            {
                Console.WriteLine(destoryByDispobale.Name);
            };
        }
    }
}