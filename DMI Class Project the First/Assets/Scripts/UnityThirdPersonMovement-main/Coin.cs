using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int x;
    public int y;
    public int z;
    public Collectible c;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(x, y, z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Collect();
        }
    }

    private void Collect()
    {
        c.coin++;
        c.throwText.text = "Coins: " + c.coin;
        c.collectSource.clip = c.coinClip[Random.Range(0, c.coinClip.Length)];
        c.collectSource.Play();
        Destroy(this.gameObject);
    }
}