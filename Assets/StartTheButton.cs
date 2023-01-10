using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTheButton : MonoBehaviour
{



    public float startTime = 2;
    public GameObject restartButton;
    public GameObject returnButton;


    private void Start()
    {

        Invoke("StartThis", startTime);

    }




    void StartThis()
    {

        restartButton.SetActive(true);
        returnButton.SetActive(true);
    }
























}
