﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CtrlGame : MonoBehaviour {

    public enum GameState
    {
        SelectPlayer,
        Playing,
        End
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

    // Use this for initialization
    void Start ()
    {
        gameState = GameState.SelectPlayer;
        panelSelect.SetActive(true);
        panelGame.SetActive(false);
        panelWin.SetActive(false);
        ball = GameObject.FindGameObjectWithTag("Ball");
        ball.SetActive(false);
    }

    public void endSelection()
    {
        panelSelect.SetActive(false);
        panelGame.SetActive(true);
        ball.SetActive(true);
        gameState = GameState.Playing;
        tarjetTacks.SetActive(false);
        GetComponent<SelectPlayers>().enabled = false;
        ball.GetComponent<CtrlBall>().respown();
    }

    public void endGame(String playerNum)
    {
        gameState = GameState.End;
        panelGame.SetActive(false);
        panelWin.SetActive(true);
        namePlayerWin.text = playerNum;
        ball.SetActive(false);
    }
}
