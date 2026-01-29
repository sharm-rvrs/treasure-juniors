using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taetae : MonoBehaviour
{
    [SerializeField] private AudioSource runn;
    void running_sound()
    {
        runn.Play();
    }
}
