using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class super_magic_mega_script : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private GameObject back_BTN;
    [SerializeField] private string first;
    [SerializeField] private string second;

    private void Update()
    {
        if(back_BTN.activeInHierarchy == true)
        {
            text.text = second;
        }
        else
        {
            text.text = first;
        }
    }
}
