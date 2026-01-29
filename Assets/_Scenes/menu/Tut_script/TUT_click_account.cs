using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TUT_click_account : MonoBehaviour
{
    int a;
    [SerializeField] private GameObject open_this;

    public void back_char()
    {
        a = PlayerPrefs.GetInt("Tutorial");

        if (a == 0)
        {
            open_this.SetActive(true);
        }
    }
}
