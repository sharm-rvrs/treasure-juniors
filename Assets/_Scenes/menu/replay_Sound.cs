using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class replay_Sound : MonoBehaviour
{
    [SerializeField] private AudioSource Sounds;
    void Start()
    {
        
    }

    public void Replay()
    {
        Sounds.Play();
    }
}
