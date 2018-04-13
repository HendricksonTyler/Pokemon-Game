using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokémon_Game
{
    public partial class Display : Form
    {
        const int MOVE_FLAMETHROWER = 1;
        const int MOVE_AIR_SLASH = 2;
        const int MOVE_SOLAR_BEAM = 3;
        const int MOVE_SLASH = 4;

        const int MOVE_PSYCHIC = 1;
        const int MOVE_PSYCHO_CUT = 2;
        const int MOVE_AURA_SPHERE = 3;
        const int MOVE_PROTECT = 4;

        const int BALL_MASTER_BALL = 5;
        const int BALL_ULTRA_BALL = 6;
        const int BALL_GREAT_BALL = 7;
        const int BALL_POKE_BALL = 8;
        const int POTION_MAX_POTION = 9;

        int dialogAdvance = 1;
        int actionChosen = 0;
        bool itemUsed;
        bool moveUsed;
        bool protectLastTurn = false;
        bool protected0 = false;
        bool skipCharizard = false;
        bool charging = false;
        bool shiny = false;
        int randAttack = 0;

        double crit;
        int shakes;

        // creates objects for mewtwo and charizard
        public PokemonCharacter Mewtwo = new PokemonCharacter(353, 353, 204, 204, 192, 254, 295, 295, 260, false, 3, "PSYCHIC", "");
        public PokemonCharacter Charizard = new PokemonCharacter(330, 330, 233, 233, 216, 334, 216, 216, 224, false, 45, "FIRE", "FLYING");

        // creates objects for the cries
        SoundPlayer MewtwoCry = new SoundPlayer(Pokémon_Game.Properties.Resources.mewtwo_cry);
        SoundPlayer CharizardCry = new SoundPlayer(Pokémon_Game.Properties.Resources.charizard_cry);
        SoundPlayer FaintedMewtwoCry = new SoundPlayer(Pokémon_Game.Properties.Resources.mewtwo_cry_fainted);
        SoundPlayer FaintedCharizardCry = new SoundPlayer(Pokémon_Game.Properties.Resources.charizard_cry_fainted);

        // creates objects for mewtwo's moves
        public PokemonCharacter.Attacks Psychic = new PokemonCharacter.Attacks(90, 100, 10, 10, "PSYCHIC", "SPECIAL", "Psychic");
        public PokemonCharacter.Attacks PsychoCut = new PokemonCharacter.Attacks(70, 100, 0, 20, "PSYCHIC", "PHYSICAL", "Pyscho Cut");
        public PokemonCharacter.Attacks AuraSphere = new PokemonCharacter.Attacks(90, 999, 0, 20, "FIGHTING", "SPECIAL", "Aura Sphere");
        public PokemonCharacter.Attacks Protect = new PokemonCharacter.Attacks(0, 100, 0, 10, "NORMAL", "OTHER", "Protect");

        // creates objects for charizard's moves
        public PokemonCharacter.Attacks Flamethrower = new PokemonCharacter.Attacks(95, 100, 10, 15, "FIRE", "SPECIAL", "Flamethrower");
        public PokemonCharacter.Attacks AirSlash = new PokemonCharacter.Attacks(75, 95, 30, 20, "FLYING", "SPECIAL", "Air Slash");
        public PokemonCharacter.Attacks SolarBeam = new PokemonCharacter.Attacks(120, 100, 0, 10, "GRASS", "SPECIAL", "SolarBeam");
        public PokemonCharacter.Attacks Slash = new PokemonCharacter.Attacks(70, 100, 0, 20, "NORMAL", "PHYSICAL", "Slash");

        // creates objects for all pokeballs
        public Ball PokeBall = new Ball(20, 1);
        public Ball GreatBall = new Ball(4, 1.5);
        public Ball UltraBall = new Ball(2, 2);
        public Ball MasterBall = new Ball(1, 999);

        // creates object for potions
        public Potion MaxPotion = new Potion(4);

        Battle Fight = new Battle();
        Animation Animate = new Animation();

        public Display()
        {
            InitializeComponent();

            // mewtwo's cry
            Fight.PlayCry(MewtwoCry);

            // chance of shiny mewtwo
            if (Fight.RandomShiny() == 10)
            {
                imgMewtwo.Image = Pokémon_Game.Properties.Resources.shiny_mewtwo;
                shiny = true;
            }
        }

        // sets chosen item to master ball
        private void button1_Click(object sender, EventArgs e)
        {
            if (dialogAdvance == 3)
            {
                if (MasterBall.TotalNum > 0)
                {
                    actionChosen = BALL_MASTER_BALL;
                    moveUsed = false;
                    itemUsed = true;
                    skipCharizard = true;
                    btnA.Visible = true;
                }

                else
                {
                    txtDialog.Text = "There are no Master Balls left!";
                }
            }
        }

        // restarts application
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        // executes program when 'A' is clicked
        private void btnA_Click(object sender, EventArgs e)
        {
            dialogAdvance++;


            if (dialogAdvance == 2)
            {
                txtDialog.Text = "Go! Charizard!";
                imgCharizard.Visible = true;
                gboCharizard.Visible = true;
                Fight.PlayCry(CharizardCry);
            }

            if (dialogAdvance == 3)
            {
                txtDialog.Text = "What will Charizard do?";
                actionChosen = 0;
                btnA.Visible = false;
            }

            //************************************************** MEWTWO ATTACK **************************************************

            if (moveUsed == true)
            {
                // the wild mewtwo used ____
                if (dialogAdvance == 4)
                {
                    randAttack = Fight.RandomAttack();

                    if (randAttack == MOVE_PSYCHIC)
                    {
                        txtDialog.Text = "The wild Mewtwo used Psychic!";
                        Psychic.AttackUsed();
                        protected0 = false;
                        crit = Fight.StandardCrit();
                        protectLastTurn = false;
                    }

                    else if (randAttack == MOVE_PSYCHO_CUT)
                    {
                        txtDialog.Text = "The wild Mewtwo used Psycho Cut!";
                        PsychoCut.AttackUsed();
                        protected0 = false;
                        crit = Fight.HighCrit();
                        protectLastTurn = false;
                    }

                    else if (randAttack == MOVE_AURA_SPHERE)
                    {
                        txtDialog.Text = "The wild Mewtwo used Aura Sphere!";
                        AuraSphere.AttackUsed();
                        protected0 = false;
                        crit = Fight.StandardCrit();
                        protectLastTurn = false;
                    }

                    else if (randAttack == MOVE_PROTECT)
                    {
                        txtDialog.Text = "The wild Mewtwo used Protect!";
                        crit = 1;
                    }
                }

                // the attack failed
                if (dialogAdvance == 5)
                {
                    if (randAttack == MOVE_PROTECT)
                    {
                        if (protectLastTurn == true)
                        {
                            if (Fight.ProtectFail() == true)
                            {
                                txtDialog.Text = "But it failed.";
                                protected0 = false;
                            }

                            else if (Fight.ProtectFail() == false)
                            {
                                Protect.AttackUsed();
                                protected0 = true;
                                protectLastTurn = true;
                                txtDialog.Text = "The wild Mewtwo protected itself!";
                            }
                        }

                        else if (protectLastTurn == false)
                        {
                            Protect.AttackUsed();
                            protected0 = true;
                            protectLastTurn = true;
                            txtDialog.Text = "The wild Mewtwo protected itself!";
                        }
                    }

                    else if (randAttack != MOVE_PROTECT)
                    {
                        dialogAdvance = 6;
                    }
                }

                // critical hit & do damage
                if (dialogAdvance == 6)
                {
                    // deal damage
                    if (randAttack == MOVE_PSYCHIC)
                    {
                        Charizard.HP = Charizard.HP - Psychic.CalculateDamage(Charizard, Mewtwo, crit);
                        lblCharizardHP.Text = Charizard.HP.ToString();
                        progCharizardHP.Value = Charizard.PercentHealth();
                    }

                    else if (randAttack == MOVE_PSYCHO_CUT)
                    {
                        Charizard.HP = Charizard.HP - PsychoCut.CalculateDamage(Charizard, Mewtwo, crit);
                        lblCharizardHP.Text = Charizard.HP.ToString();
                        progCharizardHP.Value = Charizard.PercentHealth();
                    }

                    else if (randAttack == MOVE_AURA_SPHERE)
                    {
                        Charizard.HP = Charizard.HP - AuraSphere.CalculateDamage(Charizard, Mewtwo, crit);
                        lblCharizardHP.Text = Charizard.HP.ToString();
                        progCharizardHP.Value = Charizard.PercentHealth();
                    }

                    // test for crit display
                    if (crit == 2)
                    {
                        txtDialog.Text = "A critical hit!";
                    }

                    else if (crit == 1)
                    {
                        dialogAdvance = 7;
                    }
                }

                // it's not very effective
                if (dialogAdvance == 7)
                {
                    if (randAttack == MOVE_AURA_SPHERE)
                    {
                        txtDialog.Text = "It's not very effective.";
                    }

                    else
                    {
                        dialogAdvance = 8;
                    }
                }

                // charizard fainted
                if (dialogAdvance == 8)
                {
                    if (Charizard.HP <= 0)
                    {
                        Fight.PlayCry(FaintedCharizardCry);
                        txtDialog.Text = "Charizard fainted!";
                        imgCharizard.Visible = false;
                        gboCharizard.Visible = false;
                    }

                    else
                    {
                        dialogAdvance = 11;
                    }
                }

                // player is out of usable pokemon
                if (dialogAdvance == 9)
                {
                    txtDialog.Text = "Player is out of usable Pokemon!";
                }

                // player whited out
                if (dialogAdvance == 10)
                {
                    txtDialog.Text = "Player whited out!";
                    dialogAdvance = 999;
                }

                // sp def fell
                if (dialogAdvance == 11)
                {
                    if (randAttack == MOVE_PSYCHIC)
                    {
                        // test for sp def drop
                        if (Fight.DropSpecialDef(Charizard) == true)
                        {
                            txtDialog.Text = "Charizard's Sp. Def fell!";
                        }

                        else
                        {
                            dialogAdvance = 12;
                        }
                    }

                    else
                    {
                        dialogAdvance = 12;
                    }
                }


                //**************************************** CHARIZARD ATTACK *********************************************************************

                // skips charizard
                if (skipCharizard == true && dialogAdvance == 12)
                {
                    if (Mewtwo.Burned == true)
                        dialogAdvance = 18;

                    else
                        dialogAdvance = 2;
                }

                else if (skipCharizard == false)
                {
                    // charizard used _____
                    if (dialogAdvance == 12)
                    {
                        if (actionChosen == MOVE_FLAMETHROWER)
                        {
                            txtDialog.Text = "Charizard used Flamethrower!";
                            Flamethrower.AttackUsed();
                            lblFlamethrowerPP.Text = Flamethrower.PP.ToString();
                        }

                        else if (actionChosen == MOVE_AIR_SLASH)
                        {
                            txtDialog.Text = "Charizard used Air Slash!";
                            AirSlash.AttackUsed();
                            lblAirSlashPP.Text = AirSlash.PP.ToString();
                        }

                        else if (actionChosen == MOVE_SLASH)
                        {
                            txtDialog.Text = "Charizard used Slash!";
                            Slash.AttackUsed();
                            lblSlashPP.Text = Slash.PP.ToString();
                        }

                        else if (actionChosen == MOVE_SOLAR_BEAM)
                        {
                            if (charging == false)
                            {
                                txtDialog.Text = "Charizard absorbed sunlight!";
                                SolarBeam.AttackUsed();
                                lblSolarBeamPP.Text = SolarBeam.PP.ToString();
                                charging = true;
                                dialogAdvance = 3;
                            }

                            else if (charging == true)
                            {
                                txtDialog.Text = "Charizard used SolarBeam!";
                                charging = false;
                            }

                        }
                    }

                    // mewtwo protected itself
                    if (dialogAdvance == 13)
                    {
                        if (protected0 == true)
                        {
                            txtDialog.Text = "The wild Mewtwo protected itself!";
                            dialogAdvance = 2;
                        }

                        else if (protected0 == false)
                        {
                            if (actionChosen == MOVE_FLAMETHROWER)
                            {
                                crit = Fight.StandardCrit();
                            }

                            else if (actionChosen == MOVE_SLASH)
                            {
                                crit = Fight.HighCrit();
                            }

                            else if (actionChosen == MOVE_SOLAR_BEAM)
                            {
                                crit = Fight.StandardCrit();
                            }

                            dialogAdvance = 14;
                        }
                    }

                    // the attack missed
                    if (dialogAdvance == 14)
                    {
                        if (actionChosen == MOVE_AIR_SLASH)
                        {
                            if (AirSlash.Missed() == true)
                            {
                                txtDialog.Text = "The attack Missed!";
                                dialogAdvance = 2;
                            }

                            else
                            {
                                crit = Fight.StandardCrit();
                                dialogAdvance = 15;
                            }
                        }

                        else
                        {
                            dialogAdvance = 15;
                        }
                    }
                    // critical hit and do damage
                    if (dialogAdvance == 15)
                    {
                        // deal damage
                        if (actionChosen == MOVE_FLAMETHROWER)
                        {
                            Mewtwo.HP = Mewtwo.HP - Flamethrower.CalculateDamage(Charizard, Mewtwo, crit);
                            lblMewtwoHP.Text = Mewtwo.HP.ToString();
                            progMewtwoHP.Value = Mewtwo.PercentHealth();
                        }

                        else if (actionChosen == MOVE_AIR_SLASH)
                        {
                            Mewtwo.HP = Mewtwo.HP - AirSlash.CalculateDamage(Charizard, Mewtwo, crit);
                            lblMewtwoHP.Text = Mewtwo.HP.ToString();
                            progMewtwoHP.Value = Mewtwo.PercentHealth();
                        }

                        else if (actionChosen == MOVE_SLASH)
                        {
                            Mewtwo.HP = Mewtwo.HP - Slash.CalculateDamage(Charizard, Mewtwo, crit);
                            lblMewtwoHP.Text = Mewtwo.HP.ToString();
                            progMewtwoHP.Value = Mewtwo.PercentHealth();
                        }

                        else if (actionChosen == MOVE_SOLAR_BEAM)
                        {
                            Mewtwo.HP = Mewtwo.HP - SolarBeam.CalculateDamage(Charizard, Mewtwo, crit);
                            lblMewtwoHP.Text = Mewtwo.HP.ToString();
                            progMewtwoHP.Value = Mewtwo.PercentHealth();
                        }

                        // crit message
                        if (crit == 2)
                        {
                            txtDialog.Text = "A critical hit!";
                        }

                        else
                        {
                            dialogAdvance = 16;
                        }
                    }

                    // mewtwo fainted
                    if (dialogAdvance == 16)
                    {
                        if (Mewtwo.HP <= 0)
                        {
                            txtDialog.Text = "The wild Mewtwo fainted!";
                            Fight.PlayCry(FaintedMewtwoCry);
                            imgMewtwo.Visible = false;
                            gboMewtwo.Visible = false;
                            dialogAdvance = 999;
                        }

                        else
                        {
                            dialogAdvance = 17;
                        }
                    }

                    // mewtwo was burned
                    if (dialogAdvance == 17)
                    {
                        if (Mewtwo.Burned == true)
                        {
                            dialogAdvance = 18;
                        }

                        else if (actionChosen == MOVE_FLAMETHROWER)
                        {
                            if (Flamethrower.Burned() == true && Mewtwo.Burned == false)
                            {
                                txtDialog.Text = "The wild Mewtwo was burned!";
                                Mewtwo.Burned = true;
                                lblBurned.Visible = true;
                                Mewtwo.Atk = Mewtwo.MaxAtk / 2;
                            }

                            else
                            {
                                dialogAdvance = 2;
                            }
                        }


                        else
                        {
                            dialogAdvance = 2;
                        }
                    }
                }

                // mewtwo is hurt by its burn
                if (dialogAdvance == 18)
                {
                    txtDialog.Text = "The wild Mewtwo was hurt by it's burn!";
                    Mewtwo.HP = Mewtwo.HP - Fight.BurnDamage(Mewtwo);
                    lblMewtwoHP.Text = Mewtwo.HP.ToString();
                    progMewtwoHP.Value = Mewtwo.PercentHealth();
                }

                // mewtwo fainted
                if (dialogAdvance == 19)
                {
                    if (Mewtwo.HP <= 0)
                    {
                        Fight.PlayCry(FaintedMewtwoCry);
                        txtDialog.Text = "The wild Mewtwo fainted!";
                        imgMewtwo.Visible = false;
                        gboMewtwo.Visible = false;
                        dialogAdvance = 999;
                    }

                    else
                    {
                        dialogAdvance = 2;
                    }
                }
            }

            //**************************************** ITEM USED *************************************************************************

            else if (itemUsed == true)
            {
                if (dialogAdvance == 4)
                {
                    if (actionChosen == BALL_MASTER_BALL)
                    {
                        txtDialog.Text = "Player used one Master Ball!";
                        MasterBall.BallUsed();
                        btnMasterBall.Text = "x" + MasterBall.TotalNum;
                        imgMewtwo.Image = Pokémon_Game.Properties.Resources.masterball;
                        imgMewtwo.Location = new Point(140, 56);
                    }

                    else if (actionChosen == BALL_ULTRA_BALL)
                    {
                        txtDialog.Text = "Player used one Ultra Ball!";
                        UltraBall.BallUsed();
                        btnUltraBall.Text = "x" + UltraBall.TotalNum;
                        imgMewtwo.Image = Pokémon_Game.Properties.Resources.ultraball;
                        imgMewtwo.Location = new Point(140, 56);
                    }

                    else if (actionChosen == BALL_GREAT_BALL)
                    {
                        txtDialog.Text = "Player used one Great Ball!";
                        GreatBall.BallUsed();
                        btnGreatBall.Text = "x" + GreatBall.TotalNum;
                        imgMewtwo.Image = Pokémon_Game.Properties.Resources.greatball;
                        imgMewtwo.Location = new Point(140, 56);
                    }

                    else if (actionChosen == BALL_POKE_BALL)
                    {
                        txtDialog.Text = "Player used one Poke Ball!";
                        PokeBall.BallUsed();
                        btnPokeBall.Text = "x" + PokeBall.TotalNum;
                        imgMewtwo.Image = Pokémon_Game.Properties.Resources.pokeball;
                        imgMewtwo.Location = new Point(140, 56);
                    }

                    else if (actionChosen == POTION_MAX_POTION)
                    {
                        txtDialog.Text = "Used the Max Potion!";
                        MaxPotion.PotionUsed();
                        btnMaxPotion.Text = "x" + MaxPotion.TotalNum;
                    }
                }

                if (dialogAdvance == 5)
                {
                    if (actionChosen == POTION_MAX_POTION)
                    {
                        int restoredBy = MaxPotion.RestoredBy(Charizard);
                        lblCharizardHP.Text = Charizard.HP.ToString();
                        progCharizardHP.Value = Charizard.PercentHealth();
                        txtDialog.Text = "Charizard's HP was restored by " + restoredBy.ToString() + " points!";
                        dialogAdvance = 3;
                        moveUsed = true;
                    }

                    else if (actionChosen == BALL_POKE_BALL)
                    {
                        shakes = PokeBall.CatchTest(Mewtwo);
                    }

                    else if (actionChosen == BALL_GREAT_BALL)
                    {
                        shakes = GreatBall.CatchTest(Mewtwo);
                    }

                    else if (actionChosen == BALL_ULTRA_BALL)
                    {
                        shakes = UltraBall.CatchTest(Mewtwo);
                    }

                    else if (actionChosen == BALL_MASTER_BALL)
                    {
                        shakes = MasterBall.CatchTest(Mewtwo);
                    }

                    if (dialogAdvance == 5)
                    {
                        if (actionChosen != POTION_MAX_POTION)
                        {
                            // test for output based on shakes
                            if (shakes == 0)
                            {
                                txtDialog.Text = "Oh no! The Pokemon broke free!";
                                Fight.PlayCry(MewtwoCry);
                                if (shiny == true)
                                    imgMewtwo.Image = Pokémon_Game.Properties.Resources.shiny_mewtwo;
                                else
                                    imgMewtwo.Image = Pokémon_Game.Properties.Resources.mewtwo;
                                imgMewtwo.Location = new Point(152, 36);
                                dialogAdvance = 3;
                                moveUsed = true;
                            }

                            else if (shakes == 1)
                            {
                                // shake animation
                                Animate.ShakeAnimation(imgMewtwo);

                                txtDialog.Text = "Aww! It appeared to be caught!";
                                Fight.PlayCry(MewtwoCry);
                                if (shiny == true)
                                    imgMewtwo.Image = Pokémon_Game.Properties.Resources.shiny_mewtwo;
                                else
                                    imgMewtwo.Image = Pokémon_Game.Properties.Resources.mewtwo;
                                imgMewtwo.Location = new Point(152, 36);
                                dialogAdvance = 3;
                                moveUsed = true;
                            }

                            else if (shakes == 2)
                            {
                                // shake animation
                                Animate.ShakeAnimation(imgMewtwo);
                                Animate.ShakeAnimation(imgMewtwo);

                                txtDialog.Text = "Argh! Almost had it!";
                                Fight.PlayCry(MewtwoCry);
                                if (shiny == true)
                                    imgMewtwo.Image = Pokémon_Game.Properties.Resources.shiny_mewtwo;
                                else
                                    imgMewtwo.Image = Pokémon_Game.Properties.Resources.mewtwo;
                                imgMewtwo.Location = new Point(152, 36);
                                dialogAdvance = 3;
                                moveUsed = true;
                            }

                            else if (shakes == 3)
                            {
                                // shake animation
                                Animate.ShakeAnimation(imgMewtwo);
                                Animate.ShakeAnimation(imgMewtwo);
                                Animate.ShakeAnimation(imgMewtwo);

                                txtDialog.Text = "Shoot! It was so close too!";
                                Fight.PlayCry(MewtwoCry);
                                if (shiny == true)
                                    imgMewtwo.Image = Pokémon_Game.Properties.Resources.shiny_mewtwo;
                                else
                                    imgMewtwo.Image = Pokémon_Game.Properties.Resources.mewtwo;
                                imgMewtwo.Location = new Point(152, 36);
                                dialogAdvance = 3;
                                moveUsed = true;
                            }

                            else if (shakes == 4)
                            {
                                // shake animation
                                Animate.ShakeAnimation(imgMewtwo);
                                Animate.ShakeAnimation(imgMewtwo);
                                Animate.ShakeAnimation(imgMewtwo);
                                Animate.ShakeAnimation(imgMewtwo);

                                txtDialog.Text = "Gotcha! Mewtwo was caught!";
                            }
                        }
                    }
                }
            }
        }

        // sets move if chosen flamethrower
        private void btnFlamethrower_Click(object sender, EventArgs e)
        {
            if (dialogAdvance == 3)
            {
                if (Flamethrower.PP > 0)
                {
                    actionChosen = MOVE_FLAMETHROWER;
                    moveUsed = true;
                    itemUsed = false;
                    skipCharizard = false;
                    btnA.Visible = true;
                }

                else
                {
                    txtDialog.Text = "There's no PP left for this move!";
                }
            }
        }

        // sets move if chosen airslash
        private void btnAirSlash_Click(object sender, EventArgs e)
        {
            if (dialogAdvance == 3)
            {
                if (AirSlash.PP > 0)
                {
                    actionChosen = MOVE_AIR_SLASH;
                    moveUsed = true;
                    itemUsed = false;
                    skipCharizard = false;
                    btnA.Visible = true;
                }

                else
                {
                    txtDialog.Text = "There's no PP left for this move!";
                }
            }
        }

        // sets move if chosen solar beam
        private void btnSolarBeam_Click(object sender, EventArgs e)
        {
            if (dialogAdvance == 3)
            {
                if (SolarBeam.PP > 0)
                {
                    actionChosen = MOVE_SOLAR_BEAM;
                    moveUsed = true;
                    itemUsed = false;
                    skipCharizard = false;
                    btnA.Visible = true;
                }

                else
                {
                    txtDialog.Text = "There's no PP left for this move!";
                }
            }
        }

        // sets move if chosen slash
        private void btnSlash_Click(object sender, EventArgs e)
        {
            if (dialogAdvance == 3)
            {
                if (Slash.PP > 0)
                {
                    actionChosen = MOVE_SLASH;
                    moveUsed = true;
                    itemUsed = false;
                    skipCharizard = false;
                    btnA.Visible = true;
                }

                else
                {
                    txtDialog.Text = "There's no PP left for this move!";
                }
            }
        }

        // sets chosen item to ultra ball
        private void btnUltraBall_Click(object sender, EventArgs e)
        {
            if (dialogAdvance == 3)
            {
                if (UltraBall.TotalNum > 0)
                {
                    actionChosen = BALL_ULTRA_BALL;
                    moveUsed = false;
                    itemUsed = true;
                    skipCharizard = true;
                    btnA.Visible = true;
                }

                else
                {
                    txtDialog.Text = "There are no Ultra Balls left!";
                }
            }
        }

        // sets chosen item to great ball
        private void btnGreatBall_Click(object sender, EventArgs e)
        {
            if (dialogAdvance == 3)
            {
                if (GreatBall.TotalNum > 0)
                {
                    actionChosen = BALL_GREAT_BALL;
                    moveUsed = false;
                    itemUsed = true;
                    skipCharizard = true;
                    btnA.Visible = true;
                }

                else
                {
                    txtDialog.Text = "There are no Great Balls left!";
                }
            }
        }

        // sets chosen item to poke ball
        private void btnPokeBall_Click(object sender, EventArgs e)
        {
            if (dialogAdvance == 3)
            {
                if (PokeBall.TotalNum > 0)
                {
                    actionChosen = BALL_POKE_BALL;
                    moveUsed = false;
                    itemUsed = true;
                    skipCharizard = true;
                    btnA.Visible = true;
                }

                else
                {
                    txtDialog.Text = "There are no Poke Balls left!";
                }
            }
        }

        // sets chosen item to max potion
        private void btnMaxPotion_Click(object sender, EventArgs e)
        {
            if (dialogAdvance == 3)
            {
                if (MaxPotion.TotalNum > 0)
                {
                    actionChosen = POTION_MAX_POTION;
                    moveUsed = false;
                    itemUsed = true;
                    skipCharizard = true;
                    btnA.Visible = true;
                }

                else
                {
                    txtDialog.Text = "There are no Max Potions left!";
                }
            }
        }
    }
}
