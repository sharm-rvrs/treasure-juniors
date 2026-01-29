using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class type_sound_time : MonoBehaviour
{
    [SerializeField] private float time;
    private void OnEnable()
    {
        Invoke("playsound", time);
    }

    void playsound()
    {
        this.gameObject.GetComponent<AudioSource>().Stop();
    }
}
