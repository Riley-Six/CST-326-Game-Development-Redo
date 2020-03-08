using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Lives : MonoBehaviour
{

    [SerializeField] public Text score;
    [SerializeField] public Text highScore;
    [SerializeField] public Text lives;
    [SerializeField] public Enemy top;
    [SerializeField] public Enemy mid;
    [SerializeField] public Enemy bottom;
    [SerializeField] public Enemy forth; 
    private static int highScoreInt;
    private static int playScoreInt;
    [SerializeField] public int livesLeft = 3;
    // Start is called before the first frame update
    void Start()
    {
        playScoreInt = 0;
        highScoreInt = 0;
        livesLeft = 3;
        RefreshScore();

        //score = GameObject.Find("Score Number").GetComponent<Text>();

    }

    void reStart()
    {
        playScoreInt = 0;
        lives.text = "" + livesLeft +"";
        RefreshScore();
    }

    private void RefreshScore()
    {
        //score.text = /*playScoreInt.ToString("")*/ + playScoreInt;
        //highScore.text = "" + highScoreInt.ToString() + "";
        score.text = "" + playScoreInt + "";
        highScore.text = "" + highScoreInt + "";
        Debug.Log("refresh score");
    }

    // Update is called once per frame
    public void AddScore(int killed)
    {
        playScoreInt += killed;
        if(playScoreInt > highScoreInt)
        {
            highScoreInt = playScoreInt;
        }
        //Bullet.yo
        //if (killed == "Enemytype1")
        //{
        //    playScoreInt += 5;
        //} else if (killed == "Enemytype2")
        //{
        //    playScoreInt += 10;
        //} else if (killed == "Enemytype3")
        //{
        //    playScoreInt += 15;
        //} else if (killed == "Player3")
        //{
        //    playScoreInt += 20;
        //}
        Debug.Log("add score");
        RefreshScore();

    }
}
