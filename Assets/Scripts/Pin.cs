using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;
    public static bool hitaPin;

    public float speed = 20f;
    public Rigidbody2D rb;

    void Start ()
    {
        hitaPin = false;
    }

    void Update ()
    {
        if (!isPinned || !hitaPin)
        {
            rb.MovePosition(rb.position + Vector2.up * (speed * PinSpeed.pSpeed) * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.tag == "Pin")
        {
            // END THE GAME
            hitaPin = true;
            Debug.Log("GAME OVER");
            FindObjectOfType<GameManager>().EndGame();

        }
        else if (col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            if (!hitaPin)
            {
                Score.PinCount++;
            }
            //speed up on hit
            //col.GetComponent<Rotator>().speed += 5f;
            
            //turn backwards on hit
            //col.GetComponent<Rotator>().speed *= -1;
            isPinned = true;
        } 
    }

}
