using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First_Install : MonoBehaviour
{

    int First_Run;
    // Start is called before the first frame update
    void Start()
    {
        First_Run = PlayerPrefs.GetInt("First_Run");

        if(First_Run == 0)
        {
            PlayerPrefs.SetFloat("Global_BG_Volume",1);
            PlayerPrefs.SetInt("First_Run",1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
