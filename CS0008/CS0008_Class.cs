using System;

namespace CS0008_Class
{
    // Theo kiểu java :))

    public class Weapon
    {
        private string name;
        private int damageAttack;

        public Weapon()
        {
            this.name = "Weapon Default";
            this.damageAttack = 1;
        }

        public Weapon(string name, int damageAttack)
        {
            this.name = name;
            this.damageAttack = damageAttack;
        }

        public void setNameWeapon(string name)
        {
            this.name = name;
        }

        public string getNameWeapon()
        {
            return this.name;
        }

        public void setDamageAttack(int i)
        {
            this.damageAttack = i;
        }

        public int getDamageAttack()
        {
            return this.damageAttack;
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