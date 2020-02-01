using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    [SerializeField]
    private bool hasObject = false;
    private Collider currentCollider;
    void OnTriggerEnter(Collider other)
    {
        // Debug.Log("Beaver");
        currentCollider = other;
        hasObject = true;
        // this.gameObject = other.gameObject;
    }

    private void Update()
    {
        if (hasObject)
        {
            //this.gameObject.transform.localScale = new Vector3(5,5,5);
            this.gameObject.transform.position = currentCollider.gameObject.transform.position;
        }
    }
}
