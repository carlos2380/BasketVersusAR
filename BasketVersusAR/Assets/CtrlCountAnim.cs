using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CtrlCountAnim : MonoBehaviour
{
    private GamePanel gamePanel;

	// Use this for initialization
	void Start ()
	{
	    gamePanel = GameObject.FindGameObjectWithTag("CtrlUI").GetComponent<GamePanel>();

	}

    public void lessCounter()
    {
        gamePanel.lessCounter();
    }
}
