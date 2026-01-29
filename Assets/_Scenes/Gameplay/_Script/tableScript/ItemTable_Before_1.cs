using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemTable_Before_1 : MonoBehaviour
{

    //public TextMeshProUGUI Score;
    int correct = 0;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("Table_1_Before", "");
        PlayerPrefs.SetString("Table_1_After", "");
    }

    // Update is called once per frame
    void Update()
    {
        correct = PlayerPrefs.GetInt("correct");
        //Score.text = "Score: " + correct.ToString();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        string TableHold = PlayerPrefs.GetString("Table_1_After");

        if (collision.tag == "Egg")
        {

            
            PlayerPrefs.SetString("Table_1_Before", "Egg");

            if(TableHold == "Flower")
            {
                correct--;
                correct--;
                PlayerPrefs.SetInt("correct", correct);
            }
            if (TableHold == "Seed")
            {

                return;
            }

            correct++;
            PlayerPrefs.SetInt("correct", correct);
        }
        if (collision.tag == "Seed")
        {
            correct++;
            PlayerPrefs.SetInt("correct", correct);
            PlayerPrefs.SetString("Table_1_Before", "Seed");

            if (TableHold == "Chick")
            {
                correct--;
                correct--;
                PlayerPrefs.SetInt("correct", correct);
            }

        }
        if (collision.tag == "Chick")
        {
            PlayerPrefs.SetString("Table_1_Before", "Chick");
        }
        if (collision.tag == "Flower")
        {
            PlayerPrefs.SetString("Table_1_Before", "Chick");
        }


    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.tag == "Egg")
        {
            correct--;
            PlayerPrefs.SetInt("correct", correct);
            PlayerPrefs.SetString("Table_1_Before", "");
        }
        if (collision.tag == "Seed")
        {
            correct--;
            PlayerPrefs.SetInt("correct", correct);
            PlayerPrefs.SetString("Table_1_Before", "");
        }


    }

}
