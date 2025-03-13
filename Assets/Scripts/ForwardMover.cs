using UnityEngine;

public class ForwardMover : MonoBehaviour
{
    private float _speed = 3;

    private void Update()
    {
        transform.Translate(0, 0, _speed * Time.deltaTime);
    }
}
