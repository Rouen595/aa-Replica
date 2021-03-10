using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesText : MonoBehaviour
{
    public Text lText;
    // Start is called before the first frame update
    void Start()
    {
        lText.text = "Lives: " + ChooseNumLives.numLives;
    }
}
