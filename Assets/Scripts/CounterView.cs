using TMPro;
using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] Counter _counter;
    [SerializeField] TextMeshProUGUI _counterText;

    private void OnEnable()
    {
        _counter.Changed += ChangeValue;
    }

    private void OnDisable()
    {
        _counter.Changed -= ChangeValue;
    }

    private void ChangeValue()
    {
        _counterText.text = _counter.Value.ToString("");
    }
}
