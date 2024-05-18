using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;

    private void Update()
    {
        Scale();
    }

    private void Scale()
    {
        transform.localScale *= _scaleSpeed * Time.deltaTime + 1;
    }
}
