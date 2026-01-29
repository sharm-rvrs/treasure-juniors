using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class last_island_appear : MonoBehaviour
{
    [SerializeField] private float timer = 3;

    [SerializeField] private GameObject effects;
    void Start()
    {
        Invoke("effect", timer);
    }

    // Update is called once per frame
    void effect()
    {
        effects.SetActive(false);
    }
}
