using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pokémon_Game
{
    public class PokemonCharacter
    {
        // pokemon stats
        private int maxHp;
        private int hp;
        private int maxAtk;
        private int atk;
        private int def;
        private int spAtk;
        private int maxSpDef;
        private int spDef;
        private int speed;

        // types
        private string type1;
        private string type2;

        // other        
        private bool burned;
        private double catchRate;

        public PokemonCharacter(int _maxHp, int _hp, int _maxAtk, int _atk, int _def, int _spAtk, int _maxSpDef, int _spDef, int _speed, bool _burned, double _catchRate, string _type1, string _type2)
        {
            this.maxHp = _maxHp;
            this.hp = _hp;
            this.maxAtk = _maxAtk;
            this.atk = _atk;
            this.def = _def;
            this.spAtk = _spAtk;
            this.maxSpDef = _maxSpDef;
            this.spDef = _spDef;
            this.speed = _speed;

            this.type1 = _type1;
            this.type2 = _type2;

            this.burned = _burned;
            this.catchRate = _catchRate;
        }

        public int MaxHP
        {
            get
            {
                return maxHp;
            }

            set
            {
                maxHp = value;
            }
        }

        public int HP
        {
            get
            {
                return hp;
            }

            set
            {
                hp = value;
            }
        }

        public int MaxAtk
        {
            get
            {
                return maxAtk;
            }

            set
            {
                maxAtk = value;
            }
        }

        public int Atk
        {
            get
            {
                return atk;
            }

            set
            {
                atk = value;
            }
        }

        public int Def
        {
            get
            {
                return def;
            }

            set
            {
                def = value;
            }
        }

        public int SpAtk
        {
            get
            {
                return spAtk;
            }

            set
            {
                spAtk = value;
            }
        }

        public int MaxSpDef
        {
            get
            {
                return maxSpDef;
            }

            set
            {
                maxSpDef = value;
            }
        }

        public int SpDef
        {
            get
            {
                return spDef;
            }

            set
            {
                spDef = value;
            }
        }

        public int Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }

        public string Type1
        {
            get
            {
                return type1;
            }

            set
            {
                type1 = value;
            }
        }

        public string Type2
        {
            get
            {
                return type2;
            }

            set
            {
                type2 = value;
            }
        }

        public bool Burned
        {
            get
            {
                return burned;
            }

            set
            {
                burned = value;
            }
        }

        public double CatchRate
        {
            get
            {
                return catchRate;
            }

            set
            {
                catchRate = value;
            }
        }

//*****************************************  POKEMON METHODS  ****************************************************************************************

        public int PercentHealth()
        {
            double percent;

            percent = ((double)this.HP / (double)this.MaxHP) * 100;

            return (int)percent;
        }
        
//*****************************************   MOVES   ************************************************************************************************



        public class Attacks
        {
            Battle Attack = new Battle();

            private int power;
            private int accuracy;
            private int effectChance;
            private int pp;
            private string type;
            private string atkType;
            private string atkName;

            public Attacks(int _power, int _accuracy, int _effectChance, int _pp, string _type, string _atkType, string _atkName)
            {
                this.power = _power;
                this.accuracy = _accuracy;
                this.effectChance = _effectChance;
                this.pp = _pp;
                this.type = _type;
                this.atkType = _atkType;
                this.atkName = _atkName;
            }

            public int Power
            {
                get
                {
                    return power;
                }

                set
                {
                    power = value;
                }
            }

            public int Accuracy
            {
                get
                {
                    return accuracy;
                }

                set
                {
                    accuracy = value;
                }
            }

            public int EffectChance
            {
                get
                {
                    return effectChance;
                }

                set
                {
                    effectChance = value;
                }
            }

            public int PP
            {
                get
                {
                    return pp;
                }

                set
                {
                    pp = value;
                }
            }

            public string Type
            {
                get
                {
                    return type;
                }

                set
                {
                    type = value;
                }
            }

            public string AtkType
            {
                get
                {
                    return atkType;
                }

                set
                {
                    atkType = value;
                }
            }

//****************************************** MOVE METHODS ***************************************************************************

            // uses the move
            public void AttackUsed()
            {
                this.pp--;

                // account for mewtwo's pressure
                if (this.atkName == "Flamethrower" || this.atkName == "Slash" || this.atkName == "SolarBeam" || this.atkName == "Air Slash")
                {
                    this.pp--;
                }
            }

            // determines if the target is burned
            public bool Burned()
            {
                bool burned;

                if (this.effectChance >= Attack.RandomNum())
                {
                    burned = true;
                }

                else
                {
                    burned = false;
                }

                return burned;
            }

            // determines if move has missed
            public bool Missed()
            {
                bool missed;

                if (Attack.RandomNum() > this.accuracy)
                {
                    missed = true;
                }

                else
                {
                    missed = false;
                }

                return missed;
            }

            // calculates how much damage is done
            public int CalculateDamage(PokemonCharacter Charizard, PokemonCharacter Mewtwo, double crit)
            {
                const double STAB_YES = 1.5;
                const double STAB_NO = 1.0;
                const double NORMAL_EFFECTIVE = 1.0;
                const double NOT_VERY_EFFECTIVE = .5;
                const double LEVEL = 100;

                double stab = 0;
                double effectiveness = 0;

                int attackerAtkStat = 0;
                string attackerType1;
                string attackerType2;

                int defenderDefStat = 0;
                int defenderHPStat = 0;


                // determine who is attacking

                // charizard attacking
                if (this.atkName == "Flamethrower" || this.atkName == "Air Slash" || this.atkName == "Slash" || this.atkName == "SolarBeam")
                {
                    // determine if move is physical or special
                    if (this.atkType == "PHYSICAL")
                    {
                        attackerAtkStat = Charizard.atk;
                        defenderDefStat = Mewtwo.def;
                    }

                    else if (this.atkType == "SPECIAL")
                    {
                        attackerAtkStat = Charizard.spAtk;
                        defenderDefStat = Mewtwo.spDef;
                    }

                    attackerType1 = Charizard.type1;
                    attackerType2 = Charizard.type2;
                    defenderHPStat = Mewtwo.hp;
                }

                // mewtwo attacking
                else 
                {
                    // determine if move is physical or special
                    if (this.atkType == "PHYSICAL")
                    {
                        attackerAtkStat = Mewtwo.atk;
                        defenderDefStat = Charizard.def;
                    }

                    else if (this.atkType == "SPECIAL")
                    {
                        attackerAtkStat = Mewtwo.spAtk;
                        defenderDefStat = Charizard.spDef;
                    }

                    attackerType1 = Mewtwo.type1;
                    attackerType2 = Mewtwo.type2;
                    defenderHPStat = Charizard.hp;
                }

                // determine if the move has STAB
                if (this.type == attackerType1 || this.type == attackerType2)
                {
                    stab = STAB_YES;
                }

                else
                {
                    stab = STAB_NO;
                }
                
                // determine type effectiveness of move
                if (this.atkName == "Aura Sphere")
                {
                    effectiveness = NOT_VERY_EFFECTIVE;
                }

                else
                {
                    effectiveness = NORMAL_EFFECTIVE;
                }
                
                double modifier = stab * effectiveness * crit * 1 * Attack.RandomDamage() / 100;

                double first = 2 * LEVEL + 10;
                double second = first / 250 * attackerAtkStat / defenderDefStat * this.power + 2;

                double damage = second * modifier;

                int damageInt = (int)damage;

                // prevents hp from being in the negatives
                if (damageInt > defenderHPStat)
                {
                    damageInt = defenderHPStat;
                }

                return damageInt;
            }  
        } 
    }
}
