using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour {
    public FromAnimToRagdoll owner;
    public Collider col;

    private void OnDrawGizmos() {
        Gizmos.color = Color.blue;
        if (col is SphereCollider) {
            SphereCollider c = col as SphereCollider;
            Gizmos.DrawSphere(c.center, c.radius * 1.3f);
        } else if (col is BoxCollider) {
            BoxCollider bc = col as BoxCollider;


        } else if (col is CapsuleCollider) {
            CapsuleCollider cc = col as CapsuleCollider;
            int d = cc.direction;
            Vector3 dir = Vector3.zero;
            if (d == 0) {
                dir = Vector3.right;
            } else if (d == 1) {
                dir = Vector3.up;
            } else if (d == 2) {
                dir = Vector3.forward;
            }
            Gizmos.DrawLine(cc.center + dir * cc.height / 2, cc.center - dir * cc.height / 2);
            Gizmos.DrawSphere(cc.center + dir * cc.height / 2, cc.radius * 1.3f);
            Gizmos.DrawSphere(cc.center - dir * cc.height / 2, cc.radius * 1.3f);
        }
    }


    private void Update() {
        if (col is SphereCollider) {
            SphereCollider c = col as SphereCollider;
            Collider[] cols = Physics.OverlapSphere(col.transform.position + c.center, c.radius, owner.notifierLayer);
            if (cols.Length > 0)
                owner.NotifyCollision();
        } else if (col is BoxCollider) {
            BoxCollider bc = col as BoxCollider;
            Collider[] cols = Physics.OverlapBox(bc.transform.position + bc.center, bc.size / 2, bc.transform.rotation, owner.notifierLayer);
            if (cols.Length > 0)
                owner.NotifyCollision();
        } else if (col is CapsuleCollider) {
            CapsuleCollider cc = col as CapsuleCollider;
            int d = cc.direction;
            Vector3 dir = Vector3.zero;
            if (d == 0) {
                dir = Vector3.right;
            } else if (d == 1) {
                dir = Vector3.up;
            } else if (d == 2) {
                dir = Vector3.forward;
            }
            Collider[] cols = Physics.OverlapCapsule(cc.transform.position + cc.center + dir * cc.height / 2, cc.transform.position + cc.center - dir * cc.height / 2, cc.radius, owner.notifierLayer);

            if (cols.Length > 0)
                owner.NotifyCollision();
        }
    }
}