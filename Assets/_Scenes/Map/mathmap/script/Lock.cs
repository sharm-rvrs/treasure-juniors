using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    [Header("Lock image btn")]
    [SerializeField] private GameObject lock2;
    [SerializeField] private GameObject lock3;
    [SerializeField] private GameObject lock4;
    [SerializeField] private GameObject lock5;

    [Header("chest")]
    [SerializeField] private GameObject first_chest_island1;
    [SerializeField] private GameObject first_chest_island2;
    [SerializeField] private GameObject first_chest_island3;
    [SerializeField] private GameObject first_chest_island4;
    [SerializeField] private GameObject first_chest_island5;

    //[Header("Collider island")]
    //[SerializeField] private GameObject collider2;
    //[SerializeField] private GameObject collider3;
    //[SerializeField] private GameObject collider4;
    //[SerializeField] private GameObject collider5;

    [Header("Collision")]
    [SerializeField] private GameObject mathcoll1;
    [SerializeField] private GameObject mathcoll2;
    [SerializeField] private GameObject mathcoll3;
    [SerializeField] private GameObject mathcoll4;
    [SerializeField] private GameObject mathcoll5;

    [Header("timer")]
    [SerializeField] private float timer = 1;
    private void Start()
    {

        if (first_chest_island2.activeInHierarchy == true)
        {
            lock2.SetActive(false);
           //mathcoll2.SetActive(true);
        }
        else
        {
            mathcoll2.SetActive(false);
        }

        if (first_chest_island3.activeInHierarchy == true)
        {
            lock3.SetActive(false);

            //mathcoll3.SetActive(true);
        }
        else
        {
            mathcoll3.SetActive(false);
        }

        if (first_chest_island4.activeInHierarchy == true)
        {
            lock4.SetActive(false);

            //mathcoll4.SetActive(true);
        }
        else
        {
            mathcoll4.SetActive(false);
        }

        if (first_chest_island5.activeInHierarchy == true)
        {
            lock5.SetActive(false);

            //mathcoll5.SetActive(true);
        }
        else
        {
            mathcoll5.SetActive(false);
        }

        //delays();
    }


    public void lock_hide()
    {
        lock2.SetActive(false);
        lock3.SetActive(false);
        lock4.SetActive(false);
        lock5.SetActive(false);
    }

    public void lock_appear()
    {
        Invoke("delays", timer);
    }

    public void delays()
    {
        lock2.SetActive(true);
        lock3.SetActive(true);
        lock4.SetActive(true);
        lock5.SetActive(true);

        if (first_chest_island1.activeInHierarchy == true)
        {
            
            mathcoll1.SetActive(true);


        }

        if (first_chest_island2.activeInHierarchy == true)
        {
            lock2.SetActive(false);
            mathcoll2.SetActive(true);


        }

        if (first_chest_island3.activeInHierarchy == true)
        {
            lock3.SetActive(false);
            mathcoll3.SetActive(true);

        }

        if (first_chest_island4.activeInHierarchy == true)
        {
            lock4.SetActive(false);
            mathcoll4.SetActive(true);
        }

        if (first_chest_island5.activeInHierarchy == true)
        {
            lock5.SetActive(false);

            mathcoll5.SetActive(true);
        }




       
    }


}
