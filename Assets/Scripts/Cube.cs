﻿using UnityEngine;

public class Cube : MonoBehaviour
{
    [HideInInspector]
    public float height;
    public MeshRenderer CubeMeshRenderer;
    public bool isMoving;
    private Vector3 targetPos;
    float time;

    private void Awake()
    {
        LoadValues();
    }

    private void LoadValues()
    {
        height = gameObject.transform.localScale.y;
        CubeMeshRenderer = gameObject.GetComponent<MeshRenderer>();
        CubeMeshRenderer.material.color =  Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }

    public void SetTargetPosAndTime(Vector3 targetPosition, float timeToMove)
    {
        targetPos = targetPosition;
        time = timeToMove;
        
    }
    void MoveCube()
    {
        transform.position = Vector3.Lerp(transform.position, targetPos, time);
    }
    // Transforms to act as start and end markers for the journey.
    public Transform startMarker;
    public Transform endMarker;

    // Movement speed in units per second.
    public float speed = 1.0F;

    // Time when the movement started.
    private float startTime;

    // Total distance between the markers.
    private float journeyLength;

    void Start()
    {
        // Keep a note of the time the movement started.
        startTime = Time.time;

        // Calculate the journey length.
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
    }

    // Move to the target end position.
    void Update()
    {
        // Distance moved equals elapsed time times speed..
        float distCovered = (Time.time - startTime) * speed;

        // Fraction of journey completed equals current distance divided by total distance.
        float fractionOfJourney = distCovered / journeyLength;

        // Set our position as a fraction of the distance between the markers.
        transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fractionOfJourney);
    }
}