using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FlipCard : MonoBehaviour
{

    bool flip;
    bool flip2;
    // Start is called before the first frame update
    void Start()
    {
        flip = true;
        flip = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Flip()
    {

        if(flip == true)
        {


            this.transform.Rotate(0, 90, 0, Space.Self);
            flip2 = false;
            flip = false;

        }
        if (flip2 == false)
        {
            this.transform.Rotate(0, 0, 0, Space.Self);
            flip = true;
            flip2 = true;
        }
        

    }
}
