using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField]

    private int enemyType;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveEnemy();
        EnemyDestruction();
    }

    public void MoveEnemy(){
        switch (enemyType){
            case 1:
            {
                transform.Translate(0,0,12f*Time.deltaTime);
                break;
            }
            case 2:
            {
                transform.Translate(0,0,18f*Time.deltaTime);
                break;
            }
            case 3:
            {
                transform.Translate(0,0,24f*Time.deltaTime);
                break;
            }
            case 4:
            {
                transform.Translate(0,0,48f*Time.deltaTime);
                break;
            }
        }
    }

    public void EnemyDestruction(){
        if (transform.position.x > 118 || transform.position.x < -27)
        {
            Destroy(gameObject);
        }
    }
}
