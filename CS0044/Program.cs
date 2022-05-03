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

    class CharacterEquiptCon
    {
        Weapon Weapon { set; get; }
        public CharacterEquiptCon(Weapon weapon)
        {
            this.Weapon = weapon;
        }

        public void ShowEquipment()
        {
            Weapon.InfoWeapon();
        }
    }

    class CharacterEquiptConLa
    {
        public Weapon Weapon { set; get; }
        public CharacterEquiptConLa()
        {

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
            // thông qua interface
            IWeapon weapon = new Weapon("Sword", 2000);
            CharacterEquipt characterEquipt = new CharacterEquipt(weapon);
            characterEquipt.ShowEquipment();

            // thông qua constructor
            Weapon weapon1 = new Weapon("Gun", 5000);
            CharacterEquipt characterEquipt2 = new CharacterEquipt(weapon1);
            characterEquipt2.ShowEquipment();

            // Thông qua getter /setter
            Weapon weapon2 = new Weapon("Bow", 4000);
            CharacterEquiptConLa characterEquipt3 = new CharacterEquiptConLa();
            characterEquipt3.Weapon = weapon2;
            characterEquipt3.ShowEquipment();
        }
    }
}