using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fin_Test : MonoBehaviour
{
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4;
    public GameObject item5;
    public GameObject item6;
    public GameObject item7;
    public GameObject item8;
    public GameObject item9;

    public GameObject Congrats;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (item1.activeInHierarchy == false && item2.activeInHierarchy == false && item3.activeInHierarchy == false && item4.activeInHierarchy == false && item5.activeInHierarchy == false && item6.activeInHierarchy == false
             && item7.activeInHierarchy == false && item8.activeInHierarchy == false && item9.activeInHierarchy == false)
        {
            Congrats.SetActive(true);
        }
    }
}
