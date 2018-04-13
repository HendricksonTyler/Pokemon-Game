using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pokémon_Game
{
    public class Ball
    {
        Battle Fight = new Battle();

        private int totalNum;
        private double catchValue;

        public Ball(int _totalNum, double _catchValue)
        {
            this.totalNum = _totalNum;
            this.catchValue = _catchValue;
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

        public double CatchValue
        {
            get
            {
                return catchValue;
            }

            set
            {
                catchValue = value;
            }
        }

//************************************************** METHODS *************************************************************************

        // uses up a pokeball
        public void BallUsed()
        {
            this.totalNum--;
        }


        public int CatchTest(PokemonCharacter Mewtwo)
        {
            const double BURN_CATCH_RATE = 1.5;

            int shakes = 0;
            double valueForCatch;
            double pokemonCatch;

            // determine catch value
            valueForCatch = ((3 * Mewtwo.MaxHP - 2 * Mewtwo.HP) * (Mewtwo.CatchRate * this.CatchValue) / (3 * Mewtwo.MaxHP));

            // check if mewtwo is burned
            if (Mewtwo.Burned == true)
            {
                catchValue = catchValue * BURN_CATCH_RATE;
            }

            // test for automatic capture
            if (catchValue >= 255 || this.catchValue == 999)
            {
                shakes = 4;
            }

            // calculate catch (shake probability #)
            else
            {
                pokemonCatch = 65536 / Math.Pow((255 / catchValue), .25);

                int randCatchCheck = Fight.RandomCatch();

                // start test for shake ONE
                if (pokemonCatch > randCatchCheck)
                {
                    randCatchCheck = Fight.RandomCatch();
                    shakes++;

                    // start test for shake TWO
                    if (pokemonCatch > randCatchCheck)
                    {
                        randCatchCheck = Fight.RandomCatch();
                        shakes++;

                        // start test for shake THREE
                        if (pokemonCatch > randCatchCheck)
                        {
                            randCatchCheck = Fight.RandomCatch();
                            shakes++;

                            // start test for CAPTURE
                            if (pokemonCatch > randCatchCheck)
                            {
                                shakes++;
                            }
                        }
                    }
                }
           
            }

            return shakes;
        }
    }
}
