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
        public Card(int setFace, int setSuit)
        {
            Face = setFace;
            ValueOf = setFace;
            Suit = setSuit;
            
        }

        //depending on the card, the proper image.png is returned for the card's front
        public Image cardFront()
        {
            switch (Face)
            {
                case 1:
                    if (Suit == 0)
                        return Properties.Resources.ace_of_hearts;
                    else if (Suit == 1)
                        return Properties.Resources.ace_of_diamonds;
                    else if (Suit == 2)
                        return Properties.Resources.ace_of_spades;
                    else
                        return Properties.Resources.ace_of_clubs;
                case 2:
                    if (Suit == 0)
                        return Properties.Resources._2_of_hearts;
                    else if (Suit == 1)
                        return Properties.Resources._2_of_diamonds;
                    else if (Suit == 2)
                        return Properties.Resources._2_of_spades;
                    else
                        return Properties.Resources._2_of_clubs;
                case 3:
                    if (Suit == 0)
                        return Properties.Resources._3_of_hearts;
                    else if (Suit == 1)
                        return Properties.Resources._3_of_diamonds;
                    else if (Suit == 2)
                        return Properties.Resources._3_of_spades;
                    else
                        return Properties.Resources._3_of_clubs;
                case 4:
                    if (Suit == 0)
                        return Properties.Resources._4_of_hearts;
                    else if (Suit == 1)
                        return Properties.Resources._4_of_diamonds;
                    else if (Suit == 2)
                        return Properties.Resources._4_of_spades;
                    else
                        return Properties.Resources._4_of_clubs;
                case 5:
                    if (Suit == 0)
                        return Properties.Resources._5_of_hearts;
                    else if (Suit == 1)
                        return Properties.Resources._5_of_diamonds;
                    else if (Suit == 2)
                        return Properties.Resources._5_of_spades;
                    else
                        return Properties.Resources._5_of_clubs;
                case 6:
                    if (Suit == 0)
                        return Properties.Resources._6_of_hearts;
                    else if (Suit == 1)
                        return Properties.Resources._6_of_diamonds;
                    else if (Suit == 2)
                        return Properties.Resources._6_of_spades;
                    else
                        return Properties.Resources._6_of_clubs;
                case 7:
                    if (Suit == 0)
                        return Properties.Resources._7_of_hearts;
                    else if (Suit == 1)
                        return Properties.Resources._7_of_diamonds;
                    else if (Suit == 2)
                        return Properties.Resources._7_of_spades;
                    else
                        return Properties.Resources._7_of_clubs;
                case 8:
                    if (Suit == 0)
                        return Properties.Resources._8_of_hearts;
                    else if (Suit == 1)
                        return Properties.Resources._8_of_diamonds;
                    else if (Suit == 2)
                        return Properties.Resources._8_of_spades;
                    else
                        return Properties.Resources._8_of_clubs;
                case 9:
                    if (Suit == 0)
                        return Properties.Resources._9_of_hearts;
                    else if (Suit == 1)
                        return Properties.Resources._9_of_diamonds;
                    else if (Suit == 2)
                        return Properties.Resources._9_of_spades;
                    else
                        return Properties.Resources._9_of_clubs;
                case 10:
                    if (Suit == 0)
                        return Properties.Resources._10_of_hearts;
                    else if (Suit == 1)
                        return Properties.Resources._10_of_diamonds;
                    else if (Suit == 2)
                        return Properties.Resources._10_of_spades;
                    else
                        return Properties.Resources._10_of_clubs;
                case 11:
                    if (Suit == 0)
                        return Properties.Resources.jack_of_hearts;
                    else if (Suit == 1)
                        return Properties.Resources.jack_of_diamonds;
                    else if (Suit == 2)
                        return Properties.Resources.jack_of_spades;
                    else
                        return Properties.Resources.jack_of_clubs;
                case 12:
                    if (Suit == 0)
                        return Properties.Resources.queen_of_hearts;
                    else if (Suit == 1)
                        return Properties.Resources.queen_of_diamonds;
                    else if (Suit == 2)
                        return Properties.Resources.queen_of_spades;
                    else
                        return Properties.Resources.queen_of_clubs;
                case 13:
                    if (Suit == 0)
                        return Properties.Resources.king_of_hearts;
                    else if (Suit == 1)
                        return Properties.Resources.king_of_diamonds;
                    else if (Suit == 2)
                        return Properties.Resources.king_of_spades;
                    else
                        return Properties.Resources.king_of_clubs;
                default:
                    Console.WriteLine("Error: Card face value out of range.");
                    return Properties.Resources.back;
            }

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


    } 
}

