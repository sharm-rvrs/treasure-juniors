using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_Drag_N_Drop : MonoBehaviour
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
        
        move = true;

    }

    public void nMouseUp()
    {
       
        move = false;
        //Invoke("delay", 0.5f);


    }

    private void delay()
    {
        this.transform.position = ResetPos;
    }

}
