using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class grade : MonoBehaviour
{
    [SerializeField] private Image Fillpercent;

    // Start is called before the first frame update
    [SerializeField] private GameObject a;
    [SerializeField] private GameObject b;
    [SerializeField] private GameObject c;
    [SerializeField] private GameObject d;
    [SerializeField] private GameObject e;

    

    float Score; 
    // Update is called once per frame
    void Update()
    {
        Score = Fillpercent.fillAmount;

        if(Score < 74)
        {
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            e.SetActive(true);
        }
        if(Score > 75 && Score < 80)
        {
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(true);
            e.SetActive(false);
        }
        if(Score > 79 && Score < 85)
        {
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(true);
            d.SetActive(false);
            e.SetActive(false);
        }
        if(Score > 84 && Score < 90)
        {
            a.SetActive(false);
            b.SetActive(true);
            c.SetActive(false);
            d.SetActive(false);
            e.SetActive(false);
        }
        if(Score > 89)
        {
            a.SetActive(true);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            e.SetActive(false);
        }

        Debug.Log(Score);
    }
}
