using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    [SerializeField]
    GameObject ballPrefab;

    float speed = 2f;

    Vector3 velocity = new Vector3(0, 0, 0);

    void Update()
    {
        velocity = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z + 200 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z - 200 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            velocity += LookAtDirection(transform.eulerAngles.z);
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocity -= LookAtDirection(transform.eulerAngles.z);
        }

        velocity.Normalize();

        transform.position += velocity * Time.deltaTime * speed;

        if(Input.GetKey(KeyCode.Space))
        {
            GameObject newBall = Instantiate(ballPrefab);
            newBall.transform.position = transform.position;
            newBall.GetComponent<Ball>().velocity = velocity += LookAtDirection(transform.eulerAngles.z);
        }
    }

    void MovementWASD()
    {
        velocity = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            if (transform.position.y< 1)
            {
                velocity += Vector3.up;
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -1.75)
            {
                velocity += Vector3.left;
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x< 1.75)
            {
                velocity += Vector3.right;
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (transform.position.y > -1)
            {
                velocity += Vector3.down;
            }
        }
    }

    public Vector3 LookAtDirection(float eulerAnglesZ)
    {
        return new Vector3(Mathf.Cos(eulerAnglesZ * Mathf.Deg2Rad), Mathf.Sin(eulerAnglesZ * Mathf.Deg2Rad), 0);
    }
}
