using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopShoot : MonoBehaviour
{
    public float radius;
    bool located = false;
    public Transform target;
    Vector2 Direction;
    public GameObject cop;
    private float nextShot = 0;
    public float fireRate;
    public GameObject bullet;
    public float force;
    public Transform pointOfShot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 targetPos = target.position;
        Direction = targetPos - (Vector2)transform.position;
        RaycastHit2D rayInfo = Physics2D.Raycast(transform.position, Direction, radius);

        if (rayInfo)
        {
            if (rayInfo.collider.gameObject.tag == "Player")
            {
                if (located == false)
                {
                    located = true;
                }
            }
            else
            {
                if (located == true)
                {
                    located = false;
                }
            }
        }
        if (located)
        {
            cop.transform.up = Direction;
            if (Time.time > nextShot)
            {
                nextShot = Time.time + 1 / fireRate;
                ShootBullet();
            }
        }
    }
    void ShootBullet()
    {
        GameObject BulletIns = Instantiate(bullet, pointOfShot.position, Quaternion.identity);
        BulletIns.GetComponent<Rigidbody2D>().AddForce(Direction * force);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
