using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart : MonoBehaviour
{
    public float startingHealth;
    public float currentHealth;
    private Animation anim;
    private bool dead = false;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) ;
        {
            TakeDamage(1);
        }
       
    }
    public void TakeDamage(float _damege)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damege, 0, startingHealth);

        if(currentHealth > 0)
        {

        }
        if (currentHealth <= 0)
        {
            dead = true;
            GetComponent<plaerkotroler>().enabled = false;
        }
      

    }
    public void AddHealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);



    }
}

  
