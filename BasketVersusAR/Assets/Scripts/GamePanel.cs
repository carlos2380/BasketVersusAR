using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class GamePanel : MonoBehaviour
{
    public Text scorePlayer1;
    public Text scorePlayer2;

    public enum Player
    {
        Player1,
        Player2
    };


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    
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
}
