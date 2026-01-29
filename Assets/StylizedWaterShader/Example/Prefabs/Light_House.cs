using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_House : MonoBehaviour
{
    float tae;
    Vector3 a;
    [SerializeField] private GameObject ilaw_ng_tahanan;
    [SerializeField] private float Speed = 1;
    void Start()
    {
        tae = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tae += Time.deltaTime;
        
        ilaw_ng_tahanan.transform.Rotate(0,0,Time.deltaTime*Speed);

    }

}
