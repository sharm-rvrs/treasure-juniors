using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TUT_map : MonoBehaviour
{
    [Header("hand pointer")]
    [SerializeField] private GameObject p1;
    [SerializeField] private GameObject p2;
    [SerializeField] private GameObject p3;
    [SerializeField] private GameObject p4;

    [Header("trigger object")]
    [SerializeField] private GameObject firstBTN;
    [SerializeField] private GameObject panel_descript_1;

    public void point1()
    {
        p1.SetActive(false);
        
    }

    public void point3()
    {
        p3.SetActive(true);
    }
    public void point3_next()
    {
        p3.SetActive(false);
    }

    private void Update()
    {
        if(firstBTN.activeInHierarchy == true)
        {
            p2.SetActive(true);
        }
        else
        {
            p2.SetActive(false);
        }

        if (panel_descript_1.activeInHierarchy == true)
        {
            p4.SetActive(true);
        }
        else
        {
            p4.SetActive(false);
        }
    }
}
