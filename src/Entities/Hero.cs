namespace RPG.src.Entities
{
    public abstract class Hero
    {
        protected string? Name;
        protected int Level;
        protected string HeroType;
        protected double StaminaPoints;
        protected double LifePoints;
        protected double MagicPoints;
        protected int Armor;
        protected int Weapon;

        public Hero(string Name, string HeroType, int Level, double LifePoints, double MagicPoints, double StaminaPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.LifePoints = LifePoints;
            this.MagicPoints = MagicPoints;
            this.StaminaPoints = StaminaPoints;
        }

        public override string ToString()
        {
            return this.Name + "\tLevel: " + this.Level + "\tClass: " + this.HeroType;
        }
        
        public virtual string Attack(int PointAttack, int Bonus=0)
        {
            return this.Name + " Atacou!";
        }

        public void EquipCharacter(int Weapon, int Armor = 1)
        {
            this.Armor = Armor;
            this.Weapon = Weapon;
        }

    }
}