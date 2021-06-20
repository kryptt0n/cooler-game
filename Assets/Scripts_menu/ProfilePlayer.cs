using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfilePlayer : MonoBehaviour
{
    public InputField InputF;
    public string Name;
    void Awake()
    {
        InputF = GameObject.FindGameObjectWithTag("name").GetComponent<InputField>();
        GameObject.FindGameObjectWithTag("name").GetComponent<Text>().text = StaticVariables.Nickname;
    }
}