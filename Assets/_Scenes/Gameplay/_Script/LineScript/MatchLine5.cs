
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MatchLine5 : MonoBehaviour
{

    int correct = 0;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("correct", 0);
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Item1")
        {
            correct++;
            PlayerPrefs.SetInt("correct", correct);
        }


    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.tag == "Item1")
        {
            correct--;
            PlayerPrefs.SetInt("correct", correct);
        }


    }
}
