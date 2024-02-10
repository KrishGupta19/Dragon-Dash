using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public  int x = 2;

    [SerializeField] private AudioSource jumpSoundEffect;
    //public static int coinCount;
    //public Text coinText;
    void Start()
    {
        //transform.position = new Vector3(0, 0);
    }
    void Update()
    {
        //transform.position += new Vector3(x, 0) * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * 220); 
            jumpSoundEffect.Play();

        }
        
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            GetComponent<Renderer>().enabled = false;
            Time.timeScale = 0;
        }
        //if (Input.GetKeyDown(KeyCode.LeftControl))
        //  Destroy(other.gameObject);
    }

}