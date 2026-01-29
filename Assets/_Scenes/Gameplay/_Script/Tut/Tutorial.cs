using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    [SerializeField] private GameObject Start_Location;
    [SerializeField] private GameObject Destination_Location;
    [SerializeField] private GameObject Cursor;
    [SerializeField] private float speed = 1f;


    [SerializeField] private GameObject object1;
    [SerializeField] private GameObject object2;
    [SerializeField] private GameObject object3;
    [SerializeField] private GameObject object4;

    float speeds;
    
    void Awake()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
       
            speeds += Time.deltaTime * speed;

            Cursor.transform.position = Vector3.Lerp(Start_Location.transform.position, Destination_Location.transform.position, speeds);
        
           if(speeds > 2)
        {
            speeds = 0;
        }

    }

    public void Tutorial_end()
    {
        
        this.gameObject.SetActive(false);
    }
    
}
