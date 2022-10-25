using UnityEngine;
using TMPro;

public class Contador : MonoBehaviour
{
    [SerializeField] float tiempoActual = 0, tiempoInicial = 180;
    [SerializeField] int tiempoTexto;
    [SerializeField] TextMeshProUGUI contadorText, perdisteText;
    void Start()
    {
        tiempoActual = tiempoInicial;
    }
    void Update()
    {
        if(tiempoActual >0){
            tiempoActual-= 1*Time.deltaTime;
            tiempoTexto = (int) tiempoActual;
            contadorText.text = tiempoTexto.ToString();
        }else{
            perdisteText.enabled = true;
        }
    }
}
