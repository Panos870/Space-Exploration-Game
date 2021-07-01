using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class playerController : MonoBehaviour
{
    public float playerSpeed;
    public float maxPos = 2.4f;
    Vector3 position;
    public uiManager ui;


    // Start is called before the first frame update
    void Start()
    {
        //ui = GetComponent<uiManager> ();
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        position.x +=Input.GetAxis ("Horizontal") * playerSpeed * Time.deltaTime;
        position.x = Mathf.Clamp (position.x, -2.4f, 2.4f);
        transform.position = position;
    }
    
    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "EnemySpaceship"){
            Destroy (gameObject);
            ui.gameOverActivated();
        }

    }
}
