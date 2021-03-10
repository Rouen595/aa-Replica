using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int PinCount = 0;

    public Text text;
    public Animator animator;

    // initialize static variables to 0 in a start method
    void Start ()
    {
       // PinCount = 0;
    }

    void Update ()
    {
        text.text = PinCount.ToString();
        if (FindObjectOfType<GameManager>().gameHasEnded)
        {
            animator.SetTrigger("EndGame");
        }
    }


}
