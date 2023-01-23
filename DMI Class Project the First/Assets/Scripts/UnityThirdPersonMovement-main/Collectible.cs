using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Collectible : MonoBehaviour
{
    public int collectTotal;
    public int collectCurrent;
    public TMP_Text collectText;
    public AudioSource collectSource;
    public AudioClip collectClip;
    public GameObject gotThemAll;
    public float removeGraphicTimer;

    // Start is called before the first frame update
    private void Start()
    {
        collectText.text = "Things: " + collectCurrent.ToString() + " / " + collectTotal.ToString();
    }

    // Update is called once per frame
    private void Update()
    {
        if (removeGraphicTimer > -0.01f)
        {
            removeGraphicTimer -= Time.deltaTime;
        }
    }
}