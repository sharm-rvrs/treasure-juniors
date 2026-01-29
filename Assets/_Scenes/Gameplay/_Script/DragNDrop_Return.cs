using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragNDrop_Return : MonoBehaviour
{

    bool move;
    Vector2 ResetPos;




    // Start is called before the first frame update
    void Start()
    {
        ResetPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {


        if (move == true)
        {
            this.transform.position = Input.mousePosition;


        }

    }

    public void nMouseDown()
    {
        GetComponent<BoxCollider2D>().enabled = false;
        move = true;

    }

    public void nMouseUp()
    {
        GetComponent<BoxCollider2D>().enabled = true;
        move = false;
        Invoke("delay", 0.5f);


    }

    private void delay()
    {
        if(this.GetComponent<DragNDrop_Return>().enabled == true)
        {
            this.transform.position = ResetPos;
        }
        
    }

}
