using UnityEngine;
using UnityEngine.UI;

public class PoolObject : MonoBehaviour, ISpawnEvent
{

    ObjectPool pool;
    public Text healthText;

    public GameObject dam;
    public float speed = 1f;
    public float direction = 1f;
	// Update is called once per frame
	void Update ()
    {

        Vector3 pos = this.transform.position;



        if (this.transform.position.x <= 9)
        {
            //pos.x += (speed + Random.Range(1f, 80f)) * Time.deltaTime * direction;

            pos.x += (speed) * Time.deltaTime * direction;
            transform.position = pos;
        }

        if (this.transform.position.y < -20)
        {
            pool.Despawn(this.gameObject);
        }



        //Debug.Log(damHealth);
    }

    private void OnTriggerEnter(Collider other)
    {
        pool.Despawn(this.gameObject);
    }

   



    public void OnSpawned(GameObject targetGameObject, ObjectPool sender)
    {
        pool = sender;
    }
}
