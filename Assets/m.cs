using UnityEngine;

public class BackgroundMover : MonoBehaviour
{
    public float scrollSpeed = 5f; // سرعة الحركة

    void Update()
    {
        transform.Translate(Vector3.left * scrollSpeed * Time.deltaTime);

    }
}