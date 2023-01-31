using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeController : MonoBehaviour
{
    public AudioMixer mixer;
    public AudioMixer sfx;
    public float masterVolume;
    public float sfxVolume;
    public float soundtrackVolume;
    public float voiceVolume;
    public Slider masterSlider;
    public Slider sfxSlider;
    public Slider soundtrackSlider;
    public Slider voiceSlider;

    // Start is called before the first frame update
    private void Start()
    {
        masterSlider.onValueChanged.AddListener(UpdateMasterVolume);
        sfxSlider.onValueChanged.AddListener(UpdateMasterVolume);
        soundtrackSlider.onValueChanged.AddListener(UpdateMasterVolume);
        voiceSlider.onValueChanged.AddListener(UpdateMasterVolume);
    }

    public void UpdateMasterVolume(float masterVolume)
    {
        mixer.SetFloat("Master", Mathf.Log10(masterVolume) * 20);
    }

    public void UpdateSFXVolume(float sfxVolume)
    {
        sfx.SetFloat("SFX", Mathf.Log10(sfxVolume) * 20);
    }

    public void UpdateSoundtrackVolume(float soundtrackVolume)
    {
        mixer.SetFloat("Soundtrack", Mathf.Log10(soundtrackVolume) * 20);
    }

    public void UpdateVoiceVolume(float voiceVolume)
    {
        mixer.SetFloat("Voice", Mathf.Log10(voiceVolume) * 20);
    }
}