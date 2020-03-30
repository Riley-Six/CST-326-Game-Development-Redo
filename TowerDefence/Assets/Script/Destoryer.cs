using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destoryer : MonoBehaviour
{

    public GameObject bad1;

    public GameObject bad2;

    private GameObject temp;

    public int points = 0;
    [SerializeField] public Text score;
    // Start is called before the first frame update
    void Start()
    {
        bad1.GetComponent<GameObject>();
        bad2.GetComponent<GameObject>();
        score.text = "" + points + "";

    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                BoxCollider bc = hit.collider as BoxCollider;
                if (bc != null)
                {
                    //if(gameObject == bad1 || gameObject== bad2)
                    //{

                    Debug.Log(bc.gameObject);

                    if(bc.gameObject.name == "BadyGuy 2(Clone)" || bc.gameObject.name == "BadyGuy 1(Clone)")
                    {
                        //Debug.Log("Two");
                        //temp = bc.gameObject;
                        //temp.damaging();
                        //bad2.damaging();
                        //bad2.GetComponent<Enemy>().damaging();
                        //bc.gameObject.GetComponent<GameObject>().damaging();
                        //bad2.damaging();
                        hit.collider.gameObject.SendMessage("damaging");
                    //}
                    //gameObject.damaging();
                    //Destroy(bc.gameObject);
                        points += 10;
                        //score.text = "" + points + "";
                    } else if (bc.gameObject.name == "Defense")
                    {
                        if(points >= 50)
                        {

                            bc.gameObject.SetActive(false);
                            points -= 50;
                        }

                    }
                   // score.text = "" + points + "";

                }
            }
        }
        score.text = "" + points + "";
    }
}
