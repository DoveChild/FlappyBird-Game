using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdControl : MonoBehaviour
{
    public GameManager gameManager;
    public float jumpForce = 5.0f;
    private Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
		{
            body.velocity = new Vector2(body.velocity.x, jumpForce);
		}
    }

	private void OnCollisionEnter2D(Collision2D collision)
	{
        gameManager.GameOver();
	}
}
