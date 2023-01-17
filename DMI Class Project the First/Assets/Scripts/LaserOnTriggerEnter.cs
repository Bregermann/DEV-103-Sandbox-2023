using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserOnTriggerEnter : MonoBehaviour
{
    public GameObject laserEyeRight;
    public GameObject laserEyeLeft;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            laserEyeLeft.SetActive(true);
            laserEyeRight.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            laserEyeLeft.SetActive(false);
            laserEyeRight.SetActive(false);
        }
    }
}