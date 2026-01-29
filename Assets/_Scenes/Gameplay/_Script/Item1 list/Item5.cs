using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item5 : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Item5")
        {

            GetComponent<RawImage>().color = new Color32(255, 255, 255, 255);
            GameObject.FindGameObjectWithTag("Item5").SetActive(false);
        }
    }
}
