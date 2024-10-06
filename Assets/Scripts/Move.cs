using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 2;

    private void Start()
    {
        var pos = transform.position;
        pos.y += Random.Range(-2f, 2f);
        transform.position = pos;   
    }


    // Update is called once per frame
    void Update()
    {

        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < - 10)
        {
            Destroy(gameObject);
        }

    }
}
