using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AFKcoinSpawner : MonoBehaviour
{
    public float frequency;
    public GameObject Coins;

    [Header("Force")]
    public float FloatX;
    public float FloatY;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCoins", 0.001f, frequency);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnCoins()
    {
        GameObject coin = Instantiate<GameObject>(Coins, transform.position, transform.rotation);
        FloatX = Random.Range(-100, 100);
        FloatY = Random.Range(-100, 100);
        coin.GetComponent<Rigidbody2D>().AddForce(new Vector2(FloatX, FloatY));
    }
}
