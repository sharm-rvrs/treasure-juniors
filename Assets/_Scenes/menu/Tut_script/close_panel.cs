using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class close_panel : MonoBehaviour
{
    int a;
    // Start is called before the first frame update
    [SerializeField] private GameObject To_open;
    [SerializeField] private GameObject To_close;

    public void openNclose()
    {
        a = PlayerPrefs.GetInt("Tutorial");

        if (a == 0)
        {
            To_open.SetActive(true);
            To_close.SetActive(false);
        }
            
    }
}
