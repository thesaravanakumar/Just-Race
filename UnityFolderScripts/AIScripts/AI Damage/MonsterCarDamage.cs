using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCarDamage : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D other)   //if we collide with police car
    {
        if (other.gameObject.tag == "Player")
        {
            MonsterCarHealthManager.instance.DamageMonsterCar();
        }
    }
}
