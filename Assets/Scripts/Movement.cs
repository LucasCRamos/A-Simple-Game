using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject Obstacle;
    [SerializeField] private int count = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.A)){

            Player.gameObject.transform.Translate(-0.1f,0f,0.0f);
        }

        if(Input.GetKey(KeyCode.D)){

            Player.gameObject.transform.Translate(0.1f,0f,0.0f);
        }

        if(Input.GetKey(KeyCode.S)){

            Player.gameObject.transform.Translate(0.0f,-0.1f,0.0f);
        }

        if(Input.GetKey(KeyCode.W)){

            Player.gameObject.transform.Translate(0.0f,0.1f,0.0f);
        }

        if(count == 1){

            Obstacle.gameObject.transform.Translate(0.5f,0f,0.0f);

            if(Obstacle.gameObject.transform.position.x > 6) count = 0;

        }

        if(count == 0){

            Obstacle.gameObject.transform.Translate(-0.5f,0f,0.0f);

            if(Obstacle.gameObject.transform.position.x < -6) count = 1;

        }
    }
}
