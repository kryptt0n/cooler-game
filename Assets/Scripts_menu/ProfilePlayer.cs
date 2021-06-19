using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfilePlayer : MonoBehaviour
{
    public InputField InputF;
    public string Name;
    public void start()
    {
        InputF = GameObject.FindGameObjectWithTag("name").GetComponent<InputField>();
        Name = GameObject.FindGameObjectWithTag("name").GetComponent<string>();

    }
    void Update()
    {
        Name = InputF.textComponent.text;
        DontDestroyOnLoad(InputF);
    }
}
