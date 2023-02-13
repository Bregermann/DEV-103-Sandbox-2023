using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlatformerManager : MonoBehaviour
{
    public float timer;
    public TMP_Text timerText;
    public bool timerOn;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (timerOn == true)
        {
            timer += Time.deltaTime;
            timerText.text = timer.ToString();
        }
    }
}