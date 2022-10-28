using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Heal : MonoBehaviour
{
    [SerializeField] private Player _player;

    private float _heal = 10;

    public void OnButtonClick()
    {
        _player.ChangeHealth(_heal);
    }
}
