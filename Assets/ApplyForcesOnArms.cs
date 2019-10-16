using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForcesOnArms : MonoBehaviour {

    [SerializeField] private Rigidbody[] rb;
    [SerializeField] private Transform[] posToApply;
    [SerializeField] private Vector3[] dirToApplyForce;
    [SerializeField] private Vector3[] forceToApply;
    [SerializeField] private Vector3[] dirToApplyTorque;
    [SerializeField] private float[] torqueToApply;
    [SerializeField] private ForceMode[] fMode;

    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    private void FixedUpdate() {
        if (Input.GetKey(KeyCode.Keypad4)) {
            rb[0].AddForceAtPosition(forceToApply[0], posToApply[0].InverseTransformDirection(dirToApplyForce[0]), fMode[0]);
            rb[0].AddRelativeTorque(dirToApplyTorque[0] * torqueToApply[0], fMode[0]);
        }
        if (Input.GetKey(KeyCode.Keypad5)) {
            rb[1].AddForceAtPosition(forceToApply[1], posToApply[1].InverseTransformDirection(dirToApplyForce[1]), fMode[1]);
            rb[1].AddRelativeTorque(dirToApplyTorque[1] * torqueToApply[1], fMode[1]);
        }
        if (Input.GetKey(KeyCode.Keypad6)) {
            rb[2].AddForceAtPosition(forceToApply[2], posToApply[2].InverseTransformDirection(dirToApplyForce[2]), fMode[2]);
            rb[2].AddRelativeTorque(dirToApplyTorque[2] * torqueToApply[2], fMode[2]);
        }
    }
}
