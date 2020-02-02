using System.Linq;
using UnityEngine;

public class Dam : MonoBehaviour
{
    public TextMesh healthText;

    public GameObject damNoDMG;
    public GameObject damLowDMG;
    public GameObject damHighDMG;
    public GameObject damDestroyed;

    public int lowDamage;
    public int mediumDamage;
    public int highDamage;
    public int lowHeal;
    public int mediumHeal;
    public int highHeal;



    public float damHealth = 500f;
   
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ontriggerenter");

        if (other.gameObject.tag == "Sphere")
        {
            damHealth -= lowDamage;
            Debug.Log("This is other Spere");
            healthText.color = Color.red;
        }
        if (other.gameObject.tag == "Cube")
        {
            damHealth -= lowDamage;
            Debug.Log("This is other Cube");
            healthText.color = Color.red;
        }
        if (other.gameObject.tag == "Tire")
        {
            damHealth -= mediumDamage;
            Debug.Log("This is other Cube");
            healthText.color = Color.red;
        }
        if (other.gameObject.tag == "Rock") {
            damHealth += highHeal;
            Destroy(other.gameObject);
            healthText.color = Color.green;
        }

        if (other.gameObject.tag == "Twig") {
            damHealth += lowHeal;
            Destroy(other.gameObject);
            healthText.color = Color.green;
        }

        //Debug.Log(damHealth);



        if (damHealth <= 0 )
        {
            damHealth = 0;
        }

        healthText.text = damHealth.ToString();




        if (damHealth >= 400)
        {
            damNoDMG.SetActive(true);
            damLowDMG.SetActive(false);
            damHighDMG.SetActive(false);
            damDestroyed.SetActive(false);
            Debug.Log("Health is " + damHealth);
        }
        if (Enumerable.Range(200, 390).Contains((int)damHealth))
        {
            damNoDMG.SetActive(false);
            damLowDMG.SetActive(true);
            damHighDMG.SetActive(false);
            damDestroyed.SetActive(false);
            Debug.Log("Health is " + damHealth);
        }
        if (Enumerable.Range(100, 190).Contains((int)damHealth))
        {
            damNoDMG.SetActive(false);
            damLowDMG.SetActive(false);
            damHighDMG.SetActive(true);
            damDestroyed.SetActive(false);
            Debug.Log("Health is " + damHealth);
        }
        if (damHealth <= 0)
        {
            damNoDMG.SetActive(false);
            damLowDMG.SetActive(false);
            damHighDMG.SetActive(false);
            damDestroyed.SetActive(true);
            Debug.Log("Health is " + damHealth);
        }
    }

    private void Update()
    {

        
        //difficultyTime = Time.deltaTime * difficultyTime;
        //Debug.Log(difficultyTime + "Difficulty time");
    }
}
