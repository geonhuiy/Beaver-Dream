using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnorePickupCollider : MonoBehaviour
{
    /// <summary>
    /// Sent when an incoming collider makes contact with this object's
    /// collider (2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>
    void OnCollisionEnter(Collision other)
    {
        
    }
}
