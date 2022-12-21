using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControls : MonoBehaviour
{
    public float speed = 5;
    public float attakingDistance = 1;
    public Vector3 direction;

    private Animator animatorEnemy;
    private Rigidbody rigidbodyEnemy;
    private Transform target;
    public bool isFollowingTarget;
    public bool isAttackingTarget;
    public float currentAttakingTime;
    public float maxAttakingTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        isFollowingTarget = true;
        currentAttakingTime = maxAttakingTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
