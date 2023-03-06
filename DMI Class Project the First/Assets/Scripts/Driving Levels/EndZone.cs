using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndZone : MonoBehaviour
{
    public LicenseController lc;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            lc.End();
        }
    }
}