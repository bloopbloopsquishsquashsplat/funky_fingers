using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Sprite player_left;
    public Sprite player_right;
    public Sprite player_up;
    public Sprite player_down;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player_input();
    }

    private void player_input()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = player_left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = player_right;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = player_up;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = player_down;
        }
    }
}
