using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCarHealthManager : MonoBehaviour
{

    public static MonsterCarHealthManager instance;
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
    public void DamageMonsterCar()
    {
        currentHealth--;
        if (currentHealth <= 0)
        {
            Instantiate(explosion, transform.position, transform.rotation);
            gameObject.SetActive(false);
            carExplosion.Play();
            GameManager.instance.KillMonsterCar();
        }
    }
    public void Respawn()
    {
        gameObject.SetActive(true);
        currentHealth = maxHealth + 1;
    }
}
