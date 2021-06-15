using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{

    public static HealthManager instance;
    public int currentHealth;
    public int maxHealth;
    public GameObject explosion;
    public AudioSource carExplosion;
    public void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        currentHealth = maxHealth;
    }
    public void DamagePlayer()
    {
        currentHealth--;
        if (currentHealth <= 0)
        {
            Instantiate(explosion,transform.position, transform.rotation);
            gameObject.SetActive(false);
            carExplosion.Play();
            GameManager.instance.KillPlayer();
        }
    }
    public void Respawn()
    {
        gameObject.SetActive(true);
        currentHealth = maxHealth+1;
    }
}
