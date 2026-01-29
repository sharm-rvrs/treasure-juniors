using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC_Subject : MonoBehaviour
{
    [SerializeField] private GameObject user1_math_BTN;
    [SerializeField] private GameObject user1_science_BTN;

    [SerializeField] private GameObject user2_math_BTN;
    [SerializeField] private GameObject user2_science_BTN;

    [SerializeField] private GameObject user3_math_BTN;
    [SerializeField] private GameObject user3_science_BTN;

    [SerializeField] private GameObject user4_math_BTN;
    [SerializeField] private GameObject user4_science_BTN;


    public void user_1()
    {
        user1_math_BTN.SetActive(true);
        user1_science_BTN.SetActive(true);

        user2_math_BTN.SetActive(false);
        user2_science_BTN.SetActive(false);
            
        user3_math_BTN.SetActive(false);
        user3_science_BTN.SetActive(false);
            
        user4_math_BTN.SetActive(false);
        user4_science_BTN.SetActive(false);

        PlayerPrefs.SetInt("account_is",1);
    }

    public void user_2()
    {
        user1_math_BTN.SetActive(false);
        user1_science_BTN.SetActive(false);

        user2_math_BTN.SetActive(true);
        user2_science_BTN.SetActive(true);

        user3_math_BTN.SetActive(false);
        user3_science_BTN.SetActive(false);

        user4_math_BTN.SetActive(false);
        user4_science_BTN.SetActive(false);
        PlayerPrefs.SetInt("account_is", 2);
    }

    public void user_3()
    {
        user1_math_BTN.SetActive(false);
        user1_science_BTN.SetActive(false);

        user2_math_BTN.SetActive(false);
        user2_science_BTN.SetActive(false);

        user3_math_BTN.SetActive(true);
        user3_science_BTN.SetActive(true);

        user4_math_BTN.SetActive(false);
        user4_science_BTN.SetActive(false);

        PlayerPrefs.SetInt("account_is", 3);
    }

    public void user_4()
    {
        user1_math_BTN.SetActive(false);
        user1_science_BTN.SetActive(false);

        user2_math_BTN.SetActive(false);
        user2_science_BTN.SetActive(false);

        user3_math_BTN.SetActive(false);
        user3_science_BTN.SetActive(false);

        user4_math_BTN.SetActive(true);
        user4_science_BTN.SetActive(true);

        PlayerPrefs.SetInt("account_is", 4);
    }

    public void user_close()
    {
        user1_math_BTN.SetActive(false);
        user1_science_BTN.SetActive(false);

        user2_math_BTN.SetActive(false);
        user2_science_BTN.SetActive(false);

        user3_math_BTN.SetActive(false);
        user3_science_BTN.SetActive(false);

        user4_math_BTN.SetActive(false);
        user4_science_BTN.SetActive(false);

        PlayerPrefs.SetInt("account_is", 0);
    }
}


