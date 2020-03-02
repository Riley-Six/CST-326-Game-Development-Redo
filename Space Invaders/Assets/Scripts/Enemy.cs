using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //[SerializeField] private GameManager gameManager;
    // Start is called before the first frame update
    //[SerializeField] public AddingScore addingUp;
    void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log("Ouch!");
        Destroy(collision.gameObject);
        //Score_Lives.AddScore(this);
        /*if (collision.gameObject.name == "Enemytype1")
        {
            //yo = 1;
            addingUp.AddScore(this);
        }
        else if (collision.gameObject.name == "Enemytype2")
        {
            //yo = 2;
            addingUp.AddScore(this);
        }
        else if (collision.gameObject.name == "Enemytype3")
        {
            //yo = 3;
            addingUp.AddScore(this);
        }
        else if (collision.gameObject.name == "Player3")
        {
            //yo = 4;
            addingUp.AddScore(this);
        }*/

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
