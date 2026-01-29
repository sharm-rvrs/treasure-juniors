using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {

      

        if (collision.gameObject.GetComponent<BoxCollider2D>())
        {
            collision.gameObject.transform.position = this.transform.position;
        }



    }
   
}
