using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LicenseController : MonoBehaviour
{
    public Transform[] spawns;
    public GameObject[] playerVehicle;
    public int licenseInt;
    public MSSceneControllerFree ms;
    public float challengeTimer;
    public bool challengeIsActive;
    public TMP_Text timerText;
    public GameObject endScreen;
    public GameObject gameUI;

    // Start is called before the first frame update
    private void Start()
    {
        playerVehicle[licenseInt].transform.position = spawns[licenseInt].transform.position;
        playerVehicle[licenseInt].transform.rotation = spawns[licenseInt].transform.rotation;
        ms.startingVehicle = licenseInt;
        gameUI.SetActive(true);
        endScreen.SetActive(false);

        challengeIsActive = true; //TODO: make this happen after camera pan in and countdown
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (challengeIsActive == true)
        {
            challengeTimer += Time.deltaTime;
            challengeTimer = Mathf.Round(challengeTimer * 1000f) / 1000f;
            timerText.text = challengeTimer.ToString();
        }
    }

    public void End()
    {
        challengeIsActive = false;
        gameUI.SetActive(false);
        endScreen.SetActive(true);
        Time.timeScale = 0;
        endScreen.SetActive(true);
        playerVehicle[licenseInt].GetComponent<MSVehicleControllerFree>().enabled = false;
    }
}