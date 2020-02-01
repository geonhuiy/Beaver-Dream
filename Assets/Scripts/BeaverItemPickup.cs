using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeaverItemPickup : MonoBehaviour
{
    private bool hasObject = false;
    private GameObject currentHeldObj;
    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    void OnTriggerEnter(Collider other)
    {
        hasObject = true;
        currentHeldObj = other.gameObject;
    }

    private void Update()
    {
        if (hasObject)
        {
            currentHeldObj.transform.position = this.transform.position;
            Vector3 rotation = new Vector3(currentHeldObj.transform.eulerAngles.x, this.transform.eulerAngles.y, currentHeldObj.transform.eulerAngles.z);
            currentHeldObj.transform.rotation = Quaternion.Euler(rotation);
        }
    }
}
