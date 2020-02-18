using UnityEngine;
using CreatorKitCode;

public class SpawnerSample : MonoBehaviour
{
    public GameObject ObjectToSpawn;

    void Start()
    {
        int angle = 15;
        Vector3 spawnPosition = transform.position;
        int radius = 5;

        Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        spawnPosition = transform.position + direction * radius;
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);

        angle = 55;
        positionSpawn(angle, spawnPosition, direction, radius);

        angle = 95;
        positionSpawn(angle, spawnPosition, direction, radius);
       
        angle = 135; 
        positionSpawn(angle, spawnPosition, direction, radius);
    }

    void positionSpawn(int angle, Vector3 spawnPosition, Vector3 direction, int radius)
    {
        direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        spawnPosition = transform.position + direction * radius;
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
    }
}

