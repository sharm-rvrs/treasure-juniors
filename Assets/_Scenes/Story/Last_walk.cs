using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Last_walk : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private Animator chest;
    [SerializeField] private Animator enemy;

    [SerializeField] private GameObject effects;

    [SerializeField] private float scene5_timer;
    [SerializeField] private GameObject maincamera;
    [SerializeField] private GameObject selfcamera;
    [SerializeField] private GameObject c;
    [SerializeField] private GameObject d;
    [SerializeField] private GameObject e;

    [SerializeField] private GameObject orbs;

    [SerializeField] private GameObject panel_4;
    [SerializeField] private float scene7_timer;

    [SerializeField] private GameObject last_panel;

    [SerializeField] private GameObject tap_panel;

    bool camera_trigger = false;
    bool camera_trigger_focus = false;
    float timer = 0;
    void Update()
    {
        if(camera_trigger == true)
        {
            timer += Time.deltaTime / scene5_timer;
            maincamera.transform.position = Vector3.Lerp(c.transform.localPosition, d.transform.localPosition, timer);
        }

        if (camera_trigger_focus == true)
        {
            timer += Time.deltaTime / scene7_timer;
            maincamera.transform.position = Vector3.Lerp(d.transform.localPosition, e.transform.localPosition, timer);
            maincamera.transform.LookAt(orbs.transform.position);
        }
    }

    private void OnTriggerEnter(Collider player)
    {
        if(player.tag == "walk")
        {
            
            anim.Play("scene4");
        }

        if (player.tag == "stop")
        {

            anim.Play("idle");
            chest.Play("open");
            Invoke("effect", 1);
            Invoke("scene5", 5);
        }


    }
    void effect()
    {
        effects.SetActive(true);
    }

    void scene5()
    {
        selfcamera.SetActive(false);
        maincamera.SetActive(true);
        camera_trigger = true;
        Invoke("scene6", 6);
    }
    void scene6()
    {
        panel_4.SetActive(true);
        enemy.Play("iyak");
        Invoke("scene7", 10);
    }

    void scene7()
    {
        panel_4.SetActive(false);
        camera_trigger = false;
        camera_trigger_focus = true;
        timer = 0;
        Invoke("scene8", 4);
    }
    void scene8()
    {
        last_panel.SetActive(true);
        Invoke("scene_last", 7);
    }
    void scene_last()
    {
        tap_panel.SetActive(true);
    }
    
}
