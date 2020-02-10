using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public AudioClip hitSound;

    public AudioSource speaker;

    /*
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            Debug.Log("Paddle Bonk");
            speaker.PlayOneShot(hitSound);
        }

    }
    */

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            speaker.PlayOneShot(hitSound);
        }
            
    }
}
