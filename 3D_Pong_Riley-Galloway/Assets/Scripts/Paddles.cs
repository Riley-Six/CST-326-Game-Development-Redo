using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public bool isLpaddle;
    //Left = True, Right = False
    public float speed = 4f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isLpaddle)
        {
            transform.Translate(0f, Input.GetAxis("Horizontal1") * speed * Time.deltaTime, 0f);
        }
        else
        {
            transform.Translate(0f, Input.GetAxis("Horizontal2") * speed * Time.deltaTime, 0f);
        }

    }
}