using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ClickBack : MonoBehaviour
{



    Button thisButton;

    private void Awake()
    {
        thisButton = GetComponent<Button>();
    }
    

    private void Update()
    {
        
        if (Input.GetMouseButtonDown(1))
        {
            ClickThis();

        }
    }

    void ClickThis()
    {

        gameObject.SetActive(false);
        GameController.Instance.OpenEye();

    }





































}
