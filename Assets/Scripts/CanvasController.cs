using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public Canvas mainCanvas;
    public Canvas playCanvas;
    public Canvas optionsCanvas;
    public Canvas creditsCanvas;
    public GameObject buttons;

    public void Start()
    {
        onClickReturn();
    }

    public void onClickPlay()
    {
        buttons.SetActive(false);
        playCanvas.gameObject.SetActive(true);
    }

    public void onClickOptions()
    {
        buttons.SetActive(false);
        optionsCanvas.gameObject.SetActive(true);
    }

    public void onClickCredits()
    {
        buttons.SetActive(false);
        creditsCanvas.gameObject.SetActive(true);
    }

    public void onClickReturn()
    {
        mainCanvas.gameObject.SetActive(true);
        buttons.SetActive(true);
        playCanvas.gameObject.SetActive(false);
        optionsCanvas.gameObject.SetActive(false);
        creditsCanvas.gameObject.SetActive(false);
    }

    public void exitApp()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
