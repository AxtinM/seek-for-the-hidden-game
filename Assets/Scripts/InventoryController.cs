using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    private ArrayList items;
    // Start is called before the first frame update
    void Start()
    {
        items = new ArrayList();
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
