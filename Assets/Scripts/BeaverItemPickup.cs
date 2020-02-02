using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeaverItemPickup : MonoBehaviour
{
    private bool hasObject = false;
    private GameObject currentHeldObj;
    void OnCollisionEnter(Collision other)
    {
        hasObject = true;
        currentHeldObj = other.gameObject;
        //objTransform.transform.parent = transform;
        //objTransform.transform.position = holdSlot.transform.position;
    }

    private void Update()
    {
        if (currentHeldObj != null)
        {
            if (hasObject)
            {
                currentHeldObj.transform.position = this.gameObject.transform.GetChild(0).transform.position;
                Vector3 rotation = new Vector3(currentHeldObj.transform.eulerAngles.x, this.transform.eulerAngles.y, currentHeldObj.transform.eulerAngles.z);
                currentHeldObj.transform.rotation = Quaternion.Euler(rotation);
                //currentHeldObj.GetComponent<Collider>().enabled = false;
            }
        }

    }
}
