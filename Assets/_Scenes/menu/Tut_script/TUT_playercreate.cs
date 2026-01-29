using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TUT_playercreate : MonoBehaviour
{
    int a;
    [SerializeField] private GameObject open_this;

    private void Start()
    {
        a = PlayerPrefs.GetInt("Tutorial");

        if(a == 0)
        {
            open_this.SetActive(true);
        }
        else
        {
            open_this.SetActive(false);
        }
    }

    
}
