using System;
using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private int _startValue = 0;
    [SerializeField] private int _additionalValue = 1;
    [SerializeField] private float _additionalDelay = 0.5f;

    private int _value;
    private bool _isRunning = false;

    public int Value => _value;

    public event Action Changed;

    private void Start()
    {
        _value = _startValue;
    }

    public void StartCointing()
    {
        StartCoroutine(StartCounting());
    }

    public void StopCounting()
    {
        _isRunning = false;
    }

    private void Add(int value)
    {
        _value += value;
        Changed?.Invoke();
    }

    private IEnumerator StartCounting()
    {
        _isRunning = true;

        while (_isRunning)
        {
            Add(_additionalValue);
            yield return new WaitForSeconds(_additionalDelay);
        }
    }
}
