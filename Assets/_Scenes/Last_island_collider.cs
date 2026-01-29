using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Last_island_collider : MonoBehaviour
{
    [SerializeField] private GameObject button;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("boat"))
        {
            button.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == ("boat"))
        {
            button.SetActive(false);
        }
    }
}
