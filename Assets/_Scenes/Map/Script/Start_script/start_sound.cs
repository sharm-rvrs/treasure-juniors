using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_sound : MonoBehaviour
{

    public AudioSource seawaves;
    public AudioSource RunSound;
    float a;
    // Start is called before the first frame update
    void Start()
    {
         a = PlayerPrefs.GetFloat("Global_BG_Volume");
        

    }

    // Update is called once per frame
    void Update()
    {


        seawaves.volume = a;
        RunSound.volume = a;

    }
}
