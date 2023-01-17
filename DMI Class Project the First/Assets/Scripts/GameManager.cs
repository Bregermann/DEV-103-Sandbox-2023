using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int playerHP;
    public TMP_Text hpText;

    // Start is called before the first frame update
    private void Start()
    {
        hpText.SetText(playerHP.ToString());
    }

    // Update is called once per frame
    private void Update()
    {
    }
}