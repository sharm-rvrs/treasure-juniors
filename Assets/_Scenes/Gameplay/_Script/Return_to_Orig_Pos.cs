using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Return_to_Orig_Pos : MonoBehaviour
{
    Vector3 OrigPost;
    bool Return_is = true;
    void Start()
    {
        OrigPost = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (Return_is == true)
        {
            if (gameObject.GetComponent<BoxCollider2D>().isActiveAndEnabled)
            {
                this.transform.position = OrigPost;
            }
        }

       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Magnet>())
        {
            Return_is = false;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Magnet>())
        {
            Return_is = true;
        }
    }
}

