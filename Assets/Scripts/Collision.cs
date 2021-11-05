using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Text ScoreText;
    public int CountCollision = 0;
    private void OnCollisionEnter2D(Collision2D col) {

        if(col.gameObject.name == "Obstacle"){

            CountCollision ++;

            ScoreText.text = CountCollision.ToString();

        }
         
    }


}
