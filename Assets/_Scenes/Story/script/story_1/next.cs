using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class next : MonoBehaviour
{

    [SerializeField] private float Time = 3;
    [SerializeField] private GameObject NextBTN;
    [SerializeField] private GameObject Open_Next_Panel;
    private void OnEnable()
    {
        Invoke("nexT", Time);
    }

    void nexT()
    {
        NextBTN.SetActive(true);
    }

    public void To_next_Panel()
    {
        Open_Next_Panel.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
