using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public float AmountHealth;
    public float MaxHealth;
    public Canvas Image;
    
    public GameObject spawn;
    void Start()
    {
        Image.GetComponent<UImanager>().ChangehealthBar(AmountHealth, MaxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int value)
    {
        AmountHealth -= value;
        Image.GetComponent<UImanager>().ChangehealthBar(AmountHealth, MaxHealth);

        if (AmountHealth <= 0)
        {
            SceneManager.LoadScene("DeadScreen");
            this.gameObject.SetActive(false);
            spawn.gameObject.SetActive(false);
        }
    }
}
