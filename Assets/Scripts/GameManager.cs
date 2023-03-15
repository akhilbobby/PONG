using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour {

    [SerializeField] private Ball ball;

    public static GameManager instance; 

    private int playerScore;
    private int computerScore;

    [SerializeField] private TextMeshProUGUI playerScoreText;
    [SerializeField] private TextMeshProUGUI computerScoreText;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        //if(instance != null)
        //WallCollide.OnWallCollide += playerScore;
        playerScoreText.text = "0";
        computerScoreText.text = "0";
    }

    public void PlayerWall()
    {
        computerScore++;
        computerScoreText.text = computerScore.ToString();
        ball.ResetBall();
    }

    public void ComputerWall()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();
        ball.ResetBall();
    }
}
