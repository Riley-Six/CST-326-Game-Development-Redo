using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DestroyBlock : MonoBehaviour
{


    public GameObject QuestionBox;

    public GameObject Coin;

    public GameObject DEATH;

    public GameObject Finish;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI timer;
    public int points = 0;
    public int coinPoints = 0;

    // Start is called before the first frame update
    void Start()
    {
        QuestionBox.GetComponent<GameObject>();
        Coin.GetComponent<GameObject>();

    }
    /*
    private void Update()
    {
        if(Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);


            if (Physics.Raycast(ray, out hit))
            {
                BoxCollider bc = hit.collider as BoxCollider;

                if (bc != null)
                {
                    Destroy(bc.gameObject);
                }
            }
        }
    }*/
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "QuestionBox(Clone)" || collision.gameObject.name == "Coin(Clone)")
        {
            Debug.Log("HERE");
            if (collision.gameObject.name == "QuestionBox(Clone)") {
                points = points + 100;
                scoreText.text = "0000" + points;
                if (points >= 99)
                { 
                    scoreText.text = "00" + points;
                }
            } else
            {
                coinPoints = coinPoints + 1;
                coinText.text = "" + coinPoints;
                points = points + 100;
                scoreText.text = "0000" + points;
                if (points >= 99)
                {
                    scoreText.text = "00" + points;
                }
            }
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "DEATH(Clone)")
        {
            Destroy(GameObject.Find("Ethan"));
            timer.text = "DEATH!!!!";
            timer.color = Color.yellow;
        }

        if (collision.gameObject.name == "Finish(Clone)")
        {
            Debug.Log("Win");
            timer.text = "WINNER!!!";
            
        }




    }
}
