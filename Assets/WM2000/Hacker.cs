using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    int ragna = 0;
    string[] Level1Passwords = { "swordsman", "archer", "healer", "assassin", "mage" };
    string[] Level2Passwords = { "cardinal", "paladin", "rogue", "highwizard", "sniper" };
    string[] Level3Passwords = { "pope", "crusader", "sagittarius", "shadowchaser", "sorcerer" };
    int level;
    enum Screen { MainMenu, Password, Win };
    Screen CurrentScreen;
    string input;
    string password;
    string[] hint1 = { "swmnodrsa", "rarhec", "rehlae", "aiaassssn", "gema" };
    string[] hint2 = { "larcidan", "lindpaa", "uoegr", "hhgdrzwiia", "rnisep" };
    string[] hint3 = { "oppe", "rrcsdaeu", "ttsgruiisa", "sshrdwhaaoec", "rrreeos" };
    void Start()
    {
        print(level);
        ShowMainMenu();


    }
    void ShowMainMenu()
    {
        CurrentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("M1T18\r\n");
        Terminal.WriteLine("Hello Adventurer! What Level are you in?\r\n");
        Terminal.WriteLine("Press 1  Beginner Level (Level 1 -29)");
        Terminal.WriteLine("Press 2 Knight Level (Level 30-59)");
        Terminal.WriteLine("Press 3  Grandmaster Level (Level 60 and above)");
        Terminal.WriteLine("Enter your selection:");
    }


    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();

        }
        else if (input == "GM")
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("Accepted. A special (Rare) Pack has been sent into your bag");
        }
        else if (input == "Developer")
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("Accepted. A special (Legendary) Pack has been sent into your bag");

        }
        else if (CurrentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (CurrentScreen == Screen.Password)
        {
            CheckForPassword(input);
        }
        else if (CurrentScreen == Screen.Win)
        {
            Winning();
        }

        else
        {
            Terminal.WriteLine("Please Choose a Valid Level");
        }


    }
    void RunMainMenu(string input)
    {
        bool isValidLevelNumber = (input == "1" || input == "2" || input == "3");
        if (isValidLevelNumber)
        {
            level = int.Parse(input);
            AskForPassword();
        }
    }
    void AskForPassword()
    {
        CurrentScreen = Screen.Password;
        Terminal.ClearScreen();
        SetRandomPassword();
    }
    void SetRandomPassword()
    {
        switch (level)
        {
            case 1:
                password = Level1Passwords[ragna];
                Level1();
                break;
            case 2:
                password = Level2Passwords[ragna];
                Level2();
                break;
            case 3:
                password = Level3Passwords[ragna];
                Level3();
                break;
        }
    }
    void CheckForPassword(string input)
    {
        if (level == 1)
        {
            if (input == password)
            {
                Winning();
            }
            else
            {
                Terminal.WriteLine("Wrong Password! Try Again");
                if (ragna < 4)
                {
                    ragna++;
                }
                else
                {
                    ragna = 0;
                }
                SetRandomPassword();
            }
        }
        else if (level == 2)
        {
            if (input == password)
            {
                Winning();
            }
            else
            {
                Terminal.WriteLine("Wrong Password! Try Again");
                if (ragna < 4)
                {
                    ragna++;
                }
                else
                {
                    ragna = 0;
                }
                SetRandomPassword();
            }
        }
        else if (level == 3)
        {
            if (input == password)
            {
                Winning();
            }
            else
            {
                Terminal.WriteLine("Wrong Password! Try Again");
                if (ragna < 4)
                {
                    ragna++;
                }
                else
                {
                    ragna = 0;
                }
                SetRandomPassword();
            }
        }
    }


    void Winning()
    {
        CurrentScreen = Screen.Win;
        switch (level)
        {
            case 1:
                Terminal.WriteLine("These items has been sent into your bag:");
                Terminal.WriteLine("Leather Armor.");
                Terminal.WriteLine("Beginner's Weapon");
                Terminal.WriteLine("Horse Steed.");
                CurrentScreen = Screen.MainMenu;
                break;



            case 2:
                Terminal.WriteLine("These items has been sent into your bag:");
                Terminal.WriteLine("Silver Armor");
                Terminal.WriteLine("Elven Weapon.");
                Terminal.WriteLine("Lion Steed.");
                Terminal.WriteLine("Butterfly Wings.");
                CurrentScreen = Screen.MainMenu;
                break;


            case 3:
                Terminal.WriteLine("These items has been sent into your bag:");
                Terminal.WriteLine("Titanium Armor");
                Terminal.WriteLine("Platinum Weapon.");
                Terminal.WriteLine("Dragon Steed");
                Terminal.WriteLine("Phoenix Wings.");
                CurrentScreen = Screen.MainMenu;
                break;

        }
    }
    void Level1()
    {
        Terminal.WriteLine("Enter the Password");
        Terminal.WriteLine("hint:     " + hint1[ragna]);
    }
    void Level2()
    {
        Terminal.WriteLine("Enter the Password");
        Terminal.WriteLine("hint:     " + hint2[ragna]);
    }
    void Level3()
    {
        Terminal.WriteLine("Enter the Password");
        Terminal.WriteLine("hint:     " + hint3[ragna]);
    }
}


