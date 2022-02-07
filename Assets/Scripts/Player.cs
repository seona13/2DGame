using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    [SerializeField]
    float _moveSpeed;
    [SerializeField]
    float _jumpForce;
    [SerializeField]
    Rigidbody2D _rig;


	void OnEnable()
	{
        Enemy.onPlayerCollision += GameOver;
	}


	void onDisable()
	{
        Enemy.onPlayerCollision -= GameOver;
	}


	void Start()
    {
        
    }


	void FixedUpdate()
	{
        float xInput = Input.GetAxis("Horizontal");
        _rig.velocity = new Vector2(xInput * _moveSpeed, _rig.velocity.y);
	}


    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && IsGrounded())
        {
            _rig.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
		}
    }


    bool IsGrounded()
	{
        RaycastHit2D hit = Physics2D.Raycast(transform.position + new Vector3(0,-0.1f,0), Vector2.down, 0.2f);

        return hit.collider != null;
	}


    void GameOver()
	{
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}