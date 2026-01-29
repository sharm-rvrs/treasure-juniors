using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close_Panel : MonoBehaviour
{
    [SerializeField] private GameObject Panel;
    public void Close_Panel_sc()
    {
        Panel.SetActive(false);
    }
}
