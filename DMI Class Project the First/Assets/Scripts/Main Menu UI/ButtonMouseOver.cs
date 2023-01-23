using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class ButtonMouseOver : MonoBehaviour, IPointerEnterHandler
{
    public MainMenuManager mmm;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (mmm.buttonCounter == 11)
        {
            mmm.NewGameButton();
        }
    }
}