using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    void FixedUpdate ()
    {
        Debug.Log("FixedUpdate timee :" + Time.deltaTime); 
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update timee :" + Time.deltaTime);
    }
}
