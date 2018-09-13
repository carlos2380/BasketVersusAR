using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CtrlMenu : MonoBehaviour
{
    public GameObject basket;
    public GameObject panelMenu;
    public GameObject panelAbout;
    
    [Header("Sounds")]
    public AudioSource musicMenu;
    public AudioSource click;


    // Use this for initialization
    void Start () {
        basket.SetActive(true);
        panelMenu.SetActive(true);
        panelAbout.SetActive(false);
    }
	
    public void startGame()
    {
        click.Play();
        SceneManager.LoadScene("Game");
    }

    public void home()
    {
        click.Play();
        basket.SetActive(true);
        panelMenu.SetActive(true);
        panelAbout.SetActive(false);
    }

    public void about()
    {
        click.Play();
        basket.SetActive(false);
        panelMenu.SetActive(false);
        panelAbout.SetActive(true);
    }

    public void email()
    {
        click.Play();
        Application.OpenURL("mailto:carlos.2380@hotmail.com?subject=BasketVersusAR&body=");
    }

    public void github()
    {
        click.Play();
        Application.OpenURL("https://github.com/carlos2380/BasketVersusAR");
    }

    public void linkedin()
    {
        click.Play();
        Application.OpenURL("https://www.linkedin.com/in/carlos2380/");
    }

}
