using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC_Subject_Panel : MonoBehaviour
{
    [SerializeField] private GameObject Math_Panel;
    [SerializeField] private GameObject Science_Panel;

    [SerializeField] private GameObject Monitoring_Panel;
    

    public void PC_Math_Panel()
    {
        Math_Panel.SetActive(true);
        Science_Panel.SetActive(false);
        Monitoring_Panel.SetActive(false);
    }

    public void PC_Science_Panel()
    {
        Math_Panel.SetActive(false);
        Science_Panel.SetActive(true);
        Monitoring_Panel.SetActive(false);
    }

    public void Back_To_PC_Subject()
    {
        
        Math_Panel.SetActive(false);
        Science_Panel.SetActive(false);
        Monitoring_Panel.SetActive(true);
    }
}
