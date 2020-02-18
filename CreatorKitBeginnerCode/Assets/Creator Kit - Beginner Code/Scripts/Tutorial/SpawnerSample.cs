using UnityEngine;
using CreatorKitCode;

public class SpawnerSample : MonoBehaviour
{
    public GameObject ObjectToSpawn;

    void Start()
    {
        LootAngle lootAngle = new LootAngle(45);
        positionSpawn(lootAngle.nextAngle());
        positionSpawn(lootAngle.nextAngle());
        positionSpawn(lootAngle.nextAngle());
        positionSpawn(lootAngle.nextAngle());

    }

    void positionSpawn(int angle)
    {
        int radius = 5;
        Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        Vector3 spawnPosition = transform.position + direction * radius;
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
    }
}

public class LootAngle
{
    int angle;
    int step;

    public LootAngle(int increment)
    {
        angle = 0;
        step = increment;
    }

    public int nextAngle()
    {
        int currentAngle = angle;
        angle = Helpers.WrapAngle(angle + step);
        return currentAngle;
    }
}
