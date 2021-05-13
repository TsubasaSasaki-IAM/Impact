using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactorcontroller : MonoBehaviour
{
    protected enum AnimationID
    {
        Ekard_BattleIdle_01 = 0,
        Ekard_Run_01 = 1,

        Ekard_Attack_01 = 10,
        Ekard_Attack_02 = 11,

        Ekard_Skill_01 = 100,
        Ekard_Debuff_01 = 101,
        Ekart_Stun_01 = 110,

    }

    [SerializeField]
    float moveSpeed = 5.0f;

    AnimationID anim = AnimationID.Ekard_BattleIdle_01;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            anim = AnimationID.Ekard_Attack_01;
        }

    }

    protected void UpdateExecute()
    {
        switch(anim)
        {
            case AnimationID.Ekard_BattleIdle_01:
                UpdateIdle();
                break;
            case AnimationID.Ekard_Run_01:
                UpdateRun();
                break;
            case AnimationID.Ekard_Attack_01:
                UpdateAttack();
                break;
        }
    }

    void OnFinishActionState()
    {
        switch(anim)
        {
            case AnimationID.Ekard_BattleIdle_01:
            break;
        }   
    }

    void UpdateIdle()
    {

    }

    void UpdateAttack()
    {

    }

    void UpdateRun()
    {

    }

}
