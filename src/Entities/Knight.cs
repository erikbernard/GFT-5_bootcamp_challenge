namespace RPG.src.Entities
{
    public class Knight : Hero 
    {
        const int LOW = 0;
        const int MEDIUM = 6;
        const int HIGH = 12;

        public Knight(string Name, string HeroType,int Level, int Weapon, int Armor,int LifePoints=50, int MagicPoints=50, int StaminaPoints=50)
            : base( Name, HeroType, Level, LifePoints, MagicPoints, StaminaPoints)
        {
            EquipCharacter(Weapon, Armor);
        }
        
        public override string Attack(int PointAttack, int Bonus=0)
        {
            string ReturnValue = "";
            Random IndexRandom = new Random();
            PointAttack = PointAttack + Bonus;
            if(StaminaPoints >= 10){
                StaminaPoints = StaminaPoints - 10;
                if(PointAttack == LOW)
                {
                    string[] Actions = new string[4] {
                        " The greatsword slipped out of his hand and fell to the ground.",
                        " Missed the sword attack and stuck it in the ground.",
                        " The greatsword slipped from his hand and landed on his foot.",
                        " As you lift the greatsword, it slips and flies upward.",
                    };

                    ReturnValue = this.Name + Actions[IndexRandom.Next(3)];
                }
                else if(PointAttack < MEDIUM)
                {
                    string[] Actions = new string[4] {
                        " Hit the greatsword attack on the left leg, causing a shallow cut.",
                        " Hit the greatsword attack on the right leg, causing a shallow cut.",
                        " Hit the greatsword attack on the left arm, causing a shallow cut.",
                        " Hit the greatsword attack on the right arm, causing a shallow cut.",
                    };

                    ReturnValue = this.Name + Actions[IndexRandom.Next(3)];
                }
                else if(PointAttack >= MEDIUM && PointAttack <= HIGH)
                {
                    string[] Actions = new string[4] {
                        " It hit the attack with the greatsword and made a deep cut in the opponent's chest, causing bleeding.",
                        " Hit the attack with the great sword and made a deep cut in the opponent's right leg.",
                        " Hit the attack with the greatsword and made a deep cut in the opponent's left arm.",
                        " Hit the attack with the great sword and made a deep cut in the opponent's right arm.",
                    };

                    ReturnValue = this.Name + Actions[IndexRandom.Next(3)];
                }
                else if(PointAttack == HIGH)
                {
                    string[] Actions = new string[4] {
                        " With all his strength in the attack, he hit the opponent with the greatsword splitting in two.",
                        " Hit the attack with the greatsword cutting off an opponent's arm and leg",
                        " Hit the attack with the great sword and pierced the opponent's heart.",
                        " Hit the attack with the greatsword, ripping the neck of the opponent's body.",
                    };

                    ReturnValue = this.Name + Actions[IndexRandom.Next(3)];
                }
                return ReturnValue;
            }
            else
            {
                return this.Name +"  Can't launch attack, you're tired and no more strength to fight.";
            }
        }

    }
}
