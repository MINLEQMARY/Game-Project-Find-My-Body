using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{



    public GameObject winImage;
    public GameObject loseImage;
    public CollectController collectController;
    public static GameController Instance;
    public bool isTimeCanRun = true;
    public GameObject item1;
    public GameObject 右手手骨26;
    public PlayerController player;

    private void Awake()
    {
        Instance = this;
        isTimeCanRun = true;
    }

    public void SetGameWin()
    {
        player.GetComponent<AudioSource>().enabled = false;
        AudioController.Instance.PlayWinClip();
        isTimeCanRun = false;
        winImage.SetActive(true);
    }
    public void SetGameLose()
    {
        player.GetComponent<AudioSource>().enabled = false;
        AudioController.Instance.PlayLoseClip();
        loseImage.SetActive(true);
    }
    
    private void Update()
    {
     
        if (Input.GetMouseButtonDown(1))
        {
            RayThing();
        }
        
    }
    
    void RayThing()
    {
        Ray thisRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if (Physics.Raycast(thisRay, out hitInfo))
        {
            switch (hitInfo.transform.name)
            {
                case "1肉块":
                case "2臀肌":
                case "3肩胛骨":
                case "4肺":
                case "5肾":
                case "6胃":
                case "7胸骨":
                case "8脊柱":
                case "9脑":
                case "10血管":
                case "11锁骨":
                case "12人皮灯笼":
                case "13双腿大腿骨":
                case "14右小腿":
                case "15大小肠":
                case "16大腿肌":
                case "17头发":
                case "18头皮":
                case "19头骨":
                case "20左腿小腿骨":
                case "21左臂":
                case "22心脏":
                case "23指甲":
                case "24生殖器":
                case "25盆骨":
                    collectController.AddItem(hitInfo.transform.name);
                    Destroy(hitInfo.transform.gameObject);
                    
                    break;
                case "26右手手骨":
                    collectController.AddItem(hitInfo.transform.name);
                    Destroy(hitInfo.transform.gameObject);
                    Destroy(右手手骨26);
                    
                    break;



            }

        }
        
        
    }


    public void OpenEye()
    {
        collectController.AddItem("27眼球");
        Destroy(item1);
    }



}
