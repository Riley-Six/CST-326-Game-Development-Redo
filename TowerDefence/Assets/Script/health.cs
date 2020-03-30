using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    // Start is called before the first frame update

    public float hp = 0.2f;
    // Update is called once per frame
    void Update()
    {
    }

    public void hurt()
    {
        transform.localScale = new Vector3(transform.localScale.x - hp, transform.localScale.y, transform.localScale.z);
    }
}
