using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{

    private SpriteRenderer SR;
    public Sprite defaultImage;
    public Sprite[] pressedImages;

    public KeyCode keyToPress;
  
    // Start is called before the first frame update
    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow)){

            SR.sprite = pressedImages[0];
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow)){

            SR.sprite = pressedImages[1];
        }
		if(Input.GetKeyDown(KeyCode.RightArrow)){

            SR.sprite = pressedImages[2];
        }
		if(Input.GetKeyDown(KeyCode.UpArrow)){

            SR.sprite = pressedImages[3];
        }
        if(!Input.anyKey){
            SR.sprite = defaultImage;
        }
    }
}
