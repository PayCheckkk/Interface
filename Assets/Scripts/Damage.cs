using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    [SerializeField] private Player _player;

    private float _damage = -10;

    public void OnButtonClick()
    {
        _player.ChangeHealth(_damage);
    }
}
