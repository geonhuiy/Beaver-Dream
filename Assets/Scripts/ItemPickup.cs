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
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Beaver");
    }

    private void Update()
    {

    }
}
