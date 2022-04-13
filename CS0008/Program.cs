using System;
using CS0008_Class;
using CS0008_Class2;

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
        }
    }
}