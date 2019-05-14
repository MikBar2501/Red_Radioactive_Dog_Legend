using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Stats stats;

    private Rigidbody m_Rigidbody;
    private Vector3 m_Move;

    private void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }
    private void OnEnable()
    {
        // When the tank is turned on, make sure it's not kinematic.
        m_Rigidbody.isKinematic = false;

        m_Move = Vector3.zero;
    }

    private void OnDisable()
    {
        // When the tank is turned off, set it to kinematic so it stops moving.
        m_Rigidbody.isKinematic = true;


    }

    // Update is called once per frame
    void Update()
    {
        m_Move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

    }
    private void FixedUpdate()
    {
        Move();
        Turn();
    }
    private void Move()
    {
        Vector3 movement = m_Move * stats.movingSpeed * Time.deltaTime;


        // Apply this movement to the rigidbody's position.
        m_Rigidbody.MovePosition(m_Rigidbody.position + movement);
    }

    
    private void Turn()
    { 
        if(m_Move.magnitude > 0)
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(m_Move), stats.rotationSpeed * Time.deltaTime);

    }

}
