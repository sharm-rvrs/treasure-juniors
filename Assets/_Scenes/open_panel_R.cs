using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open_panel_R : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject object_to_active;


    public void open()
    {
        object_to_active.SetActive(true);
    }
}
