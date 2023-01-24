using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    private Rigidbody rockRB;
    public float throwForce;
    public AudioSource audioSource;
    public AudioClip[] audios;

    // Start is called before the first frame update
    private void Start()
    {
        rockRB = GetComponent<Rigidbody>();
        ThrowRock();
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void ThrowRock()
    {
        rockRB.AddForce(transform.forward * throwForce, ForceMode.Impulse);
        audioSource.clip = audios[Random.Range(0, audios.Length)];
        audioSource.Play();
    }
}