using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_char : MonoBehaviour
{


    public GameObject Char_Male;
    public GameObject Char_Female;
    public GameObject Char_Male_OnTheBoat;
    public GameObject Char_Female_OnTheBoat;

    int Account_Is;
    int Char;
    void Start()
    {
        Account_Is = PlayerPrefs.GetInt("account_is");
       
        if(Account_Is == 1)
        {
            Char = PlayerPrefs.GetInt("account1_char");

            if(Char == 1)
            {
                Char_Male.SetActive(true);
                Char_Female.SetActive(false);
                Char_Male_OnTheBoat.SetActive(true);
                Char_Female_OnTheBoat.SetActive(false);
            }
            else
            {
                Char_Male.SetActive(false);
                Char_Female.SetActive(true);
                Char_Male_OnTheBoat.SetActive(false);
                Char_Female_OnTheBoat.SetActive(true);
            }
        }

        if (Account_Is == 2)
        {
            Char = PlayerPrefs.GetInt("account2_char");

            if (Char == 1)
            {
                Char_Male.SetActive(true);
                Char_Female.SetActive(false);
                Char_Male_OnTheBoat.SetActive(true);
                Char_Female_OnTheBoat.SetActive(false);
            }
            else
            {
                Char_Male.SetActive(false);
                Char_Female.SetActive(true);
                Char_Male_OnTheBoat.SetActive(false);
                Char_Female_OnTheBoat.SetActive(true);
            }
        }

        if (Account_Is == 3)
        {
            Char = PlayerPrefs.GetInt("account3_char");

            if (Char == 1)
            {
                Char_Male.SetActive(true);
                Char_Female.SetActive(false);
                Char_Male_OnTheBoat.SetActive(true);
                Char_Female_OnTheBoat.SetActive(false);
            }
            else
            {
                Char_Male.SetActive(false);
                Char_Female.SetActive(true);
                Char_Male_OnTheBoat.SetActive(false);
                Char_Female_OnTheBoat.SetActive(true);
            }
        }

        if (Account_Is == 4)
        {
            Char = PlayerPrefs.GetInt("account4_char");

            if (Char == 1)
            {
                Char_Male.SetActive(true);
                Char_Female.SetActive(false);
                Char_Male_OnTheBoat.SetActive(true);
                Char_Female_OnTheBoat.SetActive(false);
            }
            else
            {
                Char_Male.SetActive(false);
                Char_Female.SetActive(true);
                Char_Male_OnTheBoat.SetActive(false);
                Char_Female_OnTheBoat.SetActive(true);
            }
        }



    }

    
}
