using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hide_parents_account : MonoBehaviour
{
    [SerializeField] private GameObject slot1;
    [SerializeField] private GameObject slot2;
    [SerializeField] private GameObject slot3;
    [SerializeField] private GameObject slot4;

    // Start is called before the first frame update
    private void OnEnable()
    {
        string a = PlayerPrefs.GetString("account1_username");
        string b = PlayerPrefs.GetString("account2_username");
        string c = PlayerPrefs.GetString("account3_username");
        string d = PlayerPrefs.GetString("account4_username");

        if (a == "")
        {
            slot1.SetActive(false);
        }
        else
        {
            slot1.SetActive(true);
        }

        if (b == "")
        {
            slot2.SetActive(false);
        }
        else
        {
            slot2.SetActive(true);
        }

        if (c == "")
        {
            slot3.SetActive(false);
        }
        else
        {
            slot3.SetActive(true);
        }
        if (d == "")
        {
            slot4.SetActive(false);
        }
        else
        {
            slot4.SetActive(true);
        }


    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
