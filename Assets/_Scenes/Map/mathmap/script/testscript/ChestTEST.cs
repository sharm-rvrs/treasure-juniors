using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestTEST : MonoBehaviour
{
    public Animator Chest;
    

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Chest.Play("open");
            
        }

        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Chest.Play("close");
            
        }
    }
}
