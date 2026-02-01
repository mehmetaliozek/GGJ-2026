using UnityEngine;

public class Player : MonoBehaviour
{    
    private MovementController movementController;
    private AnimationController animationController;
    private ThreatController threatController;
    private KillController killController;

    public bool IsTreat = false;
    public bool IsKill = false;

    private void Start()
    {
        movementController = GetComponent<MovementController>();
        animationController = GetComponent<AnimationController>();
        threatController = GetComponent<ThreatController>();
        killController = GetComponent<KillController>();
    }

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        movementController.Move(x, z);
        animationController.Walk(movementController.MagnitudeVelocity);

        if (Input.GetKeyDown(KeyCode.Mouse0) && !IsTreat)
        {
            threatController.Threat();
            animationController.Threat();
        }

        if (Input.GetKeyDown(KeyCode.Mouse1) && !IsKill && threatController.i == 3)
        {
            killController.Kill();
            animationController.Kill();
        }
    }

    public void IsTreatTrue()
    {
        IsTreat = true;
    }

    public void IsTreatFalse()
    {
        IsTreat = false;
    }

    public void IsKillTrue()
    {
        IsKill = true;
    }

    public void IsKillFalse()
    {
        IsKill = false;
    }
}
