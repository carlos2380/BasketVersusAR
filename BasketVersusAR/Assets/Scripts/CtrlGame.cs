using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CtrlGame : MonoBehaviour {

    public enum GameState
    {
        SelectPlayer,
        Playing
    };

    public GameObject panelSelect;
    public GameObject panelGame;
    public GameObject tarjetTacks;
    [HideInInspector]
    public GameState gameState;
    private GameObject ball;


    // Use this for initialization
    void Start ()
    {
        gameState = GameState.SelectPlayer;
        panelSelect.SetActive(true);
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
    }
}
