using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CtrlMenu : MonoBehaviour
{
    public GameObject basket;
    public GameObject panelMenu;
    public GameObject panelAbout;
    // Use this for initialization
    void Start () {
        basket.SetActive(true);
        panelMenu.SetActive(true);
        panelAbout.SetActive(false);
    }
	
    public void startGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void home()
    {
        basket.SetActive(true);
        panelMenu.SetActive(true);
        panelAbout.SetActive(false);
    }

    public void about()
    {
        basket.SetActive(false);
        panelMenu.SetActive(false);
        panelAbout.SetActive(true);
    }

    public void email()
    {
        Application.OpenURL("mailto:carlos.2380@hotmail.com?subject=BasketVersusAR&body=");
    }

    public void github()
    {
        Application.OpenURL("https://github.com/carlos2380/BasketVersusAR");
    }

    public void linkedin()
    {
        Application.OpenURL("https://www.linkedin.com/in/carlos2380/");
    }

}
