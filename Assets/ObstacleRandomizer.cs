using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRandomizer : MonoBehaviour {
    [SerializeField] private FromAnimToRagdoll controller;
    [SerializeField] private Transform obstacle;

    [SerializeField] private Transform minPos;
    [SerializeField] private Transform maxPos;

    private Vector3 startingPos;
    private Quaternion startingRot;

    private void Start() {
        controller.ReturnToAnimation += RandomizePosition;
    }

    [ContextMenu("RandomizePos")]
    private void RandomizePosition() {
        float positionPct = Random.value;
        float rotationPct = Random.value;
        obstacle.localPosition = Vector3.Lerp(minPos.position, maxPos.position, positionPct);
        obstacle.rotation = Quaternion.Slerp(minPos.rotation, maxPos.rotation, rotationPct);
    }


}
