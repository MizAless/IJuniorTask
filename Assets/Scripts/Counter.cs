using System;
using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private int _startValue = 0;
    [SerializeField] private int _additionalValue = 1;
    [SerializeField] private float _additionalDelay = 0.5f;

    private int _value;
    private Coroutine _currentCoroutine;

    public event Action<int> Changed;

    private void Start()
    {
        _value = _startValue;
    }

    public void StartCointing()
    {
        _currentCoroutine = StartCoroutine(StartCounting());
    }

    public void StopCounting()
    {
        if (_currentCoroutine == null)
            return;

        StopCoroutine(_currentCoroutine);
    }

    private void Add(int value)
    {
        _value += value;
        Changed?.Invoke(_value);
    }

    private IEnumerator StartCounting()
    {
        while (true)
        {
            Add(_additionalValue);
            yield return new WaitForSeconds(_additionalDelay);
        }
    }
}
