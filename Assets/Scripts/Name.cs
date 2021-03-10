// aa replica
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    public InputField usernameInput;
    public static string username;

    void Start()
    {
        username = "Player";
    }

    public void SaveUsername(string newName)
    {
        username = newName;
    }
}
