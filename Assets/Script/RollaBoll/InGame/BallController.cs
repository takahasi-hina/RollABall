using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour

{
    private Rigidbody ballRigidBody;
    // Start is called before the first frame update

    private BallData ballData;
    private void Start()
    {
        ballRigidBody = this.GetComponent<Rigidbody>();
        ballData = new BallData(5);
        Debug.Log(ballData.GetHitPoint);


    }
    public void BallMove(Vector3 direction)
    {
        ballRigidBody.AddForce(direction);


    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cube")
        {
            Debug.Log("Damage");
        }
    }


}


   

    
// Update is called once per frame

