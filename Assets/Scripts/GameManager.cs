using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text nameText;
    public Text livesText;

    public bool gameHasEnded = false;

    public Rotator rotator;
    public Spawner spawner;

    public Animator animator;

    public void EndGame()
    {
        if (gameHasEnded) {
            return;
        }
        
        Debug.Log("END GAME");
        rotator.enabled = false;
        spawner.enabled = false;
      
        
        if (Pin.hitaPin)
        {
            ChooseNumLives.numLives--;
            
        }
        
        if (ChooseNumLives.numLives < 1)
        {
            Score.PinCount = 0;
            Invoke("EnterMenu", .5f);
        }
        animator.SetTrigger("EndGame");
        gameHasEnded = true;
    }

    public void NextLevel ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void EnterMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void RestartLevel ()
    {
        Score.PinCount = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void Start()
    {
        nameText.text = Name.username;
        livesText.text = "Lives: " + ChooseNumLives.numLives;
    }
}
