using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : NetworkBehaviour
{

    public Transform objectTofollow;
    public float followSpeed =10.0f;
    public float sensitivity = 10.0f;
    public float clamoAngle = 7.0f;

    private float rotX;
    private float rotY;


    public Transform realCamera;
    public Vector3 dirNormalized;
    public Vector3 finalDir;
    public float minDistance;
    public float maxDistance;
    public float finalDistance;
    public float smoothness =10.0f;

    // Start is called before the first frame update
  

    void Start()
    {
       
            rotX = transform.localRotation.eulerAngles.x;
            rotY = transform.localRotation.eulerAngles.y;


            dirNormalized = realCamera.localPosition.normalized;
            finalDistance = realCamera.localPosition.magnitude;

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        
            rotX += -(Input.GetAxis("Mouse Y")) * sensitivity * Time.deltaTime;
            rotY += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;

            rotX = Mathf.Clamp(rotX, -clamoAngle, clamoAngle);

            Quaternion rot = Quaternion.Euler(rotX, rotY, 0);
            transform.rotation = rot;
        
    }

    private void LateUpdate()
    {
        
            transform.position = Vector3.MoveTowards(transform.position, objectTofollow.position, followSpeed * Time.deltaTime);
            finalDir = transform.TransformPoint(dirNormalized * maxDistance);

            RaycastHit hit;

            if (Physics.Linecast(transform.position, finalDir, out hit))
            {
                finalDistance = Mathf.Clamp(hit.distance, minDistance, maxDistance);

            }
            else
            {
                finalDistance = maxDistance;
            }

            realCamera.localPosition = Vector3.Lerp(realCamera.localPosition, dirNormalized * finalDistance, Time.deltaTime * smoothness);
        
    }
}
