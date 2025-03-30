using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    public GameObject SpawningPrefab;
    public GameObject SpawningO2;
    public GameObject SpawningFuel;
    public GameObject SpawningStarbit;
    

    public int NumPrefabs;
    public int NumO2;
    public int NumFuel;
    int StarbitCount = 0;
    public int StarbitTime = 5;
    public int StarbitHeight = 1;
    public int StarbitSpeed = 1;
    public float PlanetRadius = 20f;
    void Start()
    {
        for (int i = 0; i < NumPrefabs; i++)
        {
            // generate 3 random angles as degrees for x, y, z rot
            Vector3 angles = new Vector3(Random.value * 360f, Random.value * 360f, Random.value * 360f);
            // Represent rotation as a quaternion
            Quaternion quat = Quaternion.Euler(angles.x, angles.y, angles.z);
            Vector3 dir = quat * Vector3.forward;
            Debug.DrawRay(Vector3.zero, dir * (PlanetRadius + 1), Color.red, 10f);

            GameObject prefab = Instantiate(SpawningPrefab);
            prefab.transform.parent = transform;
            prefab.transform.position = dir * (PlanetRadius + prefab.transform.localScale.y);
            prefab.transform.rotation = quat;
        }

        for (int i = 0; i < NumO2; i++)
        {
            // generate 3 random angles as degrees for x, y, z rot
            Vector3 angles = new Vector3(Random.value * 360f, Random.value * 360f, Random.value * 360f);
            // Represent rotation as a quaternion
            Quaternion quat = Quaternion.Euler(angles.x, angles.y, angles.z);
            Vector3 dir = quat * Vector3.forward;
            Debug.DrawRay(Vector3.zero, dir * (PlanetRadius + 1), Color.red, 10f);

            GameObject prefab = Instantiate(SpawningO2);
            prefab.transform.parent = transform;
            prefab.transform.position = dir * (PlanetRadius + prefab.transform.localScale.y);
            prefab.transform.rotation = quat;
        }

        for (int i = 0; i < NumFuel; i++)
        {
            // generate 3 random angles as degrees for x, y, z rot
            Vector3 angles = new Vector3(Random.value * 360f, Random.value * 360f, Random.value * 360f);
            // Represent rotation as a quaternion
            Quaternion quat = Quaternion.Euler(angles.x, angles.y, angles.z);
            Vector3 dir = quat * Vector3.forward;
            Debug.DrawRay(Vector3.zero, dir * (PlanetRadius + 1), Color.red, 10f);

            GameObject prefab = Instantiate(SpawningFuel);
            prefab.transform.parent = transform;
            prefab.transform.position = dir * (PlanetRadius + prefab.transform.localScale.y);
            prefab.transform.rotation = quat;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        StarbitCount = StarbitCount + 1;
        if(StarbitCount == 60 * StarbitTime)
        {
            // generate 3 random angles as degrees for x, y, z rot
            Vector3 angles = new Vector3(Random.value * 360f, Random.value * 360f, Random.value * 360f);
            // Represent rotation as a quaternion
            Quaternion quat = Quaternion.Euler(angles.x, angles.y, angles.z);
            Vector3 dir = quat * Vector3.forward;
            Debug.DrawRay(Vector3.zero, dir * (PlanetRadius + 1), Color.red, 10f);

            GameObject prefab = Instantiate(SpawningStarbit);
            prefab.transform.parent = transform;
            prefab.transform.position = dir * (PlanetRadius + prefab.transform.localScale.y + StarbitHeight);
            prefab.transform.rotation = quat;
            print("tick");
            StarbitCount = 0;
        }
        SpawningStarbit.GetComponent<Rigidbody>().AddRelativeForce(gameObject.transform.forward * StarbitSpeed);
    }
}
