using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Parent_Account_Name : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI parentname;
    [SerializeField] private TextMeshProUGUI parentname_first;
    [SerializeField] private TextMeshProUGUI parentname_Last;

    private void Update()
    {

        string b = PlayerPrefs.GetString("Parent_Name");
        parentname.text = b;
        parentname_first.text = PlayerPrefs.GetString("Parent_First");
        parentname_Last.text = PlayerPrefs.GetString("Parent_Last");
    }

}