using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class last_island_transition : MonoBehaviour
{
    
    [SerializeField] private GameObject maincamera;
    float timer;

    [SerializeField] private Animator boy;
    [SerializeField] private Animator girl;

    int count = 1;

    [Header("Scene1")]
    [SerializeField] private float scene1_timer;
    [SerializeField] private GameObject button1;
    [SerializeField] private GameObject a;
    [SerializeField] private GameObject b;

    [Header("Scene2")]
    [SerializeField] private float scene2_timer;
    [SerializeField] private GameObject button2;

    void Start()
    {
        Invoke("scene1", scene1_timer);
        //maincamera.transform.rotation = Quaternion.Slerp(Starting.transform.rotation, T1.transform.localRotation, narrator_time);
    }

    // Update is called once per frame
    void Update()
    {

        if(count == 1)
        {
            timer += Time.deltaTime / scene1_timer;
            maincamera.transform.position = Vector3.Lerp(a.transform.localPosition, b.transform.localPosition, timer);
        }

        
        
    }

    void scene1()
    {
        button1.SetActive(true);
    }

    void scene2()
    {
        button2.SetActive(true);
    }

    public void addcount()
    {
        count++;
        timer = 0;

        if(count == 2)
        {
            boy.Play("scene2");
            girl.Play("scene2");
            Invoke("scene2", scene2_timer);
        }

        if(count == 3)
        {
            boy.Play("scene3");
            girl.Play("scene3");
        }
    }

  
}
