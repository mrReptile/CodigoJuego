using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPre;

    public float bulletForce = 20f;
    public bool shoot = false;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(5f);
        shoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1f && shoot)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
            }
        }
    }

    void Shoot()
    {
        Sounds.PlaySound("Fire_Sound");
        GameObject bullet = Instantiate(bulletPre, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
