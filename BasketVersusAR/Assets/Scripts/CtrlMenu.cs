using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CtrlMenu : MonoBehaviour
{
    public GameObject basket;
    public GameObject panelMenu;
    public GameObject panelAbout;
    public GameObject panelTutorial;
    public GameObject panelDownload;
    public GameObject panelSelect;
    public GameObject panelEnjoy;
    public GameObject panelLoading;
    public GameObject panelAdvice;

    [Header("Sounds")]
    public AudioSource musicMenu;
    public AudioSource click;


    // Use this for initialization
    void Start () {
        if (Advice.adviceShow == false)
        {
            StartCoroutine(showAdvice());
        }
        else
        {
            setUpStart();
        }
    }

    public void setUpStart()
    {
        basket.SetActive(true);
        panelMenu.SetActive(true);
        panelAdvice.SetActive(false);
        panelAbout.SetActive(false);
        panelTutorial.SetActive(false);
        panelLoading.SetActive(false);
    }
    public void startGame1Player()
    {
        click.Play();
        NumPlayers.numPlayers = 1;
        basket.SetActive(false);
        panelLoading.SetActive(true);
        SceneManager.LoadScene("Game");
    }

    public void startGame2Player()
    {
        click.Play();
        NumPlayers.numPlayers = 2;
        basket.SetActive(false);
        panelLoading.SetActive(true);
        SceneManager.LoadScene("Game");
    }


    public void home()
    {
        click.Play();
        panelTutorial.SetActive(false);
        basket.SetActive(true);
        panelMenu.SetActive(true);
        panelAbout.SetActive(false);
        panelLoading.SetActive(false);
    }

    public void about()
    {
        click.Play();
        basket.SetActive(false);
        panelMenu.SetActive(false);
        panelAbout.SetActive(true);
        panelLoading.SetActive(false);
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

    public void tutorial()
    {
        click.Play();
        basket.SetActive(false);
        panelMenu.SetActive(false);
        panelAbout.SetActive(false);
        panelTutorial.SetActive(true);
        panelDownload.SetActive(true);
        panelSelect.SetActive(false);
        panelEnjoy.SetActive(false);
        panelLoading.SetActive(false);
    }
    
    public void downloadPanel()
    {
        click.Play();
        panelDownload.SetActive(true);
        panelSelect.SetActive(false);
        panelEnjoy.SetActive(false);
        panelLoading.SetActive(false);
    }

    public void downloadImage()
    {
        click.Play();
        Application.OpenURL("https://github.com/carlos2380/BasketVersusAR/blob/master/Targets/Targets.pdf");
    }

    public void selectPanel()
    {
        click.Play();
        panelDownload.SetActive(false);
        panelSelect.SetActive(true);
        panelEnjoy.SetActive(false);
        panelLoading.SetActive(false);
    }

    public void enjoyPanel()
    {
        click.Play();
        panelDownload.SetActive(false);
        panelSelect.SetActive(false);
        panelEnjoy.SetActive(true);
        panelLoading.SetActive(false);
    }

    public void exit()
    {
        click.Play();
        Application.Quit();
    }

    IEnumerator showAdvice()
    {
        Advice.adviceShow = true;
        basket.SetActive(false);
        panelAdvice.SetActive(true);
        panelMenu.SetActive(false);
        panelAbout.SetActive(false);
        panelTutorial.SetActive(true);
        panelLoading.SetActive(false);
        yield return new WaitForSeconds(5);
        setUpStart();
    }
}
