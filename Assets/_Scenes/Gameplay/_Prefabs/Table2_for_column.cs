using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Table2_for_column : MonoBehaviour
{
    [SerializeField] private RawImage column1;
   

    int count = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Item2")
        {


            if (count == 0)
            {
                column1.color = new Color32(255, 255, 255, 255);
                //GameObject.FindGameObjectWithTag("Item1").SetActive(false);
                collision.gameObject.SetActive(false);
                count++;
                return;
            }

          

        }
    }
}
