using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redhorse : MonoBehaviour
{
    [SerializeField] private GameObject PanelAchievement;

    [SerializeField] private GameObject PanelKey;
    [SerializeField] private GameObject Key;
    [SerializeField] private GameObject Key2;
    int a = 0;
    private void Start()
    {
        if (PanelAchievement.activeInHierarchy == true && PanelKey.activeInHierarchy == true)
        {
            PanelKey.SetActive(false);
            Key.SetActive(false);
            Key2.SetActive(false);
            a = 1;
        }
    }
    public void Close_Panel_sc()
    {
        if (a == 1)
        {
            PanelAchievement.SetActive(false);
            PanelKey.SetActive(true);
            Key.SetActive(true);
            Key2.SetActive(true);
        }
        else
        {
            PanelAchievement.SetActive(false);
        }

    }
}
