using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class GamePanel : MonoBehaviour
{
    public GameObject scoreLeft;
    public GameObject scoreRight;
    public GameObject counter;
    public GameObject winPlayer1;
    public GameObject winPlayer2;
    public Text scorePlayer1;
    public Text scorePlayer2;
    public Text counterNum;
    private CtrlGame ctrlGame;
    [Header("Sounds")]
    public AudioSource countDown;
    public AudioSource start;

    public enum Player
    {
        Player1,
        Player2
    };


    // Use this for initialization
    void Start ()
    {
        ctrlGame = GameObject.FindGameObjectWithTag("CtrlGame").GetComponent<CtrlGame>();
    }

  
    public void restart()
    {
        scorePlayer1.text = "0";
        scorePlayer2.text = "0";
        counterNum.fontSize = 160;
        winPlayer1.SetActive(false);
        winPlayer2.SetActive(false);
        counter.SetActive(true);
        startCountDown();
    }

    public void setScore(Player playerEnum, string scoreStr)
    {
        switch (playerEnum)
        {
            case Player.Player1:
                scorePlayer1.text = scoreStr;
                break;
            case Player.Player2:
                scorePlayer2.text = scoreStr;
                break;
        }
    }
    public void appearScore()
    {
        scoreLeft.GetComponent<Animator>().Play("Appear");
        scoreRight.GetComponent<Animator>().Play("Appear");
    }

    public void startCountDown()
    {
        counterNum.GetComponent<Animator>().Play("Zoom");
    }

    public void lessCounter()
    {
        switch (counterNum.text)
        {
            case "3":
                counterNum.text = "2";
                countDown.Play();
                counterNum.GetComponent<Animator>().Play("Zoom");
                break;
            case "2":
                counterNum.text = "1";
                countDown.Play();
                counterNum.GetComponent<Animator>().Play("Zoom");
                break;
            case "1":
                counterNum.text = "START";
                countDown.Play();
                counterNum.fontSize = 35;
                counterNum.GetComponent<Animator>().Play("Zoom");
                break;
            case "START":
                counterNum.text = "3";
                start.Play();
                counter.SetActive(false);
                ctrlGame.whenFinishCount();
                break;
        }
    }

    public void player1Win()
    {
        winPlayer1.SetActive(true);
    }
    public void player2Win()
    {
        winPlayer2.SetActive(true);
    }


}
