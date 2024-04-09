using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    public InfiniteMove infiniteMove;
   
    private void Update()
    {
        Detect(transform.position, 0.1f);
    }
    void Detect(Vector3 center, float radius)
    {
        Collider[] hitColliders = Physics.OverlapSphere(center, radius);

        foreach (var hitCollider in hitColliders)
        {
            if (hitCollider.tag == "Ground" || hitCollider.tag == "HalfWall")
            {
                infiniteMove.isGrounded = true;
            } 
        }
        if(hitColliders.Length <= 0) 
        {
            infiniteMove.isGrounded = false;
        }
    }
}
