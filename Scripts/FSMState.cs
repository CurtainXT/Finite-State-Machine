using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSMState
{
    public StateType stateType;
    public FSMSystem fsmSystem;
    public GameObject npc;  // pass object if needed
    public virtual void Act() { } // action of this state
    public virtual void Reason() { } // handle state transition
    public virtual void Enter() { }
    public virtual void Exit() { }

    public FSMState(FSMSystem _fsmSystem, GameObject _npc)
    {
        this.fsmSystem = _fsmSystem;
        this.npc = _npc;
    }

 }
