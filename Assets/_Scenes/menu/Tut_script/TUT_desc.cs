using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TUT_desc : MonoBehaviour
{
    // Start is called before the first frame update
    int a;
    [SerializeField] private GameObject To_open;
    public void close()
    {
        a = PlayerPrefs.GetInt("Tutorial");

        if (a == 0)
        {
            To_open.SetActive(true);
            this.gameObject.SetActive(false);
        }

           
    }
}
