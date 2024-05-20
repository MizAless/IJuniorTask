using UnityEngine;
using UnityEngine.UIElements;

public class CounterController : MonoBehaviour
{
    [SerializeField] private Counter _counter;
    [SerializeField] private MouseButton _mouseButton = MouseButton.LeftMouse;

    private bool _isCounting = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown((int)_mouseButton))
        {
            _isCounting = !_isCounting;

            if (_isCounting)
                _counter.StartCointing();
            else
                _counter.StopCounting();
        }   
    }
}
