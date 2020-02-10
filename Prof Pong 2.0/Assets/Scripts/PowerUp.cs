using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    [SerializeField] private Ball ball;


    private void OnTriggerEnter(Collider other)
    {
        ball.PowerUp(this);
    }
}
