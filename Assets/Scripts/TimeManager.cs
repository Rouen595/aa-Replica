using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{

    public Text timeLimitText;
    public Text remainingTimeText;

    public static float timeRemaining;

    // Start is called before the first frame update
    void Start()
    {
        if (GameTime.rTime > 0)
        {
            timeRemaining = GameTime.rTime;
        }
        else
        {
            timeRemaining = 10.0f;
        }

        timeLimitText.text = "Time Limit: " + GameTime.gTime.ToString();
        remainingTimeText.text = "Time Remaining: " + timeRemaining.ToString("F2");        
    }

    // Update is called once per frame
    void Update()
    {
        timeRemaining -= Time.deltaTime;
        if (timeRemaining >= 0)
        {
            remainingTimeText.text = "Time Remaining: " + timeRemaining.ToString("F2");
        }
        else
        {
            remainingTimeText.text = "Game Over";
            Invoke("TimeUp", 2.0f);
        }
    }

    void TimeUp()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
