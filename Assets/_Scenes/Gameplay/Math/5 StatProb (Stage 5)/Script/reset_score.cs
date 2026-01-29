using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset_score : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("correct", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
