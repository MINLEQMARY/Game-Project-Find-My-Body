using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoY : MonoBehaviour
{


    public float roSpeed = 180;



    private void Update()
    {

        PlayerRoY();


    }


    void PlayerRoY()
    {

        //float mouseY = Input.GetAxis("Mouse Y");
        //if (mouseY!=0)
        //{
        //    transform.Rotate(Vector3.right * Time.deltaTime * roSpeed*mouseY,Space.Self);
        //}
        if (Input.GetKey(KeyCode.Mouse0))
        {
            float mouseY = Input.GetAxis("Mouse Y");
            if (mouseY != 0)
            {
                transform.Rotate(Vector3.right * Time.deltaTime * roSpeed * mouseY, Space.Self);
            }
        }
      



    }













}
