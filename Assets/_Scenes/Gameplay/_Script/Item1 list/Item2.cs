using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item2 : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Item2")
        {

            GetComponent<RawImage>().color = new Color32(255, 255, 255, 255);
            GameObject.FindGameObjectWithTag("Item2").SetActive(false);
        }
    }
}
