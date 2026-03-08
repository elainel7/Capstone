using UnityEngine;

[RequireComponent(typeof(Camera))]
public class SideScrollingCamera : MonoBehaviour
{
    public Transform trackedObject;
    public float height = 6.5f;
    public float undergroundHeight = -9.5f;
    public float undergroundThreshold = 0f;

    private float _startX;

    private void Start()
    {
        _startX = transform.position.x;
    }

    private void LateUpdate()
    {
        if (trackedObject == null) return;

        Vector3 cameraPosition = transform.position;
        float targetX = trackedObject.position.x;
        cameraPosition.x = Mathf.Max(_startX, targetX);
        transform.position = cameraPosition;
    }

    public void SetUnderground(bool underground)
    {
        Vector3 cameraPosition = transform.position;
        cameraPosition.y = underground ? undergroundHeight : height;
        transform.position = cameraPosition;
    }

}
