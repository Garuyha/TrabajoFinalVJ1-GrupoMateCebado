using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControler : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float rotationSpeed = 2f;
    void Update()
    {
       CatMove();
    }

    public void CatMove(){
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveCat = new Vector3(horizontalInput,0,verticalInput);
        moveCat.Normalize();

        transform.position = transform.position + moveCat * speed * Time.deltaTime;
        if(moveCat != Vector3.zero) transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.LookRotation(moveCat),rotationSpeed * Time.deltaTime);

    }
    public void MoveAlt(){
        float rotacion = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        float movimiento = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        //Moviemiento del objeto a travez del eje z
        transform.Translate(0,0, movimiento);
        // Rotación sobre el eje y del objeto.
        transform.Rotate(0, rotacion, 0);

    }

    
}
