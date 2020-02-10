using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameManager gameManager;

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("goal touched");

        gameManager.Score(this);
    }
}
