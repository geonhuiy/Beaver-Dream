using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManagerInstance;
    public GameObject beaver;
    public bool hasObject = false;
    void Awake() {
        if (gameManagerInstance == null) {
            gameManagerInstance = this;
        }
        else {
            Destroy(this);
        }
        DontDestroyOnLoad(this);
    }

    private void Update() {  

    }
}
