using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Account_monitoring_number : MonoBehaviour
{
    [SerializeField] private int account_number;
   public void Account()
    {
        PlayerPrefs.SetInt("account_is",account_number);
    }
}
