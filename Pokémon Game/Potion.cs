using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pokémon_Game
{
    public class Potion
    {
        private int totalNum;


        public Potion(int _totalNum)
        {
            this.totalNum = _totalNum;

        }

        public int TotalNum
        {
            get
            {
                return totalNum;
            }

            set
            {
                totalNum = value;
            }
        }

// *********************************************** METHODS ***********************************************************

        public void PotionUsed()
        {
            this.totalNum--;
        }

        public int RestoredBy(PokemonCharacter Charizard)
        {
            int restoredBy;

            restoredBy = Charizard.MaxHP - Charizard.HP;
            Charizard.HP = Charizard.MaxHP;

            return restoredBy;
        }

    }
}
