﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CtrlGame : MonoBehaviour {

    public enum GameState
    {
        SelectPlayer,
        Playing
    };

    public GameObject panelSelect;
    public GameObject panelGame;
    public GameObject tarjetTacks;
    public int scoreToWin;
    [HideInInspector]
    public GameState gameState;
    private GameObject ball;

    [Header("PanelWin")]
    public GameObject panelWin;
    public Text namePlayerWin;
    private GamePanel gamePanel;

    // Use this for initialization
    void Start ()
    {
        gameState = GameState.SelectPlayer;
        panelSelect.SetActive(true);
        panelGame.SetActive(false);
        panelWin.SetActive(false);
        ball = GameObject.FindGameObjectWithTag("Ball");
        ball.SetActive(false);
        gamePanel = GameObject.FindGameObjectWithTag("CtrlUI").GetComponent<GamePanel>();
    }

    public void endSelection()
    {
        panelSelect.SetActive(false);
        panelGame.SetActive(true);
        gameState = GameState.Playing;
        tarjetTacks.SetActive(false);
        gamePanel.appearScore();
        gamePanel.startCountDown();
    }

    public void whenFinishCount()
    {
        ball.SetActive(true);
        ball.GetComponent<CtrlBall>().respown();
    }

    public void endGame(String tag)
    {
        switch (tag)
        {
            case "Player1":
                gamePanel.player1Win();
                break;
            case "Player2":
                gamePanel.player2Win();
                break;
        }
        ball.SetActive(false);
    }
}
