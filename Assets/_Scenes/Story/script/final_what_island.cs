using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class final_what_island : MonoBehaviour
{
   

    int a;
    private void Start()
    {
        a = PlayerPrefs.GetInt("island_story");
    }

    public void Return_island()
    {
        Invoke("return_islands", 3);
    }

    void return_islands()
    {
        if (a == 0)
        {

            
            PlayerPrefs.SetInt("math_last_island", 1);
            SceneManager.LoadScene("Math_Map");

        }
        else
        {
            PlayerPrefs.SetInt("science_last_island", 1);
            PlayerPrefs.SetInt("island_story", 0);
            SceneManager.LoadScene("Science_Map");
        }

    }
}
