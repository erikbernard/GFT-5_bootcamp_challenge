
namespace RPG.src.Entities
{
    public class Wizard : Hero
    {
        const int LOW = 0;
        const int MEDIUM = 6;
        const int HIGH = 12;

        public Wizard(string Name, string HeroType, int Level, int Weapon, int Armor, int LifePoints=50, int MagicPoints=50,int StaminaPoints=50 )
            : base( Name, HeroType, Level, LifePoints, MagicPoints, StaminaPoints)
        {
            EquipCharacter(Weapon, Armor);
        }
        
        public override string Attack(int PointAttack, int Bonus=0)
        {
            string ReturnValue = "";
            Random IndexRandom = new Random();
            PointAttack = PointAttack + Bonus;
            if(MagicPoints >= 10){
                MagicPoints = MagicPoints - 10;
                if(PointAttack == LOW)
                {
                    string[] Actions = new string[5] {
                        " Missed the attack.",
                        " She tripped over a rock and fell flat on her face.",
                        " He got scared and wet his armor.",
                        " He Couldn't Cast Magic",
                        " He Cast the Magic, But He Hit His Own Foot",
                    };

                    ReturnValue = this.Name + Actions[IndexRandom.Next(4)];
                }
                else if(PointAttack < MEDIUM)
                {
                    string[] Actions = new string[4] {
                        " Hit the attack on the left leg, causing a bruise.",
                        " Hit the attack on the right leg, causing a bruise",
                        " Hit the attack on the left arm, causing a bruise.",
                        " Hit the attack on the right arm, causing a bruise.",
                    };

                    ReturnValue = this.Name + Actions[IndexRandom.Next(3)];
                }
                else if(PointAttack >= MEDIUM && PointAttack <= HIGH)
                {
                    string[] Actions = new string[4] {
                        " Hit the attack and knocked the opponent to the ground, dealing damage.",
                        " He hit the attack, managed to break the opponent's right leg.",
                        " He hit the attack, managed to break the opponent's left arm.",
                        " He hit the attack, managed to break the opponent's right arm.",
                    };

                    ReturnValue = this.Name + Actions[IndexRandom.Next(3)];
                }
                else if(PointAttack == HIGH)
                {
                    string[] Actions = new string[4] {
                        " Concentrated magic attack, threw the opponent to the ground, causing death.",
                        " The attack ripped off one of the opponent's legs.",
                        " The attack ripped off one of the opponent's arms.",
                        " Hit the attack, obliterated the opponent.",
                    };

                    ReturnValue = this.Name + Actions[IndexRandom.Next(3)];
                }
                return ReturnValue;
            }
            else
            {
                return this.Name +" Can't launch attack, has no magic points.";
            }
        }

    }
}