using System;

namespace CS0044
{
    interface IWeapon
    {
        public void InfoWeapon();
    }

    class Weapon : IWeapon
    {
        public string Name { set; get; }
        public int Damage { set; get; }

        public Weapon()
        {

        }

        public Weapon(string name, int damage)
        {
            this.Name = name;
            this.Damage = damage;
        }

        public void InfoWeapon()
        {
            Console.WriteLine($"Weapon Info - {Name} : {Damage}");
        }
    }

    class CharacterEquipt
    {
        IWeapon Weapon { set; get; }
        public CharacterEquipt(IWeapon weapon)
        {
            this.Weapon = weapon;
        }

        public void ShowEquipment()
        {
            Weapon.InfoWeapon();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IWeapon weapon = new Weapon("Sword", 2000);
            IWeapon weapon1 = new Weapon();
            CharacterEquipt characterEquipt = new CharacterEquipt(weapon);
            characterEquipt.ShowEquipment();
            CharacterEquipt characterEquipt2 = new CharacterEquipt(weapon1);
            characterEquipt2.ShowEquipment();
        }
    }
}