using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonAudioController : MonoBehaviour, IPointerEnterHandler
{
    public Button btn;
    public AudioSource SFXMove;

    public void OnPointerEnter(PointerEventData eventData)
    {
        SFXMove.Play();
    }
}
