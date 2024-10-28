using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Vector3 initialPosition;
    Information information;

    [Header("INFORMACION")]
    private float distance;
    private int collisionedObstaclesCounter;



    void Start()
    {
        information = FindAnyObjectByType<Information>();
        initialPosition = transform.position;

        information.TakeShotInformation();
    }
    
    void Update()
    {
        StartCoroutine(DestroyBullet(15));
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            collisionedObstaclesCounter++;
        }
    }

    void GetBulletInformation()
    {
        distance = transform.position.z - initialPosition.z;

        information.distance.Add(distance);
        information.time.Add(information.currentTime);
        information.collisionedObstacles.Add(collisionedObstaclesCounter);
    }

    IEnumerator DestroyBullet(float timeToDestroy)
    {
        yield return new WaitForSeconds(timeToDestroy);
        GetBulletInformation();
        Destroy(gameObject);
    }
}
