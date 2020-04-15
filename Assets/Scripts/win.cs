using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject player;
    
    
    
    void OnCollisionEnter(Collision col)
    {
       
        Debug.Log("TOUCHED");
        gameOver.SetActive(true);
        player.SetActive(false);
    }
}
