using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotetion_Effect : MonoBehaviour
{
    public AudioSource Coin_Collect;
    float speed = 0.5f;
    Vector3 angle = new Vector3(0,0,45);
    void Update()
    {
        transform.Rotate(angle * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        Coin_Collect.Play();
        Score_Count.Score++;
        Destroy(gameObject);
        
    }
}
