using UnityEngine;

public class Camara : MonoBehaviour
{
    [SerializeField] Transform target; 
    [SerializeField] float smoothSpeed = 1f; //Velocidad a la que la camara sigue al jugador
    [SerializeField] private Vector3 offset;
    [SerializeField] bool lookAtTarget = true;

    private void Start() {
        offset = new Vector3(0f,25f,-8f);
    }
    private void LateUpdate() {
        Vector3 camaraPosicion = target.position+offset; //Suma de vectores
        transform.position = Vector3.Slerp(transform.position, camaraPosicion, smoothSpeed);
        if(lookAtTarget){
            transform.LookAt(target);
        }
    }
    
}
