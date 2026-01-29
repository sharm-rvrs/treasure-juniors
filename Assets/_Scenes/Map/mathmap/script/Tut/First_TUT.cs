using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First_TUT : MonoBehaviour
{
    int User_ID;
    int b;

    [SerializeField] private GameObject Tutorial_panel;
    void Start()
    {
        User_ID = PlayerPrefs.GetInt("account_is");
        string a = User_ID + "_Tut";

        b = PlayerPrefs.GetInt(a);

        if (b == 1)
        {
            Tutorial_panel.SetActive(false);
        }
    }

    public void tut_set()
    {
        User_ID = PlayerPrefs.GetInt("account_is");
        string a = User_ID + "_Tut";

        PlayerPrefs.SetInt(a, 1);
    }
}



   
