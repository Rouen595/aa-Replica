using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinSpeed : MonoBehaviour
{

    public static float pSpeed;

    void Start()
    {
        pSpeed = 1f;
    }

    public void Change(float f)
    {
        GetComponent<Text>().text = f.ToString();
        pSpeed = f * .35f;
    }
}
