using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuestionLogic : MonoBehaviour
{
    public Button button;

    private void Awake()
    {
        button = GetComponent<Button>();
    }
    public void PrintComponents(Button button)
    {
        if (button.gameObject.GetComponentInChildren<Text>().text == "Ответ 2")
        {
            button.gameObject.GetComponent<Image>().color = Color.green;
        } else
        {
            button.gameObject.GetComponent<Image>().color = Color.red;
        }

        
    }

}
