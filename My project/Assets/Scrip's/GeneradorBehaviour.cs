using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorBehaviour : MonoBehaviour
{
    [SerializeField]    private GameObject Enemigo01;
    [SerializeField]    private GameObject Enemigo02;
    [SerializeField]    private GameObject Enemigo03;
    [SerializeField]    private GameObject Enemigo04;
    [SerializeField]    private int generateType;
    void Start()
    {
        switch(generateType){
            case 1:
            {
                InvokeRepeating("InvokeCar",0,6);
                break;
            }
            case 2:
            {
                InvokeRepeating("InvokeCar2",0,6);
                break;
            }
            case 3:
            {
                InvokeRepeating("InvokeCar3",0,3);
                break;
            }
            case 4:
            {
                InvokeRepeating("InvokeCar4",0,2);
                break;
            }
        }
        
    }

    public void InvokeCar(){
        Instantiate(Enemigo01, transform.position, transform.rotation);
    }
        public void InvokeCar2(){
        Instantiate(Enemigo02, transform.position, transform.rotation);
    }
        public void InvokeCar3(){
        Instantiate(Enemigo03, transform.position, transform.rotation);
    }
        public void InvokeCar4(){
        Instantiate(Enemigo04, transform.position, transform.rotation);
    }
}
