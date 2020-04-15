using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour
{
    // Start is called before the first frame update
  
   public float moveSpeed;
    void Start()
    {
        moveSpeed = 2.5f;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,0f,moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime);

        transform.Translate(moveSpeed*SimpleInput.GetAxis("Horizontal")*Time.deltaTime,0f,moveSpeed*SimpleInput.GetAxis("Vertical")*Time.deltaTime);
    }
}
