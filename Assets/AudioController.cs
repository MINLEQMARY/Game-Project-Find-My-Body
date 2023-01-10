using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{



    public static AudioController Instance;
    GameObject audio1;
    GameObject audio2;
    GameObject audio3;
    private void Awake()
    {
        Instance = this;
        audio1 = transform.GetChild(0).gameObject;
        audio2 = transform.GetChild(1).gameObject;
        audio3 = transform.GetChild(2).gameObject;
        
    }


    public void PlayWinClip()
    {

        audio1.SetActive(true);

    }


    public void PlayLoseClip()
    {

        audio2.SetActive(true);

    }

    public void PlayClockClip()
    {

        audio3.SetActive(true);

    }





























}
