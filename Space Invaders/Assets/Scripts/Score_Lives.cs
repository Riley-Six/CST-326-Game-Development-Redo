using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Lives : MonoBehaviour
{

    [SerializeField] private Text score;
    [SerializeField] private Text highScore;
    [SerializeField] private Text lives;
    [SerializeField] public Enemy top;
    [SerializeField] public Enemy mid;
    [SerializeField] public Enemy bottom;
    [SerializeField] public Enemy forth; 
    private int highScoreInt;
    private int playScoreInt;
    [SerializeField] public int livesLeft = 3;
    // Start is called before the first frame update
    void Start()
    {
        playScoreInt = 0;
        highScoreInt = 0;
        livesLeft = 3;
        RefreshScore();
    }

    void reStart()
    {
        playScoreInt = 0;
        lives.text = "" + livesLeft +"";
        RefreshScore();
    }

    private void RefreshScore()
    {
        score.text = "" + playScoreInt + "";
        highScore.text = "" + highScoreInt + "";

    }

    // Update is called once per frame
    public void AddScore(Enemy killed)
    {
        if (killed == bottom)
        {
            playScoreInt += 5;
        } else if (killed == mid)
        {
            playScoreInt += 10;
        } else if (killed == top)
        {
            playScoreInt += 15;
        } else if (killed == forth)
        {
            playScoreInt += 20;
        }
        RefreshScore();
    }
}
