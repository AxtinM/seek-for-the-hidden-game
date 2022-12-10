using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    private ArrayList items;
    public Pickable[] itemsToCollect;
    // Start is called before the first frame update
    void Start()
    {
        items = new ArrayList();
        itemsToCollect = FindObjectsOfType<Pickable>();
        Debug.Log("Object's name : " + itemsToCollect[0].objName);
    }

     void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log(items.Count);
        }
    }

    public void ClearInventory()
    {
        items.Clear();
    }

    public void PutInInventory(GameObject obj) 
    {
        items.Add(obj);
    }

}
