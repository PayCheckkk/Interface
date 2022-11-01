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
    private float _duration = 0.08f;
    private Coroutine _preventStackCoroutine;

    private void Start()
    {
        _player.HealthChanged += ChangeHealthBar;
        _slider = GetComponent<Slider>();
        _slider.maxValue = _player.GetMaxHealth;
        _slider.value = _player.GetHealth;        
    }

    private void OnDisable()
    {
        _player.HealthChanged -= ChangeHealthBar;
    }

    public IEnumerator SlowlyChange(float health)
    {
        while (_slider.value != health)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, health, _duration);
            yield return null;
        }
    }

    public void ChangeHealthBar(float health) 
    {
        if(_preventStackCoroutine != null)
            StopCoroutine(_preventStackCoroutine);
        
        _preventStackCoroutine = StartCoroutine(SlowlyChange(health));
    }
}
