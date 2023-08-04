using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;



namespace Player{

    public class PlayerInput : MonoBehaviour
    {
        private Rigidbody rb;

        private float movementX;
        private float movementY;
        public float speed = 10;


        public InputAction Movement;
        public InputAction Aiming;
        public InputAction Shoot;

        public InputActionMap PlayerActions; 

        ////////////////////////////////////////////////////////////////
        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        void Update()
        {
            
        }

        void FixedUpdate() {
            Vector3 movement = new Vector3(movementX, 0.0f, movementY);
            rb.AddForce(movement * speed);    
        }
        ////////////////////////////////////////////////////////////////
        private void OnMove(InputValue movementValue) {
            Vector2 movementVector = movementValue.Get<Vector2>();

            movementX = movementVector.x;
            movementY = movementVector.y;
        }
    }
}
