using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameManager
{
    // Define your variables that you want to save throughout the game
    public static int Index = 0; // Note: Make these variables static
    public static int Stars = 0;

    // You can use PlayerPrefs to save and load these variables

    // Save the game state
    public static void SaveGameState(int dialogueIndex)
    {
        Index = dialogueIndex; // Update the Index variable with the provided value
        PlayerPrefs.SetInt("Index", Index);
        PlayerPrefs.SetInt("Stars", Stars);
        PlayerPrefs.Save();
    }

    // Load the game state
    public static void LoadGameState()
    {
        if (PlayerPrefs.HasKey("Index"))
        {
            Index = PlayerPrefs.GetInt("Index");
        }

        if (PlayerPrefs.HasKey("Stars"))
        {
            Stars = PlayerPrefs.GetInt("Stars");
        }
    }
}