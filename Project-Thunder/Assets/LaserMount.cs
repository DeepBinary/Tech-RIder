using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMount : MonoBehaviour
{
    public GameObject player;
    public GameObject bullet;
    public float Firerate;
    float nextfire;
    // Start is called before the first frame update
    void Start()
    {
        nextfire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfTimeToFire();
    }   

    public void CheckIfTimeToFire()
    {
        if (Time.time > nextfire)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            bullet.GetComponent<Laser>().targetpos = player.transform;
            nextfire = Time.time + Firerate;
        }
    }
}
