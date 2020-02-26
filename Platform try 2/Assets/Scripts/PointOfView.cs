using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointOfView : MonoBehaviour
{
    public Vector3 offset;
    private GameObject player;

    void Start()
    {
    }

    void LateUpdate()
    {
        if (player == null)
        {
            player = GameObject.Find("Ethan");
        }
        else
        {
            transform.position = player.transform.position + offset;
        }
    }
}
