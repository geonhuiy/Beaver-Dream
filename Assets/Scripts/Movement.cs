using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    private Camera mainCamera = null;
    private NavMeshAgent navMeshAgent = null;

    private void Awake()
    {
        mainCamera = Camera.main;
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.updateRotation = false;

    }
    /// <summary>
    /// LateUpdate is called every frame, if the Behaviour is enabled.
    /// It is called after all Update functions have been called.
    /// </summary>
    void LateUpdate()
    {
        transform.rotation = Quaternion.LookRotation(navMeshAgent.velocity.normalized);
    }
    private void Update()
    {
        RaycastHit hit;
        // Touch input on mobile devices
        foreach (Touch touch in Input.touches) {
            Ray ray = mainCamera.ScreenPointToRay(touch.position);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity)) {
                // Nav agent movement
                if (hit.transform.gameObject.layer == LayerMask.NameToLayer("Terrain")) {
                    navMeshAgent.SetDestination(hit.point);
                }
            }
        }

        // Mouse input on computer for debugging
        /*if (Input.GetMouseButtonUp(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.transform.gameObject.layer == LayerMask.NameToLayer("Terrain")
                || hit.transform.gameObject.layer == LayerMask.NameToLayer("Pickup"))
                {
                    navMeshAgent.SetDestination(hit.point);
                }
            }
        }*/
    }
}
