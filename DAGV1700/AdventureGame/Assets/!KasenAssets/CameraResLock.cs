using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(Camera))]
public class CameraResLock : MonoBehaviour
{
    public float aspectRatio = 16f / 9f;
    private Camera cam;

    void Awake()
    {
        cam = GetComponent<Camera>();
    }

    void LateUpdate()
    {
        float windowAspect = (float)Screen.width / Screen.height;
        float scaleHeight = windowAspect / aspectRatio;

        if (scaleHeight < 1.0f)
        {
            cam.rect = new Rect(0f, (1.0f - scaleHeight) / 2f, 1.0f, scaleHeight);
        } else
        {
            float scaleWidth = 1.0f / scaleHeight;
            cam.rect = new Rect((1.0f - scaleWidth) / 2f, 0f, scaleWidth, 1.0f);
        }
    }
}
