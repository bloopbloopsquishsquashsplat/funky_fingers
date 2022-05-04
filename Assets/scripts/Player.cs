using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameObject player1;
    private GameObject player2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player1 && player2)
        {
            two_player_input();
        }else if (player1)
        {
            one_player_input();
        }
    }

    private void one_player_input()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Moves Player1
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Moves Player1
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Moves Player1
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //Moves Player1
        }
    }

    private void two_player_input()
    {
        one_player_input();
        if (Input.GetKey(KeyCode.A))
        {
            //Moves Player2
        }
        if (Input.GetKey(KeyCode.D))
        {
            //Moves Player2
        }
        if (Input.GetKey(KeyCode.W))
        {
            //Moves Player2
        }
        if (Input.GetKey(KeyCode.S))
        {
            //Moves Player2
        }
    }
}
