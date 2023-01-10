using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CollectController : MonoBehaviour
{



    Image[] itemArray;



    private void Awake()
    {
        itemArray = new Image[transform.childCount];
    }

    private void Start()
    {
        for (int i = 0; i < itemArray.Length; i++)
        {
            itemArray[i] = transform.GetChild(i).GetChild(0).GetComponent<Image>();
        }
    }


    public void AddItem(string itemStr)
    {

        for (int i = 0; i < itemArray.Length; i++)
        {
            if (itemArray[i].sprite==null)
            {
                itemArray[i].color = Color.white;
                itemArray[i].sprite = Resources.Load<Sprite>("Items/" + itemStr);
                break;
            }
        }


    }






















}
