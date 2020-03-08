using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))] //technique for making sure there isn't a null reference during runtime if you are going to use get component
public class Bullet : MonoBehaviour
{
    private Rigidbody2D myRigidbody2D;
    public Enemy top;
    public Enemy mid;
    public Enemy bottom;
    public Enemy forth;
    public Score_Lives scoreKeeper;
    public int yo;


    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {

        scoreKeeper = GameObject.FindObjectOfType<Score_Lives>();
        myRigidbody2D = GetComponent<Rigidbody2D>();
        Fire();
    }

    // Update is called once per frame
    private void Fire()
    {
      myRigidbody2D.velocity = Vector2.up * speed; 
      //Debug.Log("Bang Bang I'm a Goose");
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("EXPIRE!!!");
        //Destroy(collision.gameObject);

        if (collision.gameObject.name == "Enemytype1")
        {
            yo = 5;
            //scoreKeeper.AddScore(yo);
            Debug.Log("bulley yo 1");
            //Score_Lives.AddScore("Enemytype1");
            //Score_Lives.AddScore(collision.gameObject.name);
        }
        else if (collision.gameObject.name == "Enemytype2")
        {
            yo = 10;
            //Score_Lives.AddScore(yo);
        }
        else if (collision.gameObject.name == "Enemytype3")
        {
            yo = 15;
            //Score_Lives.AddScore(yo);
        }
        else if (collision.gameObject.name == "Player3")
        {
            yo = 25;
            //Score_Lives.AddScore(yo);
            Debug.Log("4");
        } else
        {
            //yo = -10;
        }
        scoreKeeper.AddScore(yo);
        Debug.Log("EXPIRE!!!");
        Debug.Log(collision.gameObject.name);
        Destroy(collision.gameObject);

        //Score_Lives.AddScore(this);
        /*
        if (collision.gameObject.name == "Enemytype1")
        {
            yo = 1;
            Score_Lives.AddScore(yo);
        } else if (collision.gameObject.name == "Enemytype2")
        {
            yo = 2;
            Score_Lives.AddScore(yo);
        } else if (collision.gameObject.name == "Enemytype3")
        {
            yo = 3;
            Score_Lives.AddScore(yo);
        }
        else if (collision.gameObject.name == "Player3")
        {
            yo = 4;
            Score_Lives.AddScore(yo);
        }*/
    }
}
