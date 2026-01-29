using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public void Resett()
    {
        //account1_username
        // account1_parentname


        PlayerPrefs.SetString("account1_username", "");
        PlayerPrefs.SetString("account1_parentname", "");

        PlayerPrefs.SetString("account2_username", "");
        PlayerPrefs.SetString("account2_parentname", "");


        PlayerPrefs.SetString("account3_username", "");
        PlayerPrefs.SetString("account3_parentname", "");

        PlayerPrefs.SetString("account4_username", "");
        PlayerPrefs.SetString("account4_parentname", "");


    }
}
