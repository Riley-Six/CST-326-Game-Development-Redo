using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlock : MonoBehaviour
{


    public GameObject Block;

    // Start is called before the first frame update
    void Start()
    {
        Block.GetComponent<GameObject>();
    }

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
    }

    

}
