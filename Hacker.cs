﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    int level; // Game State

    enum Screen { MainMenu, Password, Win};
    Screen currentScreen = Screen.MainMenu;

    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
       // print("Hello " + "World");

    }
    // Main Menu 
    void ShowMainMenu()
    {   
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the police station");
        Terminal.WriteLine("Enter your selection");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
    // User Input for menu selection
    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        } //TODO handle differently depending on the screen
        else if(input=="1")
        {
            level = 1;
            StartGame();
        }
        else if(input=="2")
        {
            level = 2;
            StartGame();
        }
        else if (input=="007")
        {
            Terminal.WriteLine("Please select a level Mr Bond!");
        }
        else
        {
            Terminal.WriteLine("Please choose a valid level");
        }
    }
    //Start the game function
    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have chosen level " + level);
        Terminal.WriteLine("Please enter your password: ");

    }
}
