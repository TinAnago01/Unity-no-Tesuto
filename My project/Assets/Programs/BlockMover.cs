using UnityEngine;

public class BlockMover : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 position = transform.position;
            position.y += 10f;
            transform.position = position;
        }
    }
}