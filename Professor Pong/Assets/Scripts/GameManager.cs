using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Ball ball;

    [SerializeField] private ScoreKeeper scoreKeeper;
    // Start is called before the first frame update
    void Start()
    {
        ball.Start();
    }

    public void Score(Goal goal)
    {
        Debug.Log("game manager touched");
        scoreKeeper.AddScore(goal);
        ball.Restart(goal);
    }


}
