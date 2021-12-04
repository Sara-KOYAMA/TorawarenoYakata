using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Event_4 : MonoBehaviour
{
    public string[] texts;
    int textNumber;
    string displayText;
    int textCharNumber;
    int displayTextSpeed;
    bool click;
    bool textStop;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (textStop == false)
        {
            displayTextSpeed++;
            if (displayTextSpeed % 5 == 0)
            {

                if (textCharNumber != texts[textNumber].Length)
                {
                    displayText = displayText + texts[textNumber][textCharNumber];
                    textCharNumber = textCharNumber + 1;
                }
                else
                {
                    if (textNumber != texts.Length - 1)
                    {
                        if (click == true)
                        {
                            displayText = "";
                            textCharNumber = 0;
                            textNumber = textNumber + 1;
                        }
                    }
                    else
                    {
                        if (click == true)
                        {
                            displayText = "";
                            textCharNumber = 0;
                            textStop = true;
                            SceneManager.LoadScene("Stage3");
                        }
                    }
                }

                this.GetComponent<Text>().text = displayText;
                click = false;
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                click = true;
            }
        }
    }
}

