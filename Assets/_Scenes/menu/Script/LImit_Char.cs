using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class LImit_Char : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_InputField mainInputField;
    public string playerName;
    string last = string.Empty;

    [SerializeField] private string special_Char1;
    [SerializeField] private string special_Char2;
    void Update()
    {

        mainInputField.characterLimit = playerName.Length;

    }

    public void UpdateField()
    {
        string text = mainInputField.text;
        text = text.Replace("!", "");
        text = text.Replace("@", "");
        text = text.Replace("#", "");
        text = text.Replace("$", "");
        text = text.Replace("%", "");
        text = text.Replace("^", "");
        text = text.Replace("&", "");
        text = text.Replace("*", "");
        text = text.Replace("(", "");
        text = text.Replace(")", "");
        text = text.Replace("-", "");
        text = text.Replace("_", "");
        text = text.Replace("+", "");
        text = text.Replace("=", "");
        text = text.Replace("[", "");
        text = text.Replace("]", "");
        text = text.Replace("{", "");
        text = text.Replace("}", "");
        text = text.Replace("|", "");
        text = text.Replace(";", "");
        text = text.Replace(":", "");
        text = text.Replace("'", "");
        text = text.Replace(",", "");
        text = text.Replace("<", "");
        text = text.Replace(".", "");
        text = text.Replace(">", "");
        text = text.Replace("?", "");
        text = text.Replace("0", "");
        text = text.Replace("1", "");
        text = text.Replace("2", "");
        text = text.Replace("3", "");
        text = text.Replace("4", "");
        text = text.Replace("5", "");
        text = text.Replace("6", "");
        text = text.Replace("7", "");
        text = text.Replace("8", "");
        text = text.Replace("9", "");
        text = text.Replace(special_Char1, "");
        text = text.Replace(special_Char2, "");



        mainInputField.text = text;
    }
}
