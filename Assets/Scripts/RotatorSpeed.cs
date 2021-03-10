using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotatorSpeed : MonoBehaviour
{

    public static float rSpeed;
    
    public void Start()
    {
        rSpeed = 1f;
    }

    public void Change(float f)
    {
        GetComponent<Text>().text = f.ToString();
        rSpeed = f * .35f;
    }
}
