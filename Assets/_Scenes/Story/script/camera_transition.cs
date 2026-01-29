using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class camera_transition : MonoBehaviour
{
    [Header("Camera Position")]
    [SerializeField] private GameObject Scope_Panel;
    [SerializeField] private GameObject maincamera;
    [SerializeField] private GameObject Starting;
    [SerializeField] private GameObject T1;
    [SerializeField] private GameObject T2;
    [SerializeField] private GameObject T3;
    [SerializeField] private GameObject T4;
    [SerializeField] private GameObject T5;
    [SerializeField] private GameObject T6;
    [SerializeField] private GameObject T7;
    [SerializeField] private GameObject T8;
    [SerializeField] private GameObject T9;
    [SerializeField] private GameObject T10;

    [Header("Pirate enemy")]
    [SerializeField] NavMeshAgent enemyship;
    [SerializeField] GameObject enemyship_object;
    int count = 0;

    [Header("Pirate enemy target location")]
    [SerializeField] private GameObject ship_newPos;
    [SerializeField] private GameObject target_location;
    [SerializeField] private GameObject lookat_ship;
    [SerializeField] private GameObject sail_away;
    float t;
    float narrator_time;
    float boy_time;
    float fov = 40;
    float time_btn;

    [Header("Time")]
    [SerializeField]  private float timeToReachTarget;
    [SerializeField] private float narratorTargetTime;
    [SerializeField] private float boyTargettime;

    [Header("scope_char")]
    [SerializeField] private GameObject scope_crew;
    [SerializeField] private GameObject scope_crew_rotate;

    [Header("Next Button")]
    [SerializeField] private GameObject NextBTN;
    [SerializeField] private float N0;
    [SerializeField] private float N1;
    [SerializeField] private float N2;
    [SerializeField] private float N3;
    [SerializeField] private float N4;
    [SerializeField] private float N5;
    [SerializeField] private float N6;
    [SerializeField] private float N7;
    [SerializeField] private float N8;
    [SerializeField] private float N9;
    [SerializeField] private float N10;
    [SerializeField] private float N11;

    [Header("Fade Panel")]
    [SerializeField] private Image Fade_Panel;
    [SerializeField] private float fadeTime = 3;

    [Header("panel")]
    [SerializeField] private GameObject panel_count_0;
    [SerializeField] private GameObject panel_count_1;
    [SerializeField] private GameObject panel_count_2;
    [SerializeField] private GameObject panel_count_3;
    [SerializeField] private GameObject panel_count_4;
    [SerializeField] private GameObject panel_count_5;
    [SerializeField] private GameObject panel_count_6;
    [SerializeField] private GameObject panel_count_7;
    [SerializeField] private GameObject panel_count_8;
    [SerializeField] private GameObject panel_count_9;
    [SerializeField] private GameObject panel_count_10;
    [SerializeField] private GameObject panel_count_11;


    [SerializeField] private Animator AJ;
    [SerializeField] private Animator G;
    [SerializeField] private Animator Capt;

    
    int color_a;
    [SerializeField] private Color colorToFadeTo;
    private void Start()
    {
        time_btn = N0;
        //colorToFadeTo = new Color32(40, 40, 40, 255);
    }
    void Update()
    {
        t += Time.deltaTime / timeToReachTarget;
        narrator_time += Time.deltaTime / narratorTargetTime;
        boy_time += Time.deltaTime / boyTargettime;
        time_btn -= Time.deltaTime;

        if(time_btn <= 0)
        {
            NextBTN.SetActive(true);
        }
        else
        {
            NextBTN.SetActive(false);
        }

        if(count == 0)
        {
            
            maincamera.transform.position = Vector3.Lerp(Starting.transform.localPosition, T1.transform.localPosition, narrator_time);
            maincamera.transform.rotation = Quaternion.Slerp(Starting.transform.rotation, T1.transform.localRotation, narrator_time);
            panel_count_0.SetActive(true);
        }
        if(count == 1)
        {
            panel_count_0.SetActive(false);
            panel_count_1.SetActive(true);

            maincamera.transform.position = Vector3.Lerp(T1.transform.localPosition, T2.transform.localPosition, t);
            maincamera.transform.rotation = Quaternion.Slerp(T1.transform.localRotation, T2.transform.localRotation, t);
            if(t >= timeToReachTarget)
            {
                Scope_Panel.SetActive(true);
            }
        }

        if (count == 2)
        {
            Scope_Panel.SetActive(false);
            scope_crew.transform.localRotation = Quaternion.Slerp(scope_crew.transform.localRotation, scope_crew_rotate.transform.localRotation, boy_time);
            maincamera.transform.position = Vector3.Lerp(T2.transform.localPosition, T3.transform.localPosition, t);
            maincamera.transform.rotation = Quaternion.Slerp(T2.transform.localRotation, T3.transform.localRotation, t);

            panel_count_1.SetActive(false);
            panel_count_2.SetActive(true);
        }
        if (count == 3)
        {
            
            maincamera.transform.position = Vector3.Lerp(T3.transform.localPosition, T4.transform.localPosition, t);
            maincamera.transform.rotation = Quaternion.Slerp(T3.transform.rotation, T4.transform.localRotation, t);

            panel_count_2.SetActive(false);
            panel_count_3.SetActive(true);
        }

        if (count == 4)
        {
            
            enemyship.SetDestination(target_location.transform.position);
            maincamera.transform.position = Vector3.Lerp(T4.transform.localPosition, T5.transform.localPosition, t);
            maincamera.transform.rotation = Quaternion.Slerp(T4.transform.rotation, T5.transform.localRotation, t);

            panel_count_3.SetActive(false);
            panel_count_4.SetActive(true);
        }

        if (count == 5)
        {

            
            maincamera.transform.position = Vector3.Lerp(T5.transform.localPosition, T6.transform.localPosition, t);
            maincamera.transform.rotation = Quaternion.Slerp(T5.transform.rotation, T6.transform.localRotation, t);

            panel_count_4.SetActive(false);
            panel_count_5.SetActive(true);
        }
        if (count == 6)
        {


            maincamera.transform.position = Vector3.Lerp(T6.transform.localPosition, T7.transform.localPosition, t);
            maincamera.transform.rotation = Quaternion.Slerp(T6.transform.rotation, T7.transform.localRotation, t);

            panel_count_5.SetActive(false);
            panel_count_6.SetActive(true);
        }
        if (count == 7)
        {
            fov -= .5f - Time.deltaTime;
            if (fov >= 12)
            {
                Camera.main.fieldOfView = fov;
            }

            panel_count_6.SetActive(false);
            panel_count_7.SetActive(true);

        }

        if(count == 8)
        {
            Camera.main.fieldOfView = 40;
            maincamera.transform.position = Vector3.Lerp(T7.transform.localPosition, T8.transform.localPosition, t);
            maincamera.transform.rotation = Quaternion.Slerp(T7.transform.rotation, T8.transform.localRotation, t);

            panel_count_7.SetActive(false);
            panel_count_8.SetActive(true);
        }

        if(count == 9)
        {
            maincamera.transform.LookAt(lookat_ship.transform);
            enemyship.SetDestination(sail_away.transform.position);

            panel_count_8.SetActive(false);
            panel_count_9.SetActive(true);
        }

        if(count == 10)
        {
            maincamera.transform.position = Vector3.Lerp(T8.transform.localPosition, T9.transform.localPosition, t);
            maincamera.transform.rotation = Quaternion.Slerp(T8.transform.rotation, T9.transform.localRotation, t);

            panel_count_9.SetActive(false);
            panel_count_10.SetActive(true);
        }
        if (count == 11)
        {
            maincamera.transform.position = Vector3.Lerp(T9.transform.localPosition, T10.transform.localPosition, t);
            maincamera.transform.rotation = Quaternion.Slerp(T9.transform.rotation, T10.transform.localRotation, t);

            panel_count_10.SetActive(false);
            panel_count_11.SetActive(true);
            
        }
        if(count == 12)
        {
            if(color_a < 255)
            {
                color_a++;
                Fade_Panel.color = new Color32(0, 0, 0, ((byte)color_a));
            }
            panel_count_11.SetActive(false);

        }
    }

    public void transition_BTN()
    {
        count++;
        t = 0;
        boy_time = 0;
        narrator_time = 0;
        
        if(count == 1)
        {
            time_btn = N1;
        }

        if (count == 2)
        {
            time_btn = N2;
        }

        if (count == 3)
        {
            Invoke("play_3", 1);
            time_btn = N3;
            
        }
        if (count == 4)
        {
            AJ.Play("1");
            G.Play("1");
            time_btn = 4;
            enemyship_object.transform.position = ship_newPos.transform.position;
        }

        if (count == 5)
        {

            Capt.Play("5");
            time_btn = N5;
        }

        if (count == 6)
        {
            Invoke("play_6", 1);
            time_btn = N6;
        }

        if (count == 7)
        {
            time_btn = N7;
        }

        if (count == 8)
        {
            Invoke("play_8", 1);
            time_btn = N8;
        }

        if (count == 9)
        {
            time_btn = N9;
            
        }

        if (count == 10)
        {
            Invoke("play_10", 1);
            time_btn = N10;
        }

        if (count == 11)
        {
            Invoke("play_11", 1);
            time_btn = N11;
        }
        if(count == 12)
        {
            Fade_Panel.CrossFadeColor(colorToFadeTo, fadeTime, true, true);
            time_btn = 60;
           
            Invoke("fade_to_next", 3f);

        }
    }
    

    void fade_to_next()
    {
        SceneManager.LoadScene("World_Map");
    }
    void play_3()
    {
        AJ.Play("3");
        G.Play("3");
    }
    void play_6()
    {
        AJ.Play("6");
        G.Play("6");
    }

    void play_8()
    {
        Capt.Play("8");
    }

    void play_10()
    {
        AJ.Play("10");
        G.Play("10");
    }

    void play_11()
    {
        AJ.Play("11");
        G.Play("11");
    }
}
