using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaralook : MonoBehaviour
{
    
[SerializeField]private float mouseSensitivity=1233;
float xRotation=0;
public Transform playerBody;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    float mouseX = Input.GetAxis("Mouse X")*mouseSensitivity*Time.deltaTime;

   
   playerBody.Rotate(Vector3.up*mouseX);

    }
}
