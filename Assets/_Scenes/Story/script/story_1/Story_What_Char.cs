using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story_What_Char : MonoBehaviour
{
    int account;
    int character;


    [SerializeField] private GameObject boy;
    [SerializeField] private GameObject girl;
    void Start()
    {
        account = PlayerPrefs.GetInt("account_is");

        if (account == 1)
        {
            character = PlayerPrefs.GetInt("account1_char");
        }
        if (account == 2)
        {
            character = PlayerPrefs.GetInt("account2_char");
        }
        if (account == 3)
        {
            character = PlayerPrefs.GetInt("account3_char");
        }
        if (account == 4)
        {
            character = PlayerPrefs.GetInt("account4_char");
        }

        if(character == 1)
        {
            girl.SetActive(false);
        }
        else
        {
            boy.SetActive(false);
        }


    }

    
}
