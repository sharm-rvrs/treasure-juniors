using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keys_For_TUT : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject a;
    [SerializeField] private GameObject b;
    [SerializeField] private GameObject c;
    [SerializeField] private GameObject d;
    [SerializeField] private GameObject e;

    [SerializeField] private GameObject a1;
    [SerializeField] private GameObject b1;
    [SerializeField] private GameObject c1;
    [SerializeField] private GameObject d1;
    [SerializeField] private GameObject e1;

    [SerializeField] private GameObject shing1;
    [SerializeField] private GameObject shing2;

    public void open_key()
    {
        a.SetActive(true);
        b.SetActive(true);
        c.SetActive(true);
        d.SetActive(true);
        e.SetActive(true);

        a1.SetActive(true);
        b1.SetActive(true);
        c1.SetActive(true);
        d1.SetActive(true);
        e1.SetActive(true);

        shing1.SetActive(true);
        shing2.SetActive(true);
    }

    public void close_key()
    {
        a.SetActive(false);
        b.SetActive(false);
        c.SetActive(false);
        d.SetActive(false);
        e.SetActive(false);

        a1.SetActive(false);
        b1.SetActive(false);
        c1.SetActive(false);
        d1.SetActive(false);
        e1.SetActive(false);

        shing1.SetActive(false);
        shing2.SetActive(false);
    }
}
