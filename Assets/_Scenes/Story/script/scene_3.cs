using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene_3 : MonoBehaviour
{
    [SerializeField] private Animator Enemy_anim;
    [SerializeField] private Animator Boy;
    [SerializeField] private Animator Girl;

    [SerializeField] private GameObject scope_crew;
    [SerializeField] private GameObject scope_crew_rotate;
    [SerializeField] private float Sneaking_time;
    [SerializeField] private float boyTargettime;
    float boy_time;

    [SerializeField] private GameObject first_panel;
    [SerializeField] private GameObject second_panel;

    [Header("Running")]
    [SerializeField] private GameObject camera2nds;
    [SerializeField] private GameObject cameralast;
    [SerializeField] private GameObject next_panel;
    [SerializeField] private GameObject this_panel;

    void Start()
    {
        Enemy_anim.Play("Sneaking");
        Invoke("sneak",Sneaking_time);
    }

    private void Update()
    {
        boy_time += Time.deltaTime / boyTargettime;


        if(second_panel.activeInHierarchy == true)
        {
            scope_crew.transform.localRotation = Quaternion.Slerp(scope_crew.transform.localRotation, scope_crew_rotate.transform.localRotation, boy_time);
        }
        
    }
    void sneak()
    {
        first_panel.SetActive(true);
    }

    public void run()
    {
        Boy.Play("run");
        Girl.Play("run");
        Invoke("camera2nd", 6);
    }

    public void caught()
    {
        Enemy_anim.Play("shock");
    }
    // Update is called once per frame
    
    void camera2nd()
    {
        camera2nds.SetActive(false);
        cameralast.SetActive(true);
        next_panel.SetActive(true);
        this_panel.SetActive(false);

    }
}
