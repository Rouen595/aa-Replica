using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseNumLives : MonoBehaviour
{
    
    public static int numLives;

    // initialize lives in case user does not iteract with the dropdown
    void Start()
    {
        numLives = 1;
    }

    //public Text livesText;
    public Dropdown SelectLives;

    public void NumLives()
    {
        switch (SelectLives.value)
        {
            case 1:
                numLives = 1;
                //livesText.text = "1";
                break;
            case 2:
                numLives = 3;
                //livesText.text = "3";
                break;
            case 3:
                numLives = 5;
                //livesText.text = "5";
                break;
            default:
                numLives = 1;
                //livesText.text = "Please select number of lives";
                break;

        }
    }
}
