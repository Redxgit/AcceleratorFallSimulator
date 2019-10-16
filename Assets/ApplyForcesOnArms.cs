using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForcesOnArms : MonoBehaviour {

    [SerializeField] private Rigidbody[] rb;
    [SerializeField] private Transform[] posToApply;
    [SerializeField] private Vector3[] dirToApplyForce;
    [SerializeField] private float[] forceToApply;
    [SerializeField] private Vector3[] dirToApplyTorque;
    [SerializeField] private float[] torqueToApply;
    [SerializeField] private ForceMode[] fMode;

    public bool useInverse;

    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    private void FixedUpdate() {
        if (Input.GetKey(KeyCode.Keypad4)) {
            if (useInverse) {
                rb[0].AddForceAtPosition(posToApply[0].InverseTransformDirection(dirToApplyForce[0]) * forceToApply[0], posToApply[0].position, fMode[0]);
                Debug.DrawRay(posToApply[0].position, posToApply[0].InverseTransformDirection(dirToApplyForce[0]) * forceToApply[0], Color.blue);
            } else {
                rb[0].AddForceAtPosition(posToApply[0].TransformDirection(dirToApplyForce[0]) * forceToApply[0], posToApply[0].position, fMode[0]);
                Debug.DrawRay(posToApply[0].position, posToApply[0].TransformDirection(dirToApplyForce[0]) * forceToApply[0], Color.blue);

            }
            rb[0].AddRelativeTorque(dirToApplyTorque[0] * torqueToApply[0], fMode[0]);
            
        }
        if (Input.GetKey(KeyCode.Keypad5)) {
            if (useInverse) {
                rb[1].AddForceAtPosition(posToApply[1].InverseTransformDirection(dirToApplyForce[1]) * forceToApply[1], posToApply[1].position, fMode[1]);
                Debug.DrawRay(posToApply[1].position, posToApply[1].InverseTransformDirection(dirToApplyForce[1]) * forceToApply[1], Color.yellow);
            } else {
                rb[1].AddForceAtPosition(posToApply[1].TransformDirection(dirToApplyForce[1]) * forceToApply[1], posToApply[1].position, fMode[1]);
                Debug.DrawRay(posToApply[1].position, posToApply[1].TransformDirection(dirToApplyForce[1]) * forceToApply[1], Color.yellow);
            }
            rb[1].AddRelativeTorque(dirToApplyTorque[1] * torqueToApply[1], fMode[1]);
        }
        if (Input.GetKey(KeyCode.Keypad6)) {
            if (useInverse) {
                rb[2].AddForceAtPosition(posToApply[2].InverseTransformDirection(dirToApplyForce[2]) * forceToApply[2], posToApply[2].position, fMode[2]);
                Debug.DrawRay(posToApply[2].position, posToApply[2].InverseTransformDirection(dirToApplyForce[2]) * forceToApply[2], Color.green);
            } else {
                rb[2].AddForceAtPosition(posToApply[2].TransformDirection(dirToApplyForce[2]) * forceToApply[2], posToApply[2].position, fMode[2]);
                Debug.DrawRay(posToApply[2].position, posToApply[2].TransformDirection(dirToApplyForce[2]) * forceToApply[2], Color.green);
            }
            rb[2].AddRelativeTorque(dirToApplyTorque[2] * torqueToApply[2], fMode[2]);
        }
    }
}
