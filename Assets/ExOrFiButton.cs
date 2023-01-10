using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ExOrFiButton : MonoBehaviour
{



    Button thisButton;
    public TimeText timeText;
    public Text leftTimesText;
    public int leftTimesCount = 2;

    private void Awake()
    {
        thisButton = GetComponent<Button>();
    }


    private void Start()
    {
        thisButton.onClick.AddListener(ClickThis);
    }



    void ClickThis()
    {

        if (transform.name== "ExtensionButton")
        {
            timeText.isCanTime = true;
            leftTimesCount--;
            leftTimesText.text = "LeftTimes:"+leftTimesCount.ToString();
            transform.parent.gameObject.SetActive(false);
        }
        else if (transform.name== "FinishedButton")
        {
            timeText.GameOver();
            transform.parent.gameObject.SetActive(false);
        }


    }
































}
