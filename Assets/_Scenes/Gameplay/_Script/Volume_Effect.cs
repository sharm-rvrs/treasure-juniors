using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volume_Effect : MonoBehaviour
{
    // Start is called before the first frame update

    float a;
    // Start is called before the first frame update
    void Start()
    {
        a = PlayerPrefs.GetFloat("Global_SE_Volume");


    }

    // Update is called once per frame
    void Update()
    {

        a = PlayerPrefs.GetFloat("Global_SE_Volume");
        this.GetComponent<AudioSource>().volume = a;


    }
}
