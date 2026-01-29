using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Of_Player : MonoBehaviour
{
    int account_is;
    int player_is;

    [SerializeField] private GameObject Char_Holder;
    [SerializeField] private GameObject Char_Male;
    [SerializeField] private GameObject Char_Female;
    void Awake()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Char_Holder.SetActive(true);

        account_is = PlayerPrefs.GetInt("account_is");


        if (account_is == 1)
        {
            player_is = PlayerPrefs.GetInt("account1_char");
        }

        if (account_is == 2)
        {
            player_is = PlayerPrefs.GetInt("account2_char");
        }

        if (account_is == 3)
        {
            player_is = PlayerPrefs.GetInt("account3_char");
        }

        if (account_is == 4)
        {
            player_is = PlayerPrefs.GetInt("account4_char");
        }


        if (player_is == 1)
        {
            Char_Male.SetActive(true);
            Char_Female.SetActive(false);
        }

        if (player_is == 2)
        {
            Char_Male.SetActive(false);
            Char_Female.SetActive(true);
        }
    }
}
