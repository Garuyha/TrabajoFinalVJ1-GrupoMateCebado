using UnityEngine;


public class Colision : MonoBehaviour
{
    [SerializeField] GameObject respawn;
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Auto" || other.gameObject.tag == "Plataforma"){ 
            transform.SetPositionAndRotation(respawn.transform.position, transform.rotation);
        }   
    }
}