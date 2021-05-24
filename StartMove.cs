using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMove : MonoBehaviour
{
   public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(move());
    }

    IEnumerator move()
    {
        yield return new WaitForSeconds(5);
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}