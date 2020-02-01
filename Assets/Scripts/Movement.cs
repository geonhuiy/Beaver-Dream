using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    private Camera mainCamera = null;
    private NavMeshAgent navMeshAgent = null;
    private void Awake() {
        mainCamera = Camera.main;
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update() {
        RaycastHit hit;
        foreach (Touch touch in Input.touches) {
            Ray ray = mainCamera.ScreenPointToRay(touch.position);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity)) {
                // Nav agent movement
                if (hit.transform.gameObject.layer == LayerMask.NameToLayer("Terrain")) {
                    navMeshAgent.SetDestination(hit.point);
                }
            }
        }
    }
}
