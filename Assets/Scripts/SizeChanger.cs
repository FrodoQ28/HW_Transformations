using UnityEngine;

public class SizeChanger : MonoBehaviour
{
    [SerializeField] private float _scaleChangeSpeed;

    private void Update()
    {
        float tempSpeed = _scaleChangeSpeed * Time.deltaTime;
        Vector3 magnitudeOfChange = new Vector3(tempSpeed, tempSpeed, tempSpeed);

        transform.localScale += magnitudeOfChange;
    }
}
