using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public Text player1Score;
    public Text player2Score;
    private int player1Points =0;
    private int player2Points =0;
    int addScore1 = 0;
    int addScore2 = 0;

    void Start()
    {
        Debug.Log("Score Added");
        player1Score.text = "Player 1 :" + 0;
        player2Score.text = "Player 2 :" + 0;
    }

    public void updateScore1(int playerScore1)
    {
        player1Score.text = "Player 1 : " + playerScore1.ToString();
    }

    public void updateScore2(int playerScore2)
    {
        player2Score.text = "Player 2: " + playerScore2.ToString();
    }

    public void AddScore1(int points)
    {
        addScore1 += points;
        updateScore1(addScore1);
        ResetPosition();
    }

    public void AddScore2(int points)
    {
        addScore2 += points;
        updateScore2(addScore2);
        ResetPosition();
    }

    private void ResetPosition()
    {
        GameObject.Find("Ball").GetComponent<ball>().Reset();
        GameObject.Find("left_paddle").GetComponent<Player>().Reset();
        GameObject.Find("right_paddle").GetComponent<Player>().Reset();
    }
}
