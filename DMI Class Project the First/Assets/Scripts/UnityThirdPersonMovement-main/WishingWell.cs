using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WishingWell : MonoBehaviour
{
    public int whichWish;
    public int totalWishes;
    public Transform[] spawns;
    public GameObject coin;

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
        if (other.tag == "Coin")
        {
            whichWish = Random.Range(0, totalWishes);
            if (totalWishes == 0)
            {
                RainCoins();
            }
        }
    }

    private void RainCoins()
    {
        for (int i = 0; i < spawns.Length; i++)
        {
            Instantiate(coin, spawns[i].position, spawns[i].rotation);
        }
    }

    private void RainRocks()
    {
    }

    private void SkyBoxChange()
    {
    }
}