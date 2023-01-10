using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeText : MonoBehaviour
{



    Text thisText;
    
    float timeCount = 60;
    public Image fillImage;
    public int delayTimes = 0;
    public float fullTimeCount = 60;
    public GameObject clockTimeImage;
    public bool isCanTime = true;
    AudioSource clockAudio;

    private void Awake()
    {
        thisText = GetComponent<Text>();
        clockAudio = GetComponent<AudioSource>();
    }

    private void Start()
    {
        timeCount = fullTimeCount;
    }

    private void Update()
    {

        UpdateText();
        
    }



    void UpdateText()
    {
        if (GameController.Instance.isTimeCanRun==false)
        {
            return;
        }
        if (isCanTime==false)
        {
            return;
        }
        timeCount -= Time.deltaTime;
        if (timeCount<=0)
        {

            delayTimes++;
            if (delayTimes <= 2)
            {
                clockTimeImage.SetActive(true);
                isCanTime = false;
                timeCount = fullTimeCount;
                clockAudio.enabled = true;
                Invoke("ClockOver",3);
            }
            else
            {
                GameController.Instance.SetGameLose();
                thisText.text = "0:0";
                fillImage.fillAmount = 0;
                return;
            }
            
        }
        float thisTimeCount = timeCount;
        float minCount = (int)thisTimeCount / 60;
        int secCount = (int)thisTimeCount % 60;
        //thisText.text = "Time" + " " + minCount.ToString() + ":" + secCount.ToString();
        thisText.text = minCount.ToString() + ":" + secCount.ToString();
        fillImage.fillAmount = timeCount / fullTimeCount;
    }




    void ClockOver()
    {
        clockAudio.enabled = false;

    }



    public void GameOver()
    {

        GameController.Instance.SetGameLose();
        thisText.text = "0:0";
        fillImage.fillAmount = 0;

    }











}
