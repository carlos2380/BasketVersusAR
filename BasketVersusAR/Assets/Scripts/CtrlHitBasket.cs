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
    private Text scoreText;
    private int scoreToWin;
    private CtrlGame ctrlGame;

    private void Start()
    {
        overTriggerBasket = overTriggerGameObj.GetComponent<TriggerBasket>();
        belowTriggerBasket = belowTriggerGameObj.GetComponent<TriggerBasket>();
        if (tag == "Player1")
        {
            scoreText = GameObject.FindGameObjectWithTag("ScorePlayer1").GetComponent<Text>();
        }
        else 
        {
            scoreText = GameObject.FindGameObjectWithTag("ScorePlayer2").GetComponent<Text>();
        }
        ctrlGame = GameObject.FindGameObjectWithTag("CtrlGame").GetComponent<CtrlGame>();
    }

    public void triggerChanged()
    {
        if (overTriggerActive == true && belowTriggerActive == false)
        {
            if (belowTriggerBasket.triggerActive == true)
            {
                ++score;
                scoreText.text = score.ToString();
                if (ctrlGame.scoreToWin == score)
                {
                    string playerNum = tag == "Player1" ? "1" : "2";
                    ctrlGame.endGame(playerNum);
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
