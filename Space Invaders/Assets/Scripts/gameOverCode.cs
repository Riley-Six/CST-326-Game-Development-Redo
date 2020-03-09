using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOverCode : MonoBehaviour
{
    private float start = 0.0f;
    private float end = 5.0f;

    void Update()
    {
        start += Time.deltaTime;

        if (start >= end)
        {
            SceneManager.LoadScene(0);
        }

    }
}
