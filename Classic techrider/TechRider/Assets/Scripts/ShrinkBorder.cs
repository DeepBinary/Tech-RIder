using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkBorder : MonoBehaviour
{    
    public GameObject startpoint;
    public GameObject endpoint;
    public bool isshrinking;
    public GameObject border;
    public float timebeforeshrink;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartShrink());
        border.transform.position = startpoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isshrinking == true) 
        {
            border.transform.position = Vector2.MoveTowards(border.transform.position, endpoint.transform.position, speed);
        }
    }   

    IEnumerator StartShrink()
    {
        isshrinking = false;
        yield return new WaitForSeconds(timebeforeshrink);
        isshrinking = true;
    }

}
