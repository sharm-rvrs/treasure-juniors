
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MatchLine1 : MonoBehaviour
{
   
    int correct = 0;
    [SerializeField] private string Item_Number;

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

        if (collision.tag == Item_Number)
        {
            int a = PlayerPrefs.GetInt("correct");
            correct = a;
            correct++;
            PlayerPrefs.SetInt("correct", correct);
            
        }
        collision.gameObject.GetComponent<DragNDrop_Return>().enabled = false;
        collision.gameObject.SetActive(false);

    }
    //private void OnTriggerExit2D(Collider2D collision)
    //{

    //    if (collision.tag == Item_Number)
    //    {
    //        int a = PlayerPrefs.GetInt("correct");
    //        correct += a;
    //        correct--;
    //        PlayerPrefs.SetInt("correct", correct);
    //    }
        

    //}
}
