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
    public Text scorePlayer1;
    public Text scorePlayer2;
    public Text counterNum;
    private CtrlGame ctrlGame;

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

  
    public void restartScore()
    {
        scorePlayer1.text = "0";
        scorePlayer2.text = "0";
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
                counterNum.GetComponent<Animator>().Play("Zoom");
                break;
            case "2":
                counterNum.text = "1";
                counterNum.GetComponent<Animator>().Play("Zoom");
                break;
            case "1":
                counterNum.text = "START";
                counterNum.fontSize = 35;
                counterNum.GetComponent<Animator>().Play("Zoom");
                break;
            case "START":
                counterNum.text = "3";
                counter.SetActive(false);
                ctrlGame.whenFinishCount();
                break;
        }
    }
}
