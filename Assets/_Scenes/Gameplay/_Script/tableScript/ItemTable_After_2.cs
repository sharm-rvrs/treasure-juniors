using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTable_After_2 : MonoBehaviour
{

    //public TextMeshProUGUI Score;
    int correct = 0;


    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("correct", 0);
    }

    // Update is called once per frame
    void Update()
    {
        correct = PlayerPrefs.GetInt("correct");
        //Score.text = "Score: " + correct.ToString();
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {

        string table1 = PlayerPrefs.GetString("Table_2_Before");

        if (table1 == "Egg")
        {
            if (collision.tag == "Chick")
            {
                correct++;
                PlayerPrefs.SetInt("correct", correct);

            }
            else
            {
                correct--;
                PlayerPrefs.SetInt("correct", correct);

            }
            return;

        }
        if (table1 == "Seed")
        {
            if (collision.tag == "Flower")
            {
                correct++;
                PlayerPrefs.SetInt("correct", correct);

            }
            else
            {
                correct--;
                PlayerPrefs.SetInt("correct", correct);

            }


        }

        if (table1 == "Chick")
        {
            return;

        }
        if (table1 == "Flower")
        {
            return;

        }

        if (collision.tag == "Seed")
        {
            PlayerPrefs.SetString("Table_2_After", "Seed");
            return;
        }

        if (table1 == "")
        {
            if (collision.tag == "Flower")
            {
                correct++;
                PlayerPrefs.SetInt("correct", correct);
                PlayerPrefs.SetString("Table_2_After", "Flower");

            }


            if (collision.tag == "Chick")
            {
                correct++;
                PlayerPrefs.SetInt("correct", correct);
                PlayerPrefs.SetString("Table_2_After", "Chick");
            }



        }



    }

}
