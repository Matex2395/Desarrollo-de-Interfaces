using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    public Canvas mainCanvas;
    public Canvas playCanvas;
    public Canvas optionsCanvas;
    public Canvas creditsCanvas;
    public GameObject buttons;
    public AudioSource confirmSFX;
    public AudioSource cancelSFX;
    public GameObject logo;

    public void onClickPlay()
    {
        //Time.timeScale = 0; // Tiene problemas con las animaciones de los botones
        buttons.SetActive(false);
        logo.SetActive(false);
        confirmSFX.Play();
        playCanvas.gameObject.SetActive(true);
    }

    public void onClickOptions()
    {
        //Time.timeScale = 0;
        buttons.SetActive(false);
        logo.SetActive(false);
        confirmSFX.Play();
        optionsCanvas.gameObject.SetActive(true);
    }

    public void onClickCredits()
    {
        //Time.timeScale = 0;
        buttons.SetActive(false);
        confirmSFX.Play();
        creditsCanvas.gameObject.SetActive(true);
    }

    public void onClickReturn()
    {
        mainCanvas.gameObject.SetActive(true);
        //Time.timeScale = 1;
        buttons.SetActive(true);
        logo.SetActive(true);
        cancelSFX.Play();
        playCanvas.gameObject.SetActive(false);
        optionsCanvas.gameObject.SetActive(false);
        creditsCanvas.gameObject.SetActive(false);
    }

    public void exitApp()
    {
        cancelSFX.Play();
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
