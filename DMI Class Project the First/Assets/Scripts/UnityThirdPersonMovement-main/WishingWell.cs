using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WishingWell : MonoBehaviour
{
    public int whichWish;
    public int totalWishes;
    public Transform[] spawns;
    public GameObject coin;
    public GameObject[] rock;
    public GameObject[] balls;

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
            if (whichWish == 0)
            {
                RainCoins();
            }
            if (whichWish == 1)
            {
                RainRocks();
            }
            if (whichWish == 2)
            {
                BouncyBalls();
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
        for (int i = 0; i < spawns.Length; i++)
        {
            Instantiate(rock[Random.Range(0, rock.Length)], spawns[i].position, spawns[i].rotation);
        }
    }

    private void BouncyBalls()
    {
        for (int i = 0; i < spawns.Length; i++)
        {
            Instantiate(balls[Random.Range(0, balls.Length)], spawns[i].position, spawns[i].rotation);
        }
    }

    private void SkyBoxChange()
    {
    }
}