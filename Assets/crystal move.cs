using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crystalmove: MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]  float speed = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-speed,0 )* Time.deltaTime;
        //transform.position += new Vector3(x, 0) * Time.deltaTime;
    }
}