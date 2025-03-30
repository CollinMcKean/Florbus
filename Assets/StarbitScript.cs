using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarbitScript : MonoBehaviour
{
    public int StarbitSpeed;
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       /* pos = this.transform.position;

        for (int i = 0; i < 1; i++)
        {
            // Calculate the direction vector from the object to the origin
            Vector3 directionToOrigin = -transform.position;

            // Create a rotation that aligns the object's forward direction with the direction to the origin
            Quaternion rotation = Quaternion.LookRotation(directionToOrigin);

            // Apply the rotation to the object's transform
            transform.rotation = rotation;
        }

        pos.z += 1f; */
    }
}
