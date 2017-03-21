using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using ProgramEx_ch_01_mkadutskyi.Properties;
using static System.Console;

//using static ProgramEx_ch_01_mkadutskyi.Properties.CallableFunctions;

namespace ProgramEx_ch_01_mkadutskyi
{
    internal class Program
    {
        private static readonly string[] FunctionList = {"HelloWorld", "InfoBanner", "XOutput"};
        protected static string MsgBoxTxt;
        protected static MessageBox DialogBox;

        public static void Main(string[] args)
        {
            int exNum;
            string userInput;

            CreateMenu();
            WriteLine(
                "Hi. This is application containing execercises for the book \"C# Programming Barbara Doyle\"");
            WriteLine(
                "************************************************************************************************************");

            while (true)
            {
                ShowMenu();
                userInput = ReadLine();
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Environment.Exit(1);
                }

                if (Int32.TryParse(userInput, out exNum))
                {
                    WriteLine("\n*******************************\nProgram " + FunctionList[exNum - 1] +
                              " started \n*********************************");
                    RunFunction(FunctionList[exNum - 1]);
                    WriteLine("\n*******************************\nProgram " + FunctionList[exNum - 1] +
                              " stopped its execution \n*********************************");
                }
            }
        }

        static object RunFunction(string functionName)
        {
            MethodInfo[] methodInfos =
                typeof(CallableFunctions).GetMethods(BindingFlags.Public | BindingFlags.Instance);
            var callableFunctions = new CallableFunctions();
            return methodInfos.First(mi => mi.Name == functionName).Invoke(callableFunctions, null);
        }

        static void ShowMenu()
        {
            WriteLine("Here is the List of Programmes: \n");
            WriteLine(MsgBoxTxt);
            WriteLine(
                "Type index number of the programm you want to run and press \"Enter\" or just press \"Enter\" to stop application.\n");
        }

        static void CreateMenu()
        {
            for (int i = 0; i < FunctionList.Length; i++)
            {
                MsgBoxTxt += i + 1 + ". " + FunctionList[i] + "\n";
            }
        }
    }
}