using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//CodingTrain
//https://www.youtube.com/watch?v=f0lkz2gSsIk

//Wikipedia
//https://en.wikipedia.org/wiki/Lorenz_system
public class LorenzttAractor : MonoBehaviour
{

    private float posX;
    private float posY;
    private float posZ;

    private const float a = 10.0f;
    private const float b = 28.0f;
    private const float c = 8.0f/3.0f;
    private Vector3 particlePosition { get; set; }

    private float elapsedTime;
    // Start is called before the first frame update
    void Start()
    {
        posX = 0.01f;
        posY = 0.0f;
        posZ = 0.0f;
        particlePosition = new Vector3(0, 0, 0);
        elapsedTime = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePositions();
    }

    private void UpdatePositions()
    {
        float dt = 0.01f;
        float dx = (a * (posY - posX)) * dt;
        float dy = (posX * (b - posZ) - posY) * dt;
        float dz = (posX * posY - c * posZ) * dt;
        posX = posX + dx;
        posY = posY + dy;
        posZ = posZ + dz;
        Vector3 newPosition = new Vector3(posX, posY, posZ);
        setParticlePosition(newPosition);
        if (false)
        {        
            Debug.Log($"X : {newPosition.x}");
            Debug.Log($"Y : {newPosition.y}");
            Debug.Log($"Z : {newPosition.z}");
        }
    }

    private void setParticlePosition(Vector3 pos)
    {
        particlePosition = pos;
    }

    public Vector3 getParticlePosition()
    {
        return particlePosition;
    }
}
