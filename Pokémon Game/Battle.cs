using System;
using System.Collections.Generic;
using System.Media;
using System.Linq;
using System.Text;

namespace Pokémon_Game
{
    public class Battle
    {
        Random randNumber = new Random();

        const double CRIT_YES = 2;
        const double CRIT_NO = 1;

        int spDefStage = 0;

        public Battle()
        {

        }

//**************************************************** METHODS ****************************************************************
        // determines Mewtwo's random attack
        public int RandomAttack()
        {
            int attack = randNumber.Next(1, 5);

            return attack;
        }

        // determines if move is critical with high crit chance
        public double HighCrit()
        {
            double crit;

            double randNum = randNumber.Next(1, 10001);

            randNum = randNum / 100;

            if (randNum <= 6.25)
            {
                crit = CRIT_YES;
            }

            else
            {
                crit = CRIT_NO;
            }

            return crit;
        }

        // determines if move is critical with standard crit chance
        public double StandardCrit()
        {
            double crit;

            double randNum = randNumber.Next(1, 10001);

            randNum = randNum / 100;

            if (randNum <= 12.50)
            {
                crit = CRIT_YES;
            }

            else
            {
                crit = CRIT_NO;
            }

            return crit;
        }

        // determines if protect fails
        public bool ProtectFail()
        {
            bool protect = false;

            if (RandomNum() >= 51)
            {
                protect = true;
            }

            else if (RandomNum() <= 50)
            {
                protect = false;
            }

            return protect;
        }

        // determines if psychic sp def drop
        public bool DropSpecialDef(PokemonCharacter Charizard)
        {
            const double LOWER_STAT_1 = .66;
            const double LOWER_STAT_2 = .5;
            const double LOWER_STAT_3 = .4;
            const double LOWER_STAT_4 = .33;
            const double LOWER_STAT_5 = .285;
            const double LOWER_STAT_6 = .25;

            bool dropped;
            double decimalSpDef = 0;

            if (RandomNum() > 90)
            {
                dropped = true;

                // lower the stat if it isn't the bottom
                if (spDefStage != 6)
                {
                    spDefStage--;
                }

                // drop the stats
                if (spDefStage == -1)
                {
                    decimalSpDef = Charizard.MaxSpDef * LOWER_STAT_1;
                }


                else if (spDefStage == -2)
                {
                    decimalSpDef = Charizard.MaxSpDef * LOWER_STAT_2;
                }

                else if (spDefStage == -3)
                {
                    decimalSpDef = Charizard.MaxSpDef * LOWER_STAT_3;
                }

                else if (spDefStage == -4)
                {
                    decimalSpDef = Charizard.MaxSpDef * LOWER_STAT_4;
                }

                else if (spDefStage == -5)
                {
                    decimalSpDef = Charizard.MaxSpDef * LOWER_STAT_5;
                }

                else if (spDefStage == -6)
                {
                    decimalSpDef = Charizard.MaxSpDef * LOWER_STAT_6;
                }

            }

            else
            {
                dropped = false;
            }

            return dropped;
        }

        // does burn damage
        public int BurnDamage(PokemonCharacter Mewtwo)
        {
            int damage;

            damage = (Mewtwo.MaxHP / 8);

            // prevents hp from being in the negatives
            if (damage > Mewtwo.HP)
            {
                damage = Mewtwo.HP;
            }

            return damage;
        }

        // provides a random number
        public int RandomNum()
        {
            int randNum = randNumber.Next(1, 101);

            return randNum;
        }

        public int RandomDamage()
        {
            int randNum = randNumber.Next(85, 101);

            return randNum;
        }

        public int RandomCatch()
        {
            int randCatchCheck = randNumber.Next(0, 65536);

            return randCatchCheck;
        }

        public int RandomShiny()
        {
            int RandNum = randNumber.Next(1, 20);

            return RandNum;
        }

        public void PlayCry(SoundPlayer cry)
        {
            cry.Play();
        }

        public void PlayMusic(SoundPlayer music)
        {
            music.PlayLooping();
        } 
    }
}
