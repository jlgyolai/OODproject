using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Design_Project
{
    public class Card
    {
        private int _deckNo = 0;
        private int _valueOf = 2;
        private int _suit = 0;
        private int _face = 1;

        /*
         * Suits
         * *************
         * Hearts   = 0
         * Diamonds = 1
         * Spades   = 2
         * Clubs    = 3
         * *************
         * 
         * Face
         * *************
         * Ace      = 1
         * Jack     = 11
         * Queen    = 12
         * King     = 13
         * *************
         */
            
        //creates a unique instance of a card
        public Card(int setFace, int setSuit, int setDeck)
        {
            Face = setFace;
            ValueOf = setFace;
            Suit = setSuit;
            DeckNo = setDeck;
        }

        //depending on the card, the proper image.png is returned for the card's front
        public Image cardFront()
        {
            const string Name_0 = @"Object Oriented Design Project.Images.";
            string Name_1 = Face switch
            {
                1 => "ace",
                11 => "jack",
                12 => "queen",
                13 => "king",
                _ => Face.ToString(),
            };
            const string Name_2 = "_of_";
            string Name_3 = Suit switch
            {
                0 => "hearts",
                1 => "diamonds",
                2 => "spades",
                _ => "clubs",
            };
            const string Name_4 = ".png";
            string filename = string.Concat(Name_0, Name_1, Name_2, Name_3, Name_4);
            Assembly assembly = Assembly.GetExecutingAssembly();
            Image ReturnVal;
            Size size = new Size(222, 323);
            using (Stream stream = assembly.GetManifestResourceStream(filename))
            {
                ReturnVal = (Image)new Bitmap(Image.FromStream(stream), size);
            }
            return ReturnVal;

        }

        //returns the back image.png of the card
        #region card backs
        static public Image getCardBackImage()
        {
            Image ReturnVal = Properties.Resources.back;

            return ReturnVal;
        }

        static public Image getCardBackImageEyes()
        {
            Image ReturnVal = Properties.Resources.eyes;

            return ReturnVal;
        }

        static public Image getCardBackImageGoldenFlower()
        {
            Image ReturnVal = Properties.Resources.goldenFlower;

            return ReturnVal;
        }

        static public Image getCardBackImageOwls()
        {
            Image ReturnVal = Properties.Resources.owls;

            return ReturnVal;
        }

        static public Image getCardBackImageSnakesRed()
        {
            Image ReturnVal = Properties.Resources.snakesRed;

            return ReturnVal;
        }

        static public Image getCardBackImageSnakes()
        {
            Image ReturnVal = Properties.Resources.snakes;

            return ReturnVal;
        }

        static public Image getCardBackImageDragonsBlue()
        {
            Image ReturnVal = Properties.Resources.dragonsBlue;

            return ReturnVal;
        }
        #endregion

        //card's face field
        //determines the card's front image.
        //1 = ace
        //2-10 = number card
        //11, 12, 13 = jack, queen, king
        public int Face
        {
            set
            {
                if ((value > 0) && (value < 14))
                {
                    _face = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Face value must be 1-13.", (Exception)null);
                }
            }
            get { return _face; }
        }

        //card's value field
        //value can be 2-10 depending on the face value
        public int ValueOf
        {
            set
            {
                if(_face >=2 && _face <11)
                {
                    _valueOf = _face;
                }
                else if(_face == 1 && ((value == 1) ||(value == 11)))
                {
                    _valueOf = value;
                }
                else if(_face >= 11 && _face < 14)
                {
                    _valueOf = 10;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Value must be 2-10, unless the card is an ace.", (Exception)null);
                }
            }
            get { return _valueOf; }
        }

        //card suit field. 0-3 determines the card's suit
        public int Suit
        {
            set
            {
                if((value >= 0)&&(value <= 3))
                {
                    _suit = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Suit must be 0-3.", (Exception)null);
                }
            }
            get { return _suit; }
        }

        //DeckNo field. Number of decks in circulation. Might not need, but added just in case we wanted infinite card combos in
        //memory card game since single deck is irrelevant. Might make War a 2 deck game.
        public int DeckNo
        {
            set
            {
                if(value >= 0)
                {
                    _deckNo = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Deck number can't be negative.", (Exception)null);
                }
            }
            get { return _deckNo; }
        }
    }
}
