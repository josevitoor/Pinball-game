using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    private int balls = 3;
    public Text ballsText;
    public int score = 0;
    public Text scoreText;

    void Start()
    {
        ballsText.text = "BALLS: " + balls;
        scoreText.text = "SCORE: " + score;
    }

    void Update()
    {

    }

    public void setBalls()
    {
        if(balls>0)
        {
            balls--;
            ballsText.text = "BALLS: " + balls;
        }
        else
        {
            ballsText.text = "GAME OVER";
        }
    }

    public void setScore(int points)
    {
        score += points;
        scoreText.text = "SCORE: " + score;
    }
}
