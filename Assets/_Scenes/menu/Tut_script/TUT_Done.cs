using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TUT_Done : MonoBehaviour
{
    // Start is called before the first frame update
    int a;
    [SerializeField] private GameObject close_this;

    public void back_char()
    {
        a = PlayerPrefs.GetInt("Tutorial");

        if (a == 0)
        {
            PlayerPrefs.SetInt("Tutorial",1);
            close_this.SetActive(false);
        }
    }
}
