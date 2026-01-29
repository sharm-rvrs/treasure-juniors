using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievement_TUT : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject a1;
    [SerializeField] private GameObject a2;
    [SerializeField] private GameObject a3;
    [SerializeField] private GameObject a4;

    [SerializeField] private GameObject nestor;
    [SerializeField] private GameObject Jeano;

    [SerializeField] private GameObject puig;

    private void Start()
    {
        int a = PlayerPrefs.GetInt("Achievement_TUT");

        if(a == 0)
        {
            puig.SetActive(true);
            PlayerPrefs.SetInt("Achievement_TUT",1);
        }
    }
    public void phase1()
    {
        a1.SetActive(false);
        a2.SetActive(true);
    }

    public void phase2()
    {
        a2.SetActive(false);
        a3.SetActive(true);
    }

    public void phase3()
    {
        a3.SetActive(false);
        a4.SetActive(true);
    }

    public void phase4()
    {
        puig.SetActive(false);
        nestor.SetActive(false);
        Jeano.SetActive(false);
    }
}
