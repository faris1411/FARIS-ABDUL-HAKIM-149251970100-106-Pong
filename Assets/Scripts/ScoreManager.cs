using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public BallController ball;

    // Score for players
    public int rightScore;
    public int leftScore;

    // Max score
    public int maxScore;

    // Adding score
    public void AddRightScore(int increment)
    {
        rightScore+=increment;
        ball.ResetBall();
        if(rightScore>=maxScore)
        {
            GameOver();
        }
    }
    public void AddLeftScore(int increment)
    {
        leftScore += increment;
        ball.ResetBall();
        if (leftScore >= maxScore)
        {
            GameOver();
        }
    }

    // End game
    public void GameOver()
    {
        SceneManager.LoadScene("Main Menu");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
