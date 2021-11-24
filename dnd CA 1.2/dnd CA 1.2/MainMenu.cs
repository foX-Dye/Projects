﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_CA_1._2
{
    class MainMenu : DescriptorsOfThrows
    {
        DFour deeFour = new DFour();
        DSix deeSix = new DSix();
        DEight deeeight = new DEight();
        //DTen deeTen = new DTen();
        DTwelve deeTwelve = new DTwelve();
        DTwenty deeTwenty = new DTwenty();
        DescriptorsOfThrows stories = new DescriptorsOfThrows();
        public MainMenu()
        {

        }
        public bool SelectionMenu()
        {
           Console.WriteLine("-------------------------------------------------------");
           Console.WriteLine("press 1 for D4.\npress 2 for D6. \npress 3 for D8.\npress 4 for D10. \npress 5 for D12.\npress 6 for D20. \nOr press Q to quit.");
            string input = "";

            int diceSelected = 0;
            bool result;
            int intOut;
            string displayMessage = "";
            bool diceStatus = true;

            while (diceStatus)
            {
                input = Console.ReadLine();
                if (input.ToLower() != "q")
                {
                    result = int.TryParse(input, out intOut);

                    if (result)
                    {
                        diceSelected = int.Parse(input);
                    }

                    int randomNumberRolled = 0;

                    switch (diceSelected)
                    {
                        case 1:
                            randomNumberRolled = DFour.D4();
                            break;
                        case 2:
                            randomNumberRolled = DSix.D6();
                            break;
                        case 3:
                            randomNumberRolled = DEight.D8();
                            break;
                        case 4:
                            randomNumberRolled = DTen.D10();
                            break;
                        case 5:
                            randomNumberRolled = DTwelve.D12();
                            break;
                        case 6:
                            randomNumberRolled = DTwenty.D20();
                            break;
                        default:
                            displayMessage = "Please enter 1 through 6.";
                            break;
                    }
                    string storyTime = DescriptorsOfThrows.GenerateDescriptor(randomNumberRolled);
                    Console.WriteLine(storyTime);
                }
                else
                {
                    diceStatus = false;
                }
            }
            return true;
            
        }
        
    }
}

