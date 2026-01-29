using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lock_science : MonoBehaviour
{
    [Header("Lock image btn")]
    [SerializeField] private GameObject lock2;
    [SerializeField] private GameObject lock3;
    

    [Header("chest")]
    [SerializeField] private GameObject first_chest_island2;
    [SerializeField] private GameObject first_chest_island3;
  

    [Header("Collider island")]
    [SerializeField] private GameObject collider2;
    [SerializeField] private GameObject collider3;



    [Header("timer")]
    [SerializeField] private float timer = 1;
    void Start()
    {
        if (first_chest_island2.activeInHierarchy == true)
        {
            lock2.SetActive(false);
            collider2.SetActive(true);
        }

        if (first_chest_island3.activeInHierarchy == true)
        {
            lock3.SetActive(false);
            collider3.SetActive(true);
        }

      

    }

    public void lock_hide()
    {
        lock2.SetActive(false);
        lock3.SetActive(false);
        collider2.SetActive(false);
        collider3.SetActive(false);
    }

    public void lock_appear()
    {
        Invoke("delay", timer);
    }

    void delay()
    {

        if (first_chest_island2.activeInHierarchy == false)
        {
            lock2.SetActive(true);

        }

        if (first_chest_island3.activeInHierarchy == false)
        {
            lock3.SetActive(true);

        }

        
    }
}
