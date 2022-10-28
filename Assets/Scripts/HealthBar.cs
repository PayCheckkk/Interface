using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _player;

    private Slider _slider;
    private float _duration = 0.3f;
    private float _runningTime;

    private void Start()
    {
        _slider = GetComponent<Slider>();
        _slider.value = _player.OutputHealth();
    }

    public IEnumerator ChangeHealthBar(float value)
    {
        while (_runningTime <= _duration)
        {
            _runningTime += Time.deltaTime;
            _slider.value = Mathf.MoveTowards(_slider.value, value, _runningTime / _duration);
            yield return null;
        }
        _runningTime = 0;
    }
}
