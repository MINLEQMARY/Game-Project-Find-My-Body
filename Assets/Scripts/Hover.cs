using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Hover : MonoBehaviour, IPointerEnterHandler
{


    Image thisImage;
    void Awake()
    {
        thisImage = GetComponent<Image>();

    }


    public void OnPointerEnter(PointerEventData eventData)
    {

        GameObject[] allButtons = GameObject.FindGameObjectsWithTag("Button");
        for (int i = 0; i < allButtons.Length; i++)
        {
            allButtons[i].GetComponent<Image>().color=new Color(1,1,1,0);
        }
        thisImage.color = new Color(1,1,1,1);



    }



}
