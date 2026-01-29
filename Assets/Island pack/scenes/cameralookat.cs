using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameralookat : MonoBehaviour
{
    public GameObject cameralook;
    public GameObject Cam1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 camlookat = cameralook.transform.position;
        transform.LookAt(camlookat);
       
    }
}
