using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volume_Control : MonoBehaviour
{
    

    [SerializeField] private float a;

    // Update is called once per frame
    void Update()
    {




        a = PlayerPrefs.GetFloat("Global_BG_Volume");


        


    }
}
