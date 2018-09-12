using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CtrlHitBasket : MonoBehaviour
{
    public GameObject overTriggerGameObj;
    public GameObject belowTriggerGameObj;
    private TriggerBasket overTriggerBasket;
    private TriggerBasket belowTriggerBasket;
    private bool overTriggerActive = false;
    private bool belowTriggerActive = false;
    private int score = 0;
    private int scoreToWin;
    private CtrlGame ctrlGame;
    private GamePanel gamePanel;
    private GamePanel.Player playerEnum;
    private void Start()
    {
        overTriggerBasket = overTriggerGameObj.GetComponent<TriggerBasket>();
        belowTriggerBasket = belowTriggerGameObj.GetComponent<TriggerBasket>();
        ctrlGame = GameObject.FindGameObjectWithTag("CtrlGame").GetComponent<CtrlGame>();
        gamePanel = GameObject.FindGameObjectWithTag("CtrlUI").GetComponent<GamePanel>();
        playerEnum = tag == "Player1" ? GamePanel.Player.Player1 : GamePanel.Player.Player2;
    }

    private void Update()
    {
        //DEBUG
        if (Input.GetKeyDown(KeyCode.A) && tag == "Player1")
        {
            ++score;
            gamePanel.setScore(playerEnum, score.ToString());
            if (ctrlGame.scoreToWin == score)
            {
               
                ctrlGame.endGame(tag);
            }
        }
        if (Input.GetKeyDown(KeyCode.S) && tag == "Player2")
        {
            ++score;
            gamePanel.setScore(playerEnum, score.ToString());
            if (ctrlGame.scoreToWin == score)
            {
                
                ctrlGame.endGame(tag);
            }
        }
    }

    public void triggerChanged()
    {
        if (overTriggerActive == true && belowTriggerActive == false)
        {
            if (belowTriggerBasket.triggerActive == true)
            {
                ++score;
                gamePanel.setScore(playerEnum, score.ToString());
                if (ctrlGame.scoreToWin == score)
                {
                    ctrlGame.endGame(tag);
                }
            }
        }
        overTriggerActive = overTriggerBasket.triggerActive;
        belowTriggerActive = belowTriggerBasket.triggerActive;
    }
    
    
    public void restartTriggers()
    {
        overTriggerActive = false;
        belowTriggerActive = false;
    }
    
}
