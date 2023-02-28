using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public static WaveManager instance;

    public float amplitude = 1f;
    public float length = 2f;
    public float speed = 1f;
    public float offset = 0f;

    public float amplitudeRandomTimer;
    public float a;
    public float r;
    public float currentTime;
    public float timeLimit = 5;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Debug.Log("Oh dear, this will be destroyed as this already exists there");
            Destroy(this);
        }
    }

    private void Update()
    {
        amplitudeRandomTimer -= Time.deltaTime;
        if (amplitudeRandomTimer <= 0)
        {
            a = amplitude;
            r = Random.Range(0.1f, 1);
            currentTime = 0;
            amplitudeRandomTimer = 5;
        }
        currentTime += Time.deltaTime;
        amplitude = Mathf.Lerp(a, r, currentTime / timeLimit);
        offset += Time.deltaTime * speed;
    }

    public float GetWaveHeight(float _x)
    {
        return amplitude * Mathf.Sin(_x / length + offset);
    }
}