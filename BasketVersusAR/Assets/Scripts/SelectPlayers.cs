using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectPlayers : MonoBehaviour
{
    public Text numPlayer;
    private GameObject player1;
    private GameObject player2;
    private CtrlGame ctrlGame;
    private bool player1Selected = false;

    // Use this for initialization
    void Start ()
    {
        ctrlGame = gameObject.GetComponent<CtrlGame>();
        player1 = GameObject.FindGameObjectWithTag("Player1");
	    player2 = GameObject.FindGameObjectWithTag("Player2");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void targetApearForSelect(GameObject trackableObject, bool isUsed)
    {
        if (isUsed == true)
        {
            Debug.Log("trakableUsed");
        }
        else
        {
            trackableObject.GetComponent<DefaultTrackableEventHandler>().isUsed = true;
            if (player1Selected == false)
            {
                generatePlayerWithTrack(0, trackableObject);
                numPlayer.text = "2";
                player1Selected = true;
            }
            else
            {
                generatePlayerWithTrack(1, trackableObject);
                ctrlGame.endSelection();
            }
            
        }
    }

    private void generatePlayerWithTrack(int idPlayer, GameObject trackableObject)
    {
        trackableObject.transform.parent = null;
        trackableObject.transform.GetChild(idPlayer).gameObject.SetActive(true);
    }
}
