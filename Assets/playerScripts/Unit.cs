using System.Data;
using UnityEngine;
using UnityEngine.AI;

public class Unit : MonoBehaviour
{
    public int HP;
    [SerializeField]
    public int MaxHP;

    public int SH;
    [SerializeField]
    public int MaxShields;
    [SerializeField]
    public int range;
    [SerializeField]
    public float Speed;
    NavMeshAgent agent;
    public bool isStation = false;

    public void Start()
    {
        HP = MaxHP;
        SH = MaxShields;
        agent =  gameObject.GetComponent<NavMeshAgent>();
        agent.speed = Speed;
    }
    protected void OnDestroy()
    {
        Movement mv = gameObject.GetComponent<Movement>();
        MovementController.instance.units.Remove(mv);
        if(MovementController.instance.selectedUnits.Contains(mv))
            MovementController.instance.selectedUnits.Remove(mv);

        if(playerAttackController.instance.selectedUnits.Contains(mv))
            playerAttackController.instance.selectedUnits.Remove(mv);

    }
}
