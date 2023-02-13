using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerEnd : MonoBehaviour
{
    public PlatformerManager pm;
    public float bronzeTime;
    public float silverTime;
    public float goldTime;

    public Sprite bronzeSprite;
    public Sprite silverSprite;
    public Sprite goldSprite;
    public Sprite failSprite;
    public Image medalImage;

    public AudioSource timeTrialAudio;
    public AudioClip bronzeClip;
    public AudioClip silverClip;
    public AudioClip goldClip;
    public AudioClip failClip;

    public GameObject bronzeParticles;
    public GameObject silverParticles;
    public GameObject goldParticles;
    public GameObject failParticles;

    public TMP_Text timeTrialEndText;
    public string goldString;
    public string silverString;
    public string bronzeString;
    public string failString;

    public GameObject gameResetPanel;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        pm.timerOn = false;
        if (pm.timer < goldTime)
        {
            GoldTime();
        }
        else if (pm.timer < silverTime && pm.timer > goldTime)
        {
            SilverTime();
        }
        else if (pm.timer < bronzeTime && pm.timer > silverTime)
        {
            BronzeTime();
        }
        else
        {
            FailTime();
        }
    }

    private void GoldTime()
    {
        medalImage.sprite = goldSprite;
        timeTrialAudio.clip = goldClip;
        timeTrialAudio.Play();
        goldParticles.SetActive(true);
        timeTrialEndText.text = goldString;
        gameResetPanel.SetActive(true);
    }

    private void SilverTime()
    {
        medalImage.sprite = silverSprite;
        timeTrialAudio.clip = silverClip;
        timeTrialAudio.Play();
        silverParticles.SetActive(true);
        timeTrialEndText.text = silverString;
        gameResetPanel.SetActive(true);
    }

    private void BronzeTime()
    {
        medalImage.sprite = bronzeSprite;
        timeTrialAudio.clip = bronzeClip;
        timeTrialAudio.Play();
        bronzeParticles.SetActive(true);
        timeTrialEndText.text = bronzeString;
        gameResetPanel.SetActive(true);
    }

    private void FailTime()
    {
        medalImage.sprite = failSprite;
        timeTrialAudio.clip = failClip;
        timeTrialAudio.Play();
        failParticles.SetActive(true);
        timeTrialEndText.text = failString;
        gameResetPanel.SetActive(true);
    }
}