using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Camera mainCamera = null;
    private void Awake() {
        mainCamera = Camera.main;
    }

    private void Update() {
        RaycastHit hit;
        foreach (Touch touch in Input.touches) {
            Ray ray = mainCamera.ScreenPointToRay(touch.position);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity)) {
                // Nav agent movement
            }
        }
    }
}
