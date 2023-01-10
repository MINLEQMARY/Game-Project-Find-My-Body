using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWin : MonoBehaviour
{



    private void Update()
    {
        if (transform.childCount==0)
        {
            GameController.Instance.SetGameWin();
        }
    }
























}
