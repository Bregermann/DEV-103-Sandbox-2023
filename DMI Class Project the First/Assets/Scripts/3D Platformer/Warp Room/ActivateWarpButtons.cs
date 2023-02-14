using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateWarpButtons : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public Animation buttonAnimation;
    public Animator button1Animator;
    public Animator button2Animator;
    public Animator button3Animator;
    public Animator button4Animator;
    public Animator button5Animator;
    public string triggerName = "playAnimation";

    public AudioSource triggerSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            button1.SetActive(true);
            button2.SetActive(true);
            button3.SetActive(true);
            button4.SetActive(true);
            button5.SetActive(true);
            buttonAnimation.wrapMode = WrapMode.Once;
            button1Animator.Play(triggerName, 0, 0f);
            button2Animator.Play(triggerName, 0, 0f);
            button3Animator.Play(triggerName, 0, 0f);
            button4Animator.Play(triggerName, 0, 0f);
            button5Animator.Play(triggerName, 0, 0f);
            triggerSound.Play();
        }
    }
}