using Assets.Scripts;
using UnityEngine;

public class Shoot
{

    public GameObject ShootBullet(Vector2 spawnPos, Vector2 targetPos, float time)
    {
        GameObject bullet = (GameObject)Resources.Load("Bullet");
        GameObject bulletInst = GameObject.Instantiate(bullet, spawnPos, Quaternion.identity);

        bulletInst.GetComponent<Bullet>().Initialize(targetPos, NedeedSpeed(spawnPos, targetPos, time));

        return bulletInst;
    }

    private float NedeedSpeed(Vector2 spawnPos, Vector2 targetPos, float time)
    {
        return Vector2.Distance(spawnPos, targetPos) / time;
    }
}
