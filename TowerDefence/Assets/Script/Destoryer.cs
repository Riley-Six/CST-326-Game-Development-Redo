using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destoryer : MonoBehaviour
{

    public GameObject bad1;

    public GameObject bad2;

    public int points = 0;
    [SerializeField] public Text score;
    // Start is called before the first frame update
    void Start()
    {
        bad1.GetComponent<GameObject>();
        bad2.GetComponent<GameObject>();

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
                    Destroy(bc.gameObject);
                    points += 10;
                    score.text = "" + points + "";
                }
            }
        }
    }
}
