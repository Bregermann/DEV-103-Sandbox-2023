using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinThrow : MonoBehaviour
{
    private Rigidbody coinRB;
    public float throwForce;
    public AudioSource audioSource;
    public AudioClip[] audios;

    // Start is called before the first frame update
    private void Start()
    {
        coinRB = GetComponent<Rigidbody>();
        ThrowCoin();
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void ThrowCoin()
    {
        coinRB.AddForce(transform.forward * throwForce, ForceMode.Impulse);
        audioSource.clip = audios[Random.Range(0, audios.Length)];
        audioSource.Play();
    }
}