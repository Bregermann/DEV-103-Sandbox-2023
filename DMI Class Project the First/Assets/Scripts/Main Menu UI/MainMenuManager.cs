using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuManager : MonoBehaviour
{
    public TMP_Text trollText;
    public int buttonCounter;
    public GameObject newGameButton;
    public float timer;
    public Transform[] buttonTransforms;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (timer >= 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= .1f && timer >= .05f)
        {
            newGameButton.SetActive(true);
            SurpriseImBack();
        }
    }

    public void NewGameButton()
    {
        buttonCounter++;
        if (buttonCounter == 1)
        {
            trollText.text = "Are you sure you would like to proceed? Your knees are weak, your palms are sweaty";
        }
        if (buttonCounter == 2)
        {
            trollText.text = "I don't know, seems sus";
        }
        if (buttonCounter == 3)
        {
            newGameButton.SetActive(false);
            timer = 5;
        }
        if (buttonCounter >= 5 && buttonCounter <= 10)
        {
            newGameButton.transform.position = buttonTransforms[Random.Range(0, buttonTransforms.Length)].position;
        }
        if (buttonCounter == 5)
        {
            trollText.text = "ooo too slow";
        }
        if (buttonCounter == 6)
        {
            trollText.text = "almost got it";
        }
        if (buttonCounter == 7)
        {
            trollText.text = "feeling feelings?";
        }
        if (buttonCounter == 8)
        {
            trollText.text = "do you even remember why you are here?";
        }
        if (buttonCounter == 9)
        {
            trollText.text = "Click for mercy";
        }
        if (buttonCounter == 10)
        {
            trollText.text = "kekw";
        }
        if (buttonCounter == 12)
        {
            newGameButton.transform.position = buttonTransforms[Random.Range(0, buttonTransforms.Length)].position;
            trollText.text = "oof";
        }
        if (buttonCounter == 13)
        {
            newGameButton.GetComponent<Image>().color = Color.cyan;
            trollText.text = "okay fine, click it again and perhaps you can begin.";
        }
        if (buttonCounter == 14)
        {
            SceneManager.LoadScene(6);
        }
        //SceneManager.LoadScene(6);
    }

    public void SurpriseImBack()
    {
        trollText.text = "Did you miss me?";
        buttonCounter = 4;
    }

    public void OnMouseOver()
    {
        Debug.Log("over? over! over?");
    }
}