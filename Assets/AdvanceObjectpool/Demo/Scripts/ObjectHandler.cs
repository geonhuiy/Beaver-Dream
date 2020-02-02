using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHandler : MonoBehaviour
{


    float objectNumber = 0.1f;
    //Timer t = new Timer();


    public float seconds = 1.0f;


    DictionaryObjectPool _objectpool;


    [SerializeField]
    GameObject[] gos;
    float time = 1.0f;
    public float numberstospawn = 1.0f;
	// Use this for initialization


	void Start ()
    {



        _objectpool = new DictionaryObjectPool();
        _objectpool.AddObjectPool("squares", gos[0], this.transform, 100);
        _objectpool.AddObjectPool("spheres", gos[1], this.transform, 100);
        _objectpool.AddObjectPool("tires", gos[2], this.transform, 100);
    }

    // Update is called once per frame
    void Update ()
    {


        numberstospawn += objectNumber * Time.smoothDeltaTime;
        //Debug.Log("NuberSpawn" + numberstospawn);
        //numberstospawn = numberstospawn * (int)t.secondsCount;
        Vector3 pos = new Vector3(Random.Range(-30, -45), 1, Random.Range(-4,4));
        if (_objectpool["spheres"].Count < numberstospawn)
        {
            _objectpool["spheres"].Spawn(pos);
        }
        if (_objectpool["squares"].Count < numberstospawn)
        {
            _objectpool["squares"].Spawn(pos);
        }
        if (_objectpool["tires"].Count < numberstospawn)
        {
            _objectpool["tires"].Spawn(pos);
        }
    }
}
