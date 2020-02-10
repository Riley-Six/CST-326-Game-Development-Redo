/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddles : MonoBehaviour
{
    public bool isLpaddle;
    //Left = True, Right = False
    public float speed = 4f;
    public int multiplier = 5;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isLpaddle)
        {
            
            transform.Translate(0f, 0f, Input.GetAxis("Horizontal1") * speed * Time.deltaTime * multiplier);
        }
        else
        {
            transform.Translate(0f, 0f, Input.GetAxis("Horizontal2") * speed * Time.deltaTime * multiplier);
        }

    }
}*/

