using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAnimEvents : MonoBehaviour
{
    private Player player;
    
    void Start()
    {
        player = GetComponentInParent<Player>();
    }

    private void AnimationTrigger()
    {
        player.AttackOver();
    }
}
