using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject player1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision Enemy) {
        if(Enemy.gameObject.tag == "Enemy"){
        	player1.GetComponent<PlayerController>().Score();
            Destroy(Enemy.gameObject);
        }
        Destroy(gameObject);
    }
}
