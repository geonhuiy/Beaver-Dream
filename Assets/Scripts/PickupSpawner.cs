using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    public static PickupSpawner instance;
    [SerializeField]
    private GameObject[] pickupPool;
    public int maxItemCount;
    public int currentItemCount;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
        DontDestroyOnLoad(this);
    }
    void Start()
    {
        maxItemCount = 20;
        for (int i = 0; i <= maxItemCount; i++)
        {
            int randObject = Random.Range(0, 6);
            Instantiate(pickupPool[randObject], new Vector3(Random.Range(-32, 32), 2, Random.Range(-32, 32)), pickupPool[randObject].transform.rotation);
        }
        currentItemCount = maxItemCount;
    }

    private void Update()
    {
        int spawnCount = maxItemCount - currentItemCount;
        if (currentItemCount < maxItemCount)
        {
            int randObject = Random.Range(0, 6);
            Instantiate(pickupPool[randObject], new Vector3(Random.Range(-32, 32), 10, Random.Range(-32, 32)), pickupPool[randObject].transform.rotation);
            currentItemCount += currentItemCount;
        }
    }


}
