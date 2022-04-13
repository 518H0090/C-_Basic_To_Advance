using System;

namespace CS0008_Class2
{
    // Theo kiểu C# :))

    public class WeaponC
    {
        public string name { set; get; }
        public int damageAttack { set; get; }

        public WeaponC()
        {
            this.name = "Weapon Default";
            this.damageAttack = 1;
        }

        public WeaponC(string name, int damageAttack)
        {
            this.name = name;
            this.damageAttack = damageAttack;
        }

        public void Attack()
        {
            Console.Write(name + ": \t");
            for (int i = 0; i < damageAttack; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}