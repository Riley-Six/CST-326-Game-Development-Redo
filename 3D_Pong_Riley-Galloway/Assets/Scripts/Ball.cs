using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 4f;
    public float faster = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        float initialDirectionX = Random.Range(0, 2) == 0 ? -1 : 1;
        float initialDirectionZ = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody>().velocity = new Vector3(speed * initialDirectionX, 0f, speed * initialDirectionZ);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Left Paddle")
        {
            Debug.Log("Left Paddle Bonk");
        }
        if (collision.gameObject.tag == "Right Paddle")
        {
            Debug.Log("Right Paddle Bonk");
        }
        if (collision.gameObject.tag == "Left Goal")
        {
            Debug.Log("Left Goal Bop");
            

        }
        if (collision.gameObject.tag == "Right Goal")
        {
            Debug.Log("Right Goal Bop");
            

        }
    }
}
