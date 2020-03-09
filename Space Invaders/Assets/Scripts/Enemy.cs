using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //[SerializeField] private GameManager gameManager;
    // Start is called before the first frame update
    //[SerializeField] public AddingScore addingUp;
    //public int yo;

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Score_Lives.AddScore(this);

        //Score_Lives.AddScore(this);
        /*
        if (collision.gameObject.name == "Enemytype1")
        {
            yo = 1;
            Score_Lives.AddScore(yo);
        }
        else if (collision.gameObject.name == "Enemytype2")
        {
            yo = 2;
            Score_Lives.AddScore(yo);
        }
        else if (collision.gameObject.name == "Enemytype3")
        {
            yo = 3;
            Score_Lives.AddScore(yo);
        }
        else if (collision.gameObject.name == "Player3")
        {
            yo = 4;
            Score_Lives.AddScore(yo);
            Debug.Log("4");
        }*/

        Debug.Log("Ouch!");
        GetComponent<Animator>().SetTrigger("Death");
        Destroy(collision.gameObject);
    }

    /*void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("EXPIRE!!!");
        Destroy(collision.gameObject);
        Score_Lives.AddScore(this);
        /*
        if (collision.gameObject.name == "Enemytype1")
        {
            //yo = 1;
            Score_Lives.AddScore(this);
        }
        else if (collision.gameObject.name == "Enemytype2")
        {
            //yo = 2;
            Score_Lives.AddScore(this);
        }
        else if (collision.gameObject.name == "Enemytype3")
        {
            //yo = 3;
            Score_Lives.AddScore(this);
        }
        else if (collision.gameObject.name == "Player3")
        {
            //yo = 4;
            Score_Lives.AddScore(tis);
        }*/
    //}
}
