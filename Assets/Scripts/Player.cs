using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animation thisAnimation;
    private Rigidbody thisRigidBody;

    private float thrust = 50000f;

    void Start()
    {
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;

        thisRigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            thisAnimation.Play();

            thisRigidBody.AddForce(transform.up * thrust * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.other.tag == "Obstacle")
        {
            GameManager.thisManager.GameOver();
        }       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Points")
        {
            GameManager.thisManager.UpdateScore(1);
        }
    }
}
