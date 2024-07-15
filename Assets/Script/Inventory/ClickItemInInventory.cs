using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickItemInInventory : MonoBehaviour
{
    public GameObject thisItem;
    public GameObject hold;
    public InventoryManager invManager;

    public StoreToInventory itemSO;

    void awake()
    {
        hold = GameObject.Find("Hold Area");
    }

    void Start()
    {
        hold = GameObject.Find("Hold Area");
        invManager = GameObject.Find("InventoryManager").GetComponent<InventoryManager>();
    }

    public void FetchItem()
    {
        if (hold.transform.childCount != 1)
        {
            thisItem = gameObject.transform.GetChild(2).gameObject;
            //UnityEngine.Debug.Log(thisItem.name);
            thisItem.SetActive(true);

            Rigidbody itemRb = thisItem.GetComponent<Rigidbody>();
            itemRb.isKinematic = true;

            thisItem.transform.SetParent(hold.transform);
            thisItem.transform.localPosition = Vector3.zero;

            StoreToInventory itemSO = thisItem.GetComponent<StoreToInventory>();
            ItemsSO itemSOtoDelete = itemSO.item;
            invManager.DeleteItem(itemSOtoDelete);
            
            Destroy(gameObject);
        }

    }
}

/*
             //GameObject itemPhysical = Instantiate(itemObject.transform.GetChild(itemObject.transform.childCount - 1).gameObject);
            //StoreToInventory itemSO = itemPhysical.GetComponent<StoreToInventory>();
            //ItemsSO itemSOtoDelete = itemSO.item;
            //DeleteItem(itemSOtoDelete);
 
 */