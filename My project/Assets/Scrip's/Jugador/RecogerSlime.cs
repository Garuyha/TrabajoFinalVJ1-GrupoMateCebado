using UnityEngine;
using TMPro;

public class RecogerSlime : MonoBehaviour
{
    [SerializeField] Transform slimePosicion;
    
    [SerializeField] TextMeshProUGUI ganasteText;
    [SerializeField] GameObject Respawn;
    private float distancia = 40f;
    private GameObject slimeActual;
    private GameObject wp;
    private bool canGrab = true;
    private int contador=0;

    private void Update() {
        if(contador>=3){
            ganasteText.enabled = true;            
        }
    }
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Slime" && canGrab && other.transform.position.z >-35f){
            wp = other.gameObject;
            Debug.Log("Recogido");
            Recoger();           
        }
        if(other.gameObject.tag == "Cesta"){
            Soltar();
            contador +=1;
            Debug.Log("Soltado");
        }
    }

    private void Recoger(){
        slimeActual = wp;
        canGrab = false;
        slimeActual.transform.position = slimePosicion.position;
        slimeActual.transform.parent = slimePosicion;
        slimeActual.transform.localEulerAngles = new Vector3(0f,180f,0f);
        slimeActual.GetComponent<Rigidbody>().isKinematic = true;
        Respawn.transform.SetPositionAndRotation(new Vector3 (42f, 0.5f, 151f), transform.rotation);
    }

    private void Soltar(){
        canGrab = true;
        slimeActual.transform.parent = null;
        slimeActual.transform.position = new Vector3(distancia, 0.2f,-35f);
        distancia -= 4f;
        slimeActual.GetComponent<Rigidbody>().isKinematic = false;
        slimeActual = null;
        Respawn.transform.SetPositionAndRotation(new Vector3 (30f, 1f, -31f), transform.rotation);
    }

}
