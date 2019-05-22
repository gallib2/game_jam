using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glass : MonoBehaviour
{
    public static event Action OnClickRightGlass;
    public static event Action OnGameOver;

    public Transform[] target;
    public float speed;

    private int current;
    public string winGlassType = "redGlass";

    // Update is called once per frame
    void Update()
    {
        if(transform.position != target[current].position)
        {
            // use larp?
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else
        {
            current = (current + 1) % target.Length;
        }

    }

    void OnMouseDown()
    {
        if(gameObject.tag == winGlassType)
        {
            OnClickRightGlass?.Invoke();
        }
        if(gameObject.tag == "glass")
        {
            OnGameOver?.Invoke();
        }
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "DestroyGlass")
        {
            Destroy(gameObject);
        }
    }
}
