using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class last_island_opening : MonoBehaviour
{
    int a;
    [SerializeField] private GameObject THE_LAST_ISLAND;
    [SerializeField] private string subject_last_island;
    void Start()
    {
        a = PlayerPrefs.GetInt(subject_last_island);

        if(a == 0)
        {
            THE_LAST_ISLAND.SetActive(false);
        }
    }

   
}
