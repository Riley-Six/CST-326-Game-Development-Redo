using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheild : MonoBehaviour
{

    public Score_Lives scoreKeeper;


    void OnCollisionEnter2D(Collision2D collision)
    { 
        if(collision.gameObject.name != "Top Wall")
        {
            Destroy(collision.gameObject);
        } else
        {
            Debug.Log("Top Wall");
        }
        

    }



        // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
