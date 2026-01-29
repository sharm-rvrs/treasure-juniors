using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_Close_Object : MonoBehaviour
{
    [SerializeField] private GameObject object_to_close;

    public void close()
    {
        object_to_close.SetActive(false);
    }
}
