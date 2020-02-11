using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    float posx;
    // Start is called before the first frame update
    void Start()
    {
       posx = GameObject.Find("WallL").transform.localPosition.z;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(posx);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if(transform.localPosition.z < (posx - transform.localScale.z/2) )
              transform.position += transform.forward * 0.1f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            if(transform.localPosition.z > -(posx - transform.localScale.z/2) )
              transform.position -= transform.forward * 0.1f;
        }
    }
    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {

    }
}
