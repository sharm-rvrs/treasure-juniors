using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Start_Update : MonoBehaviour
{
    
    public TMP_Text Account1;
    public TMP_Text Account2;
    public TMP_Text Account3;
    public TMP_Text Account4;

    public GameObject BTN1;
    public GameObject BTN2;
    public GameObject BTN3;
    public GameObject BTN4;

    public GameObject Username_button1;
    public GameObject Username_button2;
    public GameObject Username_button3;
    public GameObject Username_button4;

    public AudioSource BG_sound;

    public Button createaccountBTN;


    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if(Account1.text == "")
        {
            BTN1.SetActive(false);
            Username_button1.SetActive(false);
        }
        else
        {
            BTN1.SetActive(true);
            Username_button1.SetActive(true);
        }

        if (Account2.text == "")
        {
            BTN2.SetActive(false);
            Username_button2.SetActive(false);
        }
        else
        {
            BTN2.SetActive(true);
            Username_button2.SetActive(true);
        }

        if (Account3.text == "")
        {
            BTN3.SetActive(false);
            Username_button3.SetActive(false);
        }
        else
        {
            BTN3.SetActive(true);
            Username_button3.SetActive(true);
        }

        if (Account4.text == "")
        {
            BTN4.SetActive(false);
            Username_button4.SetActive(false);
        }
        else
        {
            BTN4.SetActive(true);
            Username_button4.SetActive(true);
        }

        Account1.text = PlayerPrefs.GetString("account1_username").ToString();
        Account2.text = PlayerPrefs.GetString("account2_username").ToString();
        Account3.text = PlayerPrefs.GetString("account3_username").ToString();
        Account4.text = PlayerPrefs.GetString("account4_username").ToString();

        BG_sound.volume = PlayerPrefs.GetFloat("Global_BG_Volume");
        

        if (BTN1.activeSelf == true && BTN2.activeSelf == true && BTN3.activeSelf == true && BTN4.activeSelf ==true)
        {
            createaccountBTN.interactable=false;
        }
        else
        {
            createaccountBTN.interactable = true;
        }
        

    }
}
