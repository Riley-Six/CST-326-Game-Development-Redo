﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] private Text leftTextScore;
    [SerializeField] private Text rightTextScore;

    [SerializeField] private Goal leftGoal;
    [SerializeField] private Goal rightGoal;

    [SerializeField] private GameManager gameManager;


    private int leftScore = 0;

    private int rightScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        RefreshScore();
    }

    private void RefreshScore()
    {
        //some function to update the Text string
        leftTextScore.text = "" + leftScore + "";
        rightTextScore.text = "" + rightScore + "";
        leftTextScore.fontSize = 1 + leftScore/4 ;
        rightTextScore.fontSize = 1 + rightScore/4 ;


    }
    public void AddScore(Goal scoringSide)
    {
        if (scoringSide == leftGoal)
        {
            rightScore += 1;
        }

        else
        {
            leftScore += 1;
        }
        RefreshScore();
    }
}
