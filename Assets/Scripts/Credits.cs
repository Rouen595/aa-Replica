using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{

    public Text creditsName;
    public Text creditsScore;
    public Text creditsLives;

    void Start()
    {
        creditsName.text = Name.username;
        creditsScore.text = "Score: " + Score.PinCount;
        creditsLives.text = "Lives: " + ChooseNumLives.numLives;
    }


    public void RestartGame()
    {
        Name.username = "Player";
        Score.PinCount = 0;
        RotatorSpeed.rSpeed = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void Quit()
    {
        Debug.Log("QUIT");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif

        Application.Quit();
    }

}
