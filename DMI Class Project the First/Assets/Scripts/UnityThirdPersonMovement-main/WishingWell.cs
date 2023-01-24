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
    public Material[] skyboxen;
    public float transitionSpeed = 0.001f;
    public int currentSkyboxIndex = 0;

    // Start is called before the first frame update
    private void Start()
    {
        RenderSettings.skybox = skyboxen[currentSkyboxIndex];
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
            if (whichWish == 3)
            {
                SkyBoxChange();
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
        currentSkyboxIndex = Random.Range(0, skyboxen.Length);
        StartCoroutine(TransitionToSkybox(skyboxen[currentSkyboxIndex]));
    }

    private IEnumerator TransitionToSkybox(Material newSkybox)
    {
        float transition = 0.0f;
        Material previousSkybox = RenderSettings.skybox;
        while (transition < 1.0f)
        {
            transition += Time.deltaTime * transitionSpeed;
            RenderSettings.skybox.Lerp(previousSkybox, newSkybox, transition);
            yield return null;
        }
    }
}