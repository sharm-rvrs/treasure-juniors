using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Math1Answer : MonoBehaviour
{
    [SerializeField] private GameObject Item1;
    [SerializeField] private GameObject Item2;
    [SerializeField] private GameObject Item3;
    [SerializeField] private GameObject Item4;
    [SerializeField] private GameObject Item5;

     int score;

    private void Start()
    {
        PlayerPrefs.SetInt("correct",0);

    }

   
    

    public void GetScore()
    {

        if (Item1.activeInHierarchy == false)
        {
            score++;
        }
        if (Item2.activeInHierarchy == false)
        {
            score++;
        }
        if (Item3.activeInHierarchy == false)
        {
            score++;
        }
        if (Item4.activeInHierarchy == false)
        {
            score++;

        }
        if (Item5.activeInHierarchy == false)
        {
            score++;
        }

        PlayerPrefs.SetInt("correct", score);
    }
}
