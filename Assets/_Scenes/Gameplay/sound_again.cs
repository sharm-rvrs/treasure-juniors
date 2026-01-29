using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_again : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject objects;
    [SerializeField] private AudioSource first;
    [SerializeField] private AudioSource Second;

    public void replay_sound()
    {
        if(objects.activeInHierarchy == false)
        {
            first.Play();
        }
        else
        {
            Second.Play();
        }
    }
}
