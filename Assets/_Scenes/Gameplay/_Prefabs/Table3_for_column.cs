using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Table3_for_column : MonoBehaviour
{
    [SerializeField] private RawImage column1;
    [SerializeField] private RawImage column2;
    [SerializeField] private RawImage column3;
    

    int count = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Item3")
        {


            if (count == 0)
            {
                column1.color = new Color32(255, 255, 255, 255);
                //GameObject.FindGameObjectWithTag("Item1").SetActive(false);
                collision.gameObject.SetActive(false);
                count++;
                return;
            }

            if (count == 1)
            {
                column2.color = new Color32(255, 255, 255, 255);
                //GameObject.FindGameObjectWithTag("Item1").SetActive(false);
                collision.gameObject.SetActive(false);
                count++;
                return;
            }

            if (count == 2)
            {
                column3.color = new Color32(255, 255, 255, 255);
                //GameObject.FindGameObjectWithTag("Item1").SetActive(false);
                collision.gameObject.SetActive(false);
                count++;
                return;
            }
           

        }
    }
}
