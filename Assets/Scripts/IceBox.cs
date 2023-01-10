using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBox : MonoBehaviour
{




    public float rotateSpeed = 90;
    public bool isIceOpened = false;
    public bool isCanPressKey = true;
    public Transform iceBoxUp1;
    public Transform iceBoxUp2;
    public Transform iceBoxDown1;
    public Transform iceBoxDown2;


    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            //PlayerClickMouse();
        }
        

    }

    public void PlayerClickMouse()
    {
        isIceOpened = !isIceOpened;

        if (isIceOpened)
        {
            OpenIceBox();
        }
        else
        {
            CloseIceBox();
        }
        

    }


    void OpenIceBox()
    {

        Debug.Log("开门");
        StartCoroutine(OpenIceBoxI());
        
    }


    IEnumerator OpenIceBoxI()
    {

        isCanPressKey = false;
        for (float i = 0; i < 1.1f; i += Time.deltaTime)
        {

            iceBoxUp1.Rotate(Vector3.forward, rotateSpeed * Time.deltaTime);
            iceBoxDown1.Rotate(Vector3.forward, rotateSpeed * Time.deltaTime);
            iceBoxUp2.Rotate(Vector3.forward, -rotateSpeed * Time.deltaTime);
            iceBoxDown2.Rotate(Vector3.forward, -rotateSpeed * Time.deltaTime);
            //transform.Rotate(Vector3.forward, rotateSpeed * Time.deltaTime);
            yield return new WaitForSeconds(0);

        }
        isCanPressKey = true;

    }



    void CloseIceBox()
    {

        Debug.Log("关门");
        StartCoroutine(CloseIceBoxI());

    }



    IEnumerator CloseIceBoxI()
    {
        isCanPressKey = false;
        for (float i = 0; i < 1.1f; i += Time.deltaTime)
        {


            iceBoxUp1.Rotate(Vector3.forward, -rotateSpeed * Time.deltaTime);
            iceBoxDown1.Rotate(Vector3.forward, -rotateSpeed * Time.deltaTime);
            iceBoxUp2.Rotate(Vector3.forward, rotateSpeed * Time.deltaTime);
            iceBoxDown2.Rotate(Vector3.forward, rotateSpeed * Time.deltaTime);
            //transform.Rotate(Vector3.forward, -rotateSpeed * Time.deltaTime);
            yield return new WaitForSeconds(0);

        }
        isCanPressKey = true;

    }

























}
