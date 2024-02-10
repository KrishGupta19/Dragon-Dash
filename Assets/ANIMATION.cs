using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireanimation : MonoBehaviour
{
    public Sprite[] fire = new Sprite[12];
    private int i = 0, j = 0;
    public SpriteRenderer firesprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(++j ==25)
        { firesprite.sprite = fire[++i];
          //Debug.Log(i);
          if (i >10) i = -1;
            j = 0;
        }
        
    }
}
