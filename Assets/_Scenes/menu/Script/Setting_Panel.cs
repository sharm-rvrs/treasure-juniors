using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting_Panel : MonoBehaviour
{
    [SerializeField] private GameObject Settings;
    public void Setting_on()
    {
        Settings.SetActive(true);
    }

    public void Setting_off()
    {
        Settings.SetActive(false);
    }
}
