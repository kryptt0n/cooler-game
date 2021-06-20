using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuestionLogic : MonoBehaviour
{
    public Button button;
    public static bool isClicable = true;
    private GameObject QCanvas;
    private GameObject[] Buttons;
    private void Awake()
    {
        QCanvas = GameObject.Find("Question Canvas");
        button = GetComponent<Button>();
        Buttons = GameObject.FindGameObjectsWithTag("Answer");
    }

    private void Update()
    {
        if(QCanvas.activeSelf)
        {
            isClicable = false;
        }
    }


    public void CheckAnswer(Button button)
    {
        
        if (button.gameObject.GetComponentInChildren<Text>().text == "Ответ 2")
        {
            button.gameObject.GetComponent<Image>().color = Color.green;
            TileMapClicker.isRightAnswer = true;
        }
            
        else
        {
            button.gameObject.GetComponent<Image>().color = Color.red;
            TileMapClicker.isRightAnswer = false;
        }
           
        

        StartCoroutine("QuestionCourotine", button);
        isClicable = true;
    }

    IEnumerator QuestionCourotine(Button button)
    {
        foreach (GameObject button1 in Buttons) {
            button1.GetComponent<Button>().interactable = false;
        }
        yield return new WaitForSeconds(3);
        isClicable = true;
        foreach (GameObject button1 in Buttons)
        {
            button1.GetComponent<Button>().interactable = true;
        }
        button.gameObject.GetComponent<Image>().color = Color.white;
        QCanvas.SetActive(false);    
    }

}
