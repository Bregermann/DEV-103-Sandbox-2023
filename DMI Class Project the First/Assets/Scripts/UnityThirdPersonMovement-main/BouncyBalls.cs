using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyBalls : MonoBehaviour
{
    private Rigidbody bouncyRB;
    public float throwForce;
    public AudioSource audioSource;
    public AudioClip[] audios;

    // Start is called before the first frame update
    private void Start()
    {
        bouncyRB = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        ThrowRock();
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void ThrowRock()
    {
        bouncyRB.AddForce(transform.up * throwForce, ForceMode.Impulse);
        audioSource.clip = audios[Random.Range(0, audios.Length)];
        audioSource.Play();
    }
}