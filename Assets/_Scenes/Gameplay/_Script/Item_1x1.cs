using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_1x1 : MonoBehaviour
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
        correct = PlayerPrefs.GetInt("correct");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == Item_Number)
        {
            correct++;
            PlayerPrefs.SetInt("correct", correct);
            //GameObject.FindGameObjectWithTag(Item_Number).transform.position = this.transform.position;

        }

        if (collision.gameObject.GetComponent<BoxCollider2D>())
        {
            collision.gameObject.transform.position = this.transform.position;
        }
       


    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.tag == Item_Number)
        {
            correct--;
            PlayerPrefs.SetInt("correct", correct);
        }


    }

}
