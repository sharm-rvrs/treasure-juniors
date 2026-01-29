using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item1 : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Item1")
        {

            GetComponent<RawImage>().color = new Color32(255, 255, 255, 255);
            GameObject.FindGameObjectWithTag("Item1").SetActive(false);
        }
    }
}
