using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item6 : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Item6")
        {

            GetComponent<RawImage>().color = new Color32(255, 255, 255, 255);
            GameObject.FindGameObjectWithTag("Item6").SetActive(false);
        }
    }
}
