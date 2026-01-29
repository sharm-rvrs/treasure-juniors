using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBox : MonoBehaviour
{

    int User_ID;
    [SerializeField] private string Achievement_Key_Name1;
    [SerializeField] private string Achievement_Key_Name2;
    [SerializeField] private string Achievement_Key_Name3;


    [SerializeField] private GameObject key1;
    [SerializeField] private GameObject key2;
    [SerializeField] private GameObject key3;
    [SerializeField] private GameObject key4;
    [SerializeField] private GameObject key5;

    [SerializeField] private GameObject closeBTN_KeyBox;

    [SerializeField] private GameObject shing;

    private void Update()
    {
        User_ID = PlayerPrefs.GetInt("account_is");
    }
    public void open()
    {
        string b1 = User_ID + "_" + Achievement_Key_Name1;
        int a1 = PlayerPrefs.GetInt(b1);
        if (a1 == 1)
        {
            key1.SetActive(true);
        }

        string b2 = User_ID + "_" + Achievement_Key_Name2;
        int a2 = PlayerPrefs.GetInt(b2);
        if (a2 == 1)
        {
            key2.SetActive(true);
            key3.SetActive(true);
        }

        string b3 = User_ID + "_" + Achievement_Key_Name3;
        int a3 = PlayerPrefs.GetInt(b3);
        if (a3 == 1)
        {
            key4.SetActive(true);
            key5.SetActive(true);
        }

        shing.SetActive(true);
        closeBTN_KeyBox.SetActive(true);
    }

    public void close()
    {
        key1.SetActive(false);
        key2.SetActive(false);
        key3.SetActive(false);
        key4.SetActive(false);
        key5.SetActive(false);

        closeBTN_KeyBox.SetActive(false);

        shing.SetActive(false);

    }
}
