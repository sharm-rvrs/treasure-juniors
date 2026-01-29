using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hide_last_island : MonoBehaviour
{
    // Start is called before the first frame update
    public void math_hide_last_island()
    {
        PlayerPrefs.SetInt("math_last_island", 0);
    }

    public void science_hide_last_island()
    {
        PlayerPrefs.SetInt("science_last_island", 0);
    }
}
