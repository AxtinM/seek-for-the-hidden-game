using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{

    [SerializeField]
    private Camera cam;

    private bool inRange;

    private bool pickedUp = false;

    public InventoryController inventory;


    private void Update()
    {
         
        if (Input.GetKey(KeyCode.E) & inRange)
        {
            pickup();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
       if(other.tag == "Player" && !pickedUp)
        {
            Debug.Log("Player entered");
            inRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
            inRange = false;
    }

    private void pickup()
    {
        bool isCameraPointingAtObject = CamIsPointingAtObject();
        if(isCameraPointingAtObject)
        {
            inventory.PutInInventory(gameObject);
            Destroy(gameObject);
        }
    }

   private bool CamIsPointingAtObject()
    {
        Vector3 cameraLookDirection = cam.transform.forward;

        Vector3 directionToObject = gameObject.transform.position - cam.transform.position;

        return Vector3.Dot(cameraLookDirection, directionToObject) > 0;
    }


}
