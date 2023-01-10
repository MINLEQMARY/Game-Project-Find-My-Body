using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PosButton : MonoBehaviour
{



    Button thisButton;
    Transform playerTrans;
    Transform allPos;

    private void Awake()
    {
        thisButton = GetComponent<Button>();
        playerTrans = GameObject.FindGameObjectWithTag("Player").transform;
        allPos = GameObject.FindGameObjectWithTag("AllPos").transform;
    }


    private void Start()
    {
        thisButton.onClick.AddListener(ClickThisButton);
    }



    void ClickThisButton()
    {

        playerTrans.position = allPos.Find(transform.name).position;


    }





























}
