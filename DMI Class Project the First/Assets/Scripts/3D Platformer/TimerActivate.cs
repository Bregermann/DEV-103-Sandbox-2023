using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerActivate : MonoBehaviour
{
    public PlatformerManager pm;

    // Start is called before the first frame update
    private void Start()
    {
        pm.timerOn = false;
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            TimerOn();
        }
    }

    private void TimerOn()
    {
        pm.timerOn = true;
        gameObject.SetActive(false);
    }
}