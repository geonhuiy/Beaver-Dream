using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewItemPickup : MonoBehaviour
{
    private bool hasObject = false;
    private GameObject currentHeldObj;
    private Transform heldObjTransform;
    private Transform beaverTransform;
    private Transform placeholderTransform;
    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Pickup")
        {
            hasObject = true;
            currentHeldObj = other.gameObject;
            other.collider.enabled = false;
            currentHeldObj.transform.position = this.transform.GetChild(0).transform.position;
            Debug.Log("aaa");
        }
    }

    private void Update()
    {
        /*if (hasObject)
        {
            currentHeldObj.transform.position = this.transform.position;
            Vector3 rotation = new Vector3(currentHeldObj.transform.eulerAngles.x, this.transform.eulerAngles.y, currentHeldObj.transform.eulerAngles.z);
            currentHeldObj.transform.rotation = Quaternion.Euler(rotation);
        }*/
    }
}
