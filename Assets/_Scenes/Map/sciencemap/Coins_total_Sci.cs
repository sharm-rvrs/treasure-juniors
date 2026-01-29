using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coins_total_Sci : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Coins_Text;
    int User_ID;

    int map1;
    int map2;
    int map3;


    int total_map_score;

    // Start is called before the first frame update
    void Start()
    {
        User_ID = PlayerPrefs.GetInt("account_is");
        string user_id = User_ID.ToString();

        map1 = PlayerPrefs.GetInt(user_id + "_Total_Coins_science_1");
        map2 = PlayerPrefs.GetInt(user_id + "_Total_Coins_science_2");
        map3 = PlayerPrefs.GetInt(user_id + "_Total_Coins_science_3");


        total_map_score = map1 + map2 + map3;

        Coins_Text.text = total_map_score.ToString();
    }

}
