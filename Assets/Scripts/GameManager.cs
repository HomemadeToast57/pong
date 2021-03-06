using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1Paddle;
    public GameObject player1Goal;

    [Header("Player 2")]
    public GameObject player2Paddle;
    public GameObject player2Goal;

    [Header("Score UI")]
    public GameObject player1Text;
    public GameObject player2Text;

    private int player1Score;
    private int player2Score;

    public void player1Scored()
    {
        player1Score++;
        player1Text.GetComponent<TextMeshProUGUI>().text = player1Score.ToString();
        ResetPosition();
    }

    public void player2Scored()
    {
        player2Score++;
        player2Text.GetComponent<TextMeshProUGUI>().text = player2Score.ToString();
        ResetPosition();
    }

    public void ResetPosition()
    {
        ball.GetComponent<BallMovement>().Reset();
        player1Paddle.GetComponent<PlayerMovement>().Reset();
        player2Paddle.GetComponent<PlayerMovement>().Reset();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player1Score == 7 || player2Score == 7 || Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
