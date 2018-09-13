using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Vuforia;

public class CtrlGame : MonoBehaviour {

    public delegate void RestartEvent();
    public event RestartEvent restart;

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
    private GamePanel gamePanel;

    [Header("Sound")]
    public AudioSource musicGame;
    public AudioSource abmientGame;
    public AudioSource basketPoint;
    public AudioSource finishMatch;
    public AudioSource click;

    // Use this for initialization
    void Start ()
    {
        gameState = GameState.SelectPlayer;
        panelSelect.SetActive(true);
        panelGame.SetActive(false);
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
        abmientGame.Play();
        ball.SetActive(true);
        ball.GetComponent<CtrlBall>().respown();
    }

    public void endGame(String tag)
    {
        finishMatch.Play();
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
        StartCoroutine(restarGame());
    }

    
    protected virtual void throwRestartEvent()
    {
        RestartEvent restertEvent = restart;
        if (restertEvent != null)
        {
            restertEvent();
        }
    }

    public void home()
    {
        click.Play();
        SceneManager.LoadScene("Menu");
    }

    private IEnumerator restarGame()
    {
        abmientGame.Stop();
        throwRestartEvent();
        yield return new WaitForSeconds(5);
        gamePanel.restart();
    }
}
