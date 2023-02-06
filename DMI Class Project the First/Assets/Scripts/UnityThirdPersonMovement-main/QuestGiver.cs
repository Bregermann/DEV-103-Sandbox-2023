using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGiver : MonoBehaviour
{
    public GameObject exclamation;
    public Light questGiverLight;
    public GameObject pressToTalk;
    public QuestManager QM;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                QM.Q1WelcomeToHell(); //this will need to be refactored to be flexible to be able to grab the correct quest in the future
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PressToTalk();
        }
    }

    private void PressToTalk()
    {
        questGiverLight.enabled = true;
        pressToTalk.SetActive(true);
    }

    private void Quest()
    {
    }
}