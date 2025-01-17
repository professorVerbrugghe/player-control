using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private PlayerController playerControllerScript;
    private float downBound = -5;

    private void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerControllerScript.gameOver)
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);  
        }

        if (transform.position.y <= downBound)
        {
            Destroy(gameObject);
        }
    }
}
