using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOR_DEMO_ONLY : MonoBehaviour
{
    [SerializeField] private GameObject lock2;
    [SerializeField] private GameObject lock3;
    [SerializeField] private GameObject lock4;
    [SerializeField] private GameObject lock5;

    [SerializeField] private GameObject collider2;
    [SerializeField] private GameObject collider3;
    [SerializeField] private GameObject collider4;
    [SerializeField] private GameObject collider5;




        [SerializeField] private GameObject island1_chest1;
        [SerializeField] private GameObject island1_chest2;
        [SerializeField] private GameObject island1_chest3;
        [SerializeField] private GameObject island1_chest4;
        [SerializeField] private GameObject island1_chest5;

        [SerializeField] private GameObject island2_chest1;
        [SerializeField] private GameObject island2_chest2;
        [SerializeField] private GameObject island2_chest3;
        [SerializeField] private GameObject island2_chest4;
        [SerializeField] private GameObject island2_chest5;
                                                   
        [SerializeField] private GameObject island3_chest1;
        [SerializeField] private GameObject island3_chest2;
        [SerializeField] private GameObject island3_chest3;
        [SerializeField] private GameObject island3_chest4;
        [SerializeField] private GameObject island3_chest5;
                                                   
        [SerializeField] private GameObject island4_chest1;
        [SerializeField] private GameObject island4_chest2;
        [SerializeField] private GameObject island4_chest3;
        [SerializeField] private GameObject island4_chest4;
        [SerializeField] private GameObject island4_chest5;

        [SerializeField] private GameObject island5_chest1;
        [SerializeField] private GameObject island5_chest2;
        [SerializeField] private GameObject island5_chest3;
        [SerializeField] private GameObject island5_chest4;
        [SerializeField] private GameObject island5_chest5;




    public void DEMO_MODE()
    {
        lock2.SetActive(false);
        lock3.SetActive(false);
        lock4.SetActive(false);
        lock5.SetActive(false);


        collider2.SetActive(true);
        collider3.SetActive(true);
        collider4.SetActive(true);
        collider5.SetActive(true);

        island1_chest1.SetActive(true);
        island1_chest2.SetActive(true);
        island1_chest3.SetActive(true);
        island1_chest4.SetActive(true);
        island1_chest5.SetActive(true);

        island2_chest1.SetActive(true);
        island2_chest2.SetActive(true);
        island2_chest3.SetActive(true);
        island2_chest4.SetActive(true);
        island2_chest5.SetActive(true);

        island3_chest1.SetActive(true);
        island3_chest2.SetActive(true);
        island3_chest3.SetActive(true);
        island3_chest4.SetActive(true);
        island3_chest5.SetActive(true);

        island4_chest1.SetActive(true);
        island4_chest2.SetActive(true);
        island4_chest3.SetActive(true);
        island4_chest4.SetActive(true);
        island4_chest5.SetActive(true);

        island5_chest1.SetActive(true);
        island5_chest2.SetActive(true);
        island5_chest3.SetActive(true);
        island5_chest4.SetActive(true);
        island5_chest5.SetActive(true);

    }
}
