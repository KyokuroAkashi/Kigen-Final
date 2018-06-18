using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour {

    public Transform trackingTarget;

    public float xOffset;
    public float yOffset;
    public float followSpeed;

    public bool isXLocked = false;
    public bool isYLocked = false;

    float zoomFactor = 1.0f;
    float zoomSpeed = 5.0f;

    private float originalSize = 0f;

    private Camera thisCamera;


    // Use this for initialization
    void Start () {
        thisCamera = GetComponent<Camera>();
        originalSize = thisCamera.orthographicSize;
    }
	
	// Update is called once per frame
	void Update () {
        float xTarget = trackingTarget.position.x + xOffset;
        float yTarget = trackingTarget.position.y + yOffset;

        float xNew = Mathf.Lerp(transform.position.x, xTarget, Time.deltaTime * followSpeed);
        float yNew = Mathf.Lerp(transform.position.y, yTarget, Time.deltaTime * followSpeed);

        transform.position = new Vector3(xNew, yNew, transform.position.z);

        float targetSize = originalSize * zoomFactor;

        if (targetSize != thisCamera.orthographicSize)
        {
            thisCamera.orthographicSize = Mathf.Lerp(thisCamera.orthographicSize,targetSize, Time.deltaTime * zoomSpeed);
        }
    }

    void SetZoom(float zoomFactor)
    {
        this.zoomFactor = zoomFactor;
    }
}
