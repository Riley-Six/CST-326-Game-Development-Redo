using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using TMPro;

public class TimeCount : MonoBehaviour
{
    public float timeleft;
    public TextMeshProUGUI text;



    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }
    // Update is called once per frame
    void Update()
    {
        timeleft -= Time.deltaTime;
        text.SetText(Mathf.Round(timeleft) + "");
        

        if (timeleft < 0)
        {
            text.SetText("!!!YOU LOST!!!");
            text.color = Color.red;
        }
    }

    public void ResetTimer()
    {
        timeleft = 375.0f;
    }
}
