using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{



    public float moveSpeed = 5;
    public float roSpeed = 180;
    public float jumpSpeed = 300;
    Rigidbody thisRig;
    bool isCanPressF = false;
    public GameObject fText;
    Collider thisCol;
    

    private void Awake()
    {
        thisRig = GetComponent<Rigidbody>();
    }

    public void Stop()
    {
        //GetComponent<NavMeshAgent>().isStopped = true;
    }
    private void Update()
    {

        PlayerMove();
        //PlayerRoX();
        //PlayerJump();
        playerRotateByMouseDown();
        if (isCanPressF)
        {
            fText.SetActive(true);
            if (Input.GetMouseButtonDown(1))
            {
                fText.SetActive(false);
                thisCol.GetComponent<Door>().PlayerPressedF();
            }
            
        }
        else
        {
            fText.SetActive(false);
        }

        if (Input.GetMouseButtonDown(1))
        {
            RayIceBox();
        }
        if (Input.GetMouseButtonDown(0))
        {
            RayNextPos();
        }
        if (Input.GetMouseButton(0))
        {
            //RayMove();
        }
        


    }


    void RayMove()
    {
        Ray thisRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(thisRay, out hitInfo))
        {
            Vector3 targetPos = new Vector3(hitInfo.point.x,
                transform.position.y,
                hitInfo.point.z);
            Vector3 moveDir = targetPos - transform.position;
            
            transform.Translate(moveDir.normalized * moveSpeed * Time.deltaTime);
            

            
        }

    }

    void RayNextPos()
    {

        Ray thisRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(thisRay, out hitInfo))
        {
            print(hitInfo.transform.name);
            if (hitInfo.transform.tag == "MovePos")
            {

                transform.position = hitInfo.transform.position;
            }
        }

    }


    void RayIceBox()
    {
        Ray thisRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(thisRay,out hitInfo))
        {
            
            if (hitInfo.transform.tag=="IceBox")
            {
                
                hitInfo.transform.GetComponent<IceBox>().PlayerClickMouse();
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag=="Door")
        {
            isCanPressF = true;
            thisCol = other;
        }

    }
    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Door")
        {
            isCanPressF = false;
            thisCol = null;
        }

    }

    void PlayerMove() {

        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        if (hor!=0||ver!=0)
        {
            transform.Translate(new Vector3(hor,0,ver)*Time.deltaTime*moveSpeed);
        }


    }


    void PlayerRoX()
    {

        float mouseX = Input.GetAxis("Mouse X");
        if (mouseX != 0)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * roSpeed * mouseX);
        }
        

    }




    void PlayerJump()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Mathf.Abs(thisRig.velocity.y)<0.1f)
            {
                thisRig.AddForce(Vector3.up*jumpSpeed);
            }
        }


    }
    public void playerRotateByMouseDown()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            float mouseX = Input.GetAxis("Mouse X");
            if (mouseX != 0)
            {
                transform.Rotate(Vector3.up * Time.deltaTime * roSpeed * mouseX);
            }
        }
    }
    

    public void SetMoveTo(Vector3 targetPos)
    {
        
        transform.position = targetPos;
    }
















}
