using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{   
    public Ball ball;

    private int playerScore;
    public Paddle playerPaddle;

    private int computerScore;
    public Paddle computerPaddle;

    public Text playerScoreText;
    public Text computerScoreText;

    public void NewGame()
    {
        SetPlayerScore(0);
        SetComputerScore(0);
        StartRound();
    }

    public void StartRound()
    {
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
        ball.ResetPosition();
        ball.AddStartingForce();
    }

    public void PlayerScores()
    {
        SetPlayerScore(playerScore + 1);

        StartRound();
    }
    public void ComputerScores()
    {
        SetComputerScore(computerScore + 1);

        StartRound();
    }

    private void SetPlayerScore(int score)
    {
        playerScore = score;
        playerScoreText.text = score.ToString();
    }

    private void SetComputerScore(int score)
    {
        computerScore = score;
        computerScoreText.text = score.ToString();
    }

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            NewGame();
        }    
    }
}
