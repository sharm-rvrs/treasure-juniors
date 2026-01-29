using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_Gameplay : MonoBehaviour
{
    [SerializeField] private AudioClip[] Gin_Dalandan;
    [SerializeField] private AudioSource audiosource;
   

    // Use this for initialization
    void Start()
    {

        RandomSoundness();
    }


   

    void RandomSoundness()
    {
        audiosource.clip = Gin_Dalandan[Random.Range(0, Gin_Dalandan.Length)];
        audiosource.Play();
        
    }
}
