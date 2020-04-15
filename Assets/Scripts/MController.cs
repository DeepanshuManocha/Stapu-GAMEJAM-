using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MController : MonoBehaviour
{
    //public ChangeColor floor;
    //public Movement1 player;
    public GameObject gameOver;
    
    
    
    void OnCollisionEnter(Collision col)
    {
       
        Debug.Log("TOUCHED");
        if (col.gameObject.tag=="Tile")
        {
            if(col.gameObject.GetComponent<SpriteRenderer>().color==Color.red || col.gameObject.GetComponent<SpriteRenderer>().color==Color.black)
            {
                Debug.Log("TOUCHED...");
                Destroy(gameObject);
                gameOver.SetActive(true);
            }
        }
    }
}
