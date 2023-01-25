using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Input;

namespace PlayerMech
{
    /*
    [RequireComponent(typeof(MechControl))]

    public class PlayerMechControllers : MonoBehaviour
    {
        [Header("Player Movement")]
        
        public float PlayerMoveSpeed = 4.0f;

        public float PlayerRunSpeed = 6.0f;

        public float PlayerTurnSpeed = 1.0f;

        public float SpeedChangeRate = 10.0f;

        [Space(10)]
        public float PlayerJumpHeight = 1.2f;

        public float Gravity = -15.0f;

        [Space(10)]
        public float JumpDelay = 0.01f;

        public float FallingDelay = 0.15f;

        [Header("Player Grounded")]
        public bool Grounded = true;
        
        public float GroundedOffset = -0.14f;

        public float GroundedRadius = 0.5f;

        public LayerMask GroundLayers;

        [Header("Cinemachine")]
        [Tooltip("The follow target set in cinemachine")]
        public GameObject CinemachineCameraTarget;
        [Tooltip("How far in degrees the camera can move up")]
        public float TopClamp = 90.0f;
        [Tooltip("How far in degrees the camera can move up")]
        public float BottomClamp = -90.0f;

        // cinemachine
        private float _cinemachineTargetPitch;

        // player
        private float _speed;
        private float _rotationVelocity;
        private float _verticalVelocity;
        private float _terminalVelocity = 53.0f;

        //delay deltatime
        private float _jumpDelayDelta;
        private float _fallDelayDelta;

        
        private MechControl _controller;
        private GameObject _mainCamera;

        private const float _threshold = 0.01f;

        private void Awake() {
            // reference to the main camera
            if(_mainCamera != null) {
                _mainCamera = GameObejct.FindGameObjectWithTag("mainCamera"); //
            }
        }

        private void Start() {
            _controller = GetComponent<MechaControl>();
            
            _jumpDelayDelta = JumpDelay;
            _fallDelayDelta = FallDelay;
        }

        private void Update() {
            //JumpAndGravity();
            //GroundedCheck();
            //Move();
        }

        private void LateUpdate() {
            CameraRotation();
        }

        private void GroundedCheck() {
            //Set sphere position with offset
            Vector3 spherePosition = new Vector3(transform.position.x, tranform.position.y - GroundedOffset, transform.position.z);
            Grounded = Physics.CheckSphere(spherePosition, GroundedRadius, GroundLayers, QueryTriggerInteraction.Ignore);
        }

        privatevoid CameraRotation() {
            if()
        }
    }
    */
}
