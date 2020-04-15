using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(SpriteRenderer))]
public class ChangeColor : MonoBehaviour
{
   private SpriteRenderer sr;
   public float timetoChange=0.3f;
   private float timeSinceChange=0f;
   public Color[] colors = new Color[3];

     void Start()
     {
         colors[0] = Color.yellow;
         colors[1] = Color.red;
         colors[2] = Color.green;          
     }
    private void Awake()
    {
        sr=GetComponent<SpriteRenderer>();
    }
    
    void Update()
    {
        timeSinceChange+=Time.deltaTime;
        if(sr!=null && timeSinceChange>=timetoChange)
        {
            int c = Random.Range(0, colors.Length);
            sr.color=colors[c];
            timeSinceChange=0f;

        }
    }
}
