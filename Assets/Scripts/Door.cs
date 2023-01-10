using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum DoorType
{
    NomalDoor,
    AnotherDoor

}
public class Door : MonoBehaviour
{



    public float rotateSpeed = 90;
    public bool isDoorOpened = false;
    public bool isCanPressKey = true;
    public DoorType thisDoorType = DoorType.NomalDoor;


    private void Update()
    {
        if (isCanPressKey==false)
        {
            return;
        }
        

    }

    public void PlayerPressedF()
    {

        isDoorOpened = !isDoorOpened;

        if (isDoorOpened)
        {
            OpenDoor();
        }
        else
        {
            CloseDoor();
        }

    }
    

    void OpenDoor()
    {
        Debug.Log("开门");
        StartCoroutine(OpenDoorI());
        

    }


    IEnumerator OpenDoorI() {

        isCanPressKey = false;
        for (float i = 0; i < 1.1f; i+=Time.deltaTime)
        {
            
            if (thisDoorType == DoorType.NomalDoor)
            {
                transform.Rotate(Vector3.forward, rotateSpeed * Time.deltaTime);
            }
            else
            {
                transform.Rotate(Vector3.right, rotateSpeed * Time.deltaTime);
            }
            
            yield return new WaitForSeconds(0);

        }
        isCanPressKey = true;

    }



    void CloseDoor() {

        Debug.Log("关门");
        StartCoroutine(CloseDoorI());

    }



    IEnumerator CloseDoorI()
    {
        isCanPressKey = false;
        for (float i = 0; i < 1.1f; i += Time.deltaTime)
        {
            if (thisDoorType == DoorType.NomalDoor)
            {
                transform.Rotate(Vector3.forward, -rotateSpeed * Time.deltaTime);
            }
            else
            {
                transform.Rotate(Vector3.right, -rotateSpeed * Time.deltaTime);
            }
            yield return new WaitForSeconds(0);

        }
        isCanPressKey = true;

    }


















}
