using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    // bool
    private const string IS_WALKING = "IsWalking";

    [SerializeField] private Player player;

    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        animator.SetBool(IS_WALKING, player.IsWalking());
    }
}
