using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Stars : MonoBehaviour
{  
    int yellow = 1;
    int green = 2;
    int blue = 3;
    int total = 0;
    void Start()
    {
        UpdateStarText();
        //myCoins = Globals.coins;
    }

    [SerializeField] private TMP_Text starText;
    
   void OnTriggerEnter2D(Collider2D collision)
   {
        if(collision.gameObject.CompareTag("yellowStar"))
        {
            total+=yellow;
        }

        else if(collision.gameObject.CompareTag("greenStar"))
        {
            total+=green;
        }

        else if(collision.gameObject.CompareTag("blueStar"))
        {
            total+=blue;
        }
    
        Destroy(collision.gameObject);
        UpdateStarText();
   }
   void UpdateStarText()
    {
        starText.text = "Stars Collected: " + total.ToString();
    }
}

    