using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Information : MonoBehaviour
{
    [Header("OTHER SCRIPTS")]
    public CannonMovement cannonMovement;
    public Bullet bullet;
    public Shoot shoot;


    [Header("SHOT INFORMATION")]

    public int shotCounter;

    public List<int> shotNumber = new List<int>();

    public List<float> verticalAngles = new List<float>();

    public List<float> horizontalAngles = new List<float>();

    public List<float> shotForce = new List<float>();


    [Header("BULLET INFORMATION")]

    public List<float> time = new List<float>();

    public List<float> distance = new List<float>();

    public float currentTime;


    [Header("COLLISION")]
    public List<int> collisionedObstacles = new List<int>();


    [Header("TOTAL")]
    public int collisionedObjectTotal;



    private void Update()
    {
        currentTime = Time.deltaTime;
    }

    public void TakeShotInformation()
    {
        shotCounter++;
        shotNumber.Add(shotCounter);

        shotForce.Add(shoot.force.value);
        horizontalAngles.Add(cannonMovement.z.value);
        verticalAngles.Add(cannonMovement.x.value);
    }


    public void TotalInformation()
    {
        collisionedObjectTotal = collisionedObstacles.Sum();
    }
}
