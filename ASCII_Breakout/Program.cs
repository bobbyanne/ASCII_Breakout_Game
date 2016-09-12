using System;

namespace ASCII_Breakout
{
    class Ball
    {
        public int xPos = 20, yPos = 20;
        public static bool bLeft = false, bRight = false, bUp = false, bDown = false;


        void detectCollision()
        {
            if (bLeft == true)
            {

            }
        }

    }
    class Paddle
    {

    }
    class CharObj
    {
        private int cYPos = 0;
        private int cXPos = 0;
        private char charValue = '*';

        public int CYPos
        {
            get { return cYPos; }
            set { cYPos = value; }
        }
        public int CXPos
        {
            get { return cXPos; }
            set { cXPos = value; }
        }
        public int CharValue
        {
            get { return charValue; }
            set { charValue = (char)value; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int frame = 0;
            int FPS = 60;

            // Create the array to store the chars. horizontal=25 vertical=40
            CharObj[] charObjectArray = new CharObj[1000]; 

            // Populate the charObjectArray. 
            for (int i = 0; i < 1000; i++)
            {
                charObjectArray[i] = new CharObj();
            }

            // Assign x and y position to all charObjects.
            for (int i = 0; i < 1000; i++)
            {
                int x = 0, y = 0;
                if(x == 39)
                {
                    y++;
                    x = 0;
                }
                charObjectArray[i].CYPos = y;
                charObjectArray[i].CXPos = x;
                charObjectArray[i].CharValue = ' ';
                x++;
            }
            for (int i = 0; i < 1000; i++)
            {
                if(i<40)
                {
                    charObjectArray[i].CharValue = '*';
                }
                if(i % 40 == 0)
                {
                    charObjectArray[i].CharValue = '*';
                }
                if (i % 40 == 0)
                {
                    charObjectArray[i+39].CharValue = '*';
                }
            }
            for(int i = 0,x=0,y=0; i < 1000; i++)
            {
                if (y>3 && y<13 && x>9 && x < 30)
                {
                    charObjectArray[i].CharValue = '#';
                }
                if (x == 40)
                {
                    y++;
                    x = 0;
                }
                x++;
            }
            for(int i = 0; i < 1000; i++)
            {
                    if (i%40 == 0)
                    {
                        Console.WriteLine();
                    }
                    Console.Write((char)charObjectArray[i].CharValue);
            }
            Console.ReadLine();
        }
    }
}
