using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserOnTriggerEnter : MonoBehaviour
{
    public GameObject laserEyeRight;
    public GameObject laserEyeLeft;
    public AudioSource gorillaSource;
    public AudioClip[] gorillaClip;

    private void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gorillaSource.clip = gorillaClip[Random.Range(0, gorillaClip.Length)];
            gorillaSource.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
        }
    }
}