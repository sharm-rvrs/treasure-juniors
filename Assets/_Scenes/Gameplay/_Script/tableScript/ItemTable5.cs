using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemTable5 : MonoBehaviour
{

    //public TextMeshProUGUI Score;
    int correct = 0;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        correct = PlayerPrefs.GetInt("correct");
        //Score.text = "Score: " + correct.ToString();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Item13")
        {
            correct++;
            PlayerPrefs.SetInt("correct", correct);
        }
        if (collision.tag == "Item14")
        {
            correct++;
            PlayerPrefs.SetInt("correct", correct);
        }
        if (collision.tag == "Item15")
        {
            correct++;
            PlayerPrefs.SetInt("correct", correct);
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.tag == "Item13")
        {
            correct--;
            PlayerPrefs.SetInt("correct", correct);
        }
        if (collision.tag == "Item14")
        {
            correct--;
            PlayerPrefs.SetInt("correct", correct);
        }
        if (collision.tag == "Item15")
        {
            correct--;
            PlayerPrefs.SetInt("correct", correct);
        }

    }

}
