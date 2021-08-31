using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    int leftScore = 0;
    int rightScore = 0;
    public Text leftScoreText;
    public Text rightScoreText;
    public PlayerMovement leftPlayer;
    public PlayerMovement rightPlayer;

    public BallMovement ball;

    void Start()
    {
        ResetGame();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetGame();
        }
    }
    void ResetGame()
    {
        SetLeftScore(0);
        SetRightScore(0);
        startRound();
    }

    void startRound()
    {
        leftPlayer.ResetPlayer();
        rightPlayer.ResetPlayer();
        ball.resetPosition();

    }
    public void leftScores()
    {
        SetLeftScore(leftScore + 1);
        startRound();
        Debug.Log("Right Scores");
    }
    public void rightScores()
    {
        SetRightScore(rightScore + 1);
        startRound();
        Debug.Log("Left Scores");
    }
    void SetLeftScore(int score)
    {
        leftScore = score;
        leftScoreText.text = leftScore.ToString();
    }
    void SetRightScore(int score)
    {
        rightScore = score;
        rightScoreText.text = rightScore.ToString();
    }
}
