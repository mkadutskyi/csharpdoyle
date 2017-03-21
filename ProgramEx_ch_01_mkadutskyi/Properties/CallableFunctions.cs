using System;
using static System.Console;

namespace ProgramEx_ch_01_mkadutskyi.Properties
{
    public class CallableFunctions
    {
        public void HelloWorld()
        {
            WriteLine("Hello World! My Name is Mykola Kadutskyi!");
        }

        public void InfoBanner()
        {
            WriteLine("***************************************************************");
            WriteLine("**     Programmin Assignment #2                              **");
            WriteLine("**     Developer: Mykola Kadutskyi                           **");
            WriteLine("**     Date Submitted: 01/01/1970                            **");
            WriteLine("**     Purpose: Provide Internal Documentation               **");
            WriteLine("***************************************************************");
        }

        public void XOutput()
        {
            WriteLine("This program will output ");
            int Width = 100;
            int Height = 21;
            int checkSide = 0;
            if (Width < Height)
            {

            }
            for (int i = 0; i < Height; i++)
            {
                if (checkSide == 0)
                {
                    string before = new String(' ', Width / Height * i);
                    string after = new String(' ', Width - 2 * i * Width / Height);

                    WriteLine(before + "##" + after + "##");
                    if (Width / Height * i - Width + 2 * i * Width / Height == Width / 2)
                    {
                        checkSide = 1;
                    }
                }
                else
                {
                    string before = new String(' ', Width - Width / Height * i);
                    string after = new String(' ', 2 * i * Width / Height - Width);

                    WriteLine(before + "##" + after + "##");
                }
            }
        }
    }
}