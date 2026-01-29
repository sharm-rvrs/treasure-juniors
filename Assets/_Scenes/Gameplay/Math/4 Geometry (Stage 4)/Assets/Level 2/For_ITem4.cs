using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class For_ITem4 : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Item4")
        {

            GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.FindGameObjectWithTag("Item4").SetActive(false);
        }
    }
}
