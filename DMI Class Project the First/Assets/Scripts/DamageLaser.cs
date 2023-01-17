using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageLaser : MonoBehaviour
{
    public GameManager gm;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            gm.playerHP--;
            gm.hpText.SetText(gm.playerHP.ToString());
        }
    }
}