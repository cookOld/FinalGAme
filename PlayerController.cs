using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public float hp;
    public GameObject text;
    public GameObject textlol;
    private Text text1;
    private Text text2;
    float horizontalSpeed = 2.0f;
    Rigidbody rbPlayer;
    Rigidbody rbClone;
    public GameObject bullet;
    GameObject cloneBullet;
    public float score;
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();
        hp = 5;
        text1 = text.GetComponent<Text>();
        text2 = textlol.GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        text1.text = "hp:" + hp;
        text2.text = "Score:" + score;
        if(hp<=0){
            SceneManager.LoadScene("GameOver");
        }
        if(score>=5){
            SceneManager.LoadScene("YouWin");
        }
    }
    void FixedUpdate(){
        float moveVertical = Input.GetAxis("Vertical");
        rbPlayer.AddForce(transform.forward * moveVertical * 30f);

        float moveHorizontal = Input.GetAxis("Horizontal");
        rbPlayer.AddForce(transform.right * moveHorizontal * 30f);

        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        transform.Rotate(0, h, 0);
        if(Input.GetKeyDown("space")){
            cloneBullet = Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), Quaternion.identity);
            rbClone = cloneBullet.GetComponent<Rigidbody>();
            rbClone.AddForce(transform.forward * 1500f);
        }
    }
     void OnCollisionEnter(Collision Enemy) {
        if(Enemy.gameObject.tag == "Enemy"){
            hp--;
        }
    }
    public void Score(){
        score++;
    }
}
