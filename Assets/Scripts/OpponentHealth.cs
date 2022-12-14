using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// OpponentHealth
/// Created by Jay Church
/// 05/12/2017
/// © Moon Cat Laboratory / Jay Church
/// </summary>

public class OpponentHealth : MonoBehaviour
{

    public static int _minimumOpponentHealth = 0;               //Defines minimum opponent health
    public static int _maximumOpponentHealth = 100;             //Defines maximum opponent health
    public static int _currentOpponentHealth;                   //Defines naming convention for opponent's current health

    public bool _isOpponentDefeated;                           //Creates a bool to define if the opponent has been defeated

    // Use this for initialization
    void Start()
    {
        _currentOpponentHealth = _maximumOpponentHealth;        //Set current health to equal maximum on start up

        _isOpponentDefeated = false;                            //Set is opponent defeated to false on start up
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpponentLowKickDamage(int _damageDealtToOpponent)
    {
        Debug.Log("OpponentLowKickDamage");

        if (_isOpponentDefeated == true)                        //if is opponent defeated equal to true
            return;                                             //then do nothing and return

        _currentOpponentHealth -= _damageDealtToOpponent;       //Minus damage dealt from the opponents current health

        SendMessageUpwards("OpponentHitByLowKick",              //Send message "OpponentHitByLowKick" to call that function
            SendMessageOptions.DontRequireReceiver);            //receiver not required

        OpponentHealthDepletedCheck();                          //Call OpponentHealthDepletedCheck function
    }

    public void OpponentHighKickDamage(int _damageDealtToOpponent)
    {
        Debug.Log("OpponentHighKickDamage");

        if (_isOpponentDefeated == true)                        //if is opponent defeated equal to true
            return;                                             //then do nothing and return

        _currentOpponentHealth -= _damageDealtToOpponent;       //Minus damage dealt from the opponents current health

        SendMessageUpwards("OpponentHitByHighKick",             //Send message "OpponentHitByHighKick" to call that function
            SendMessageOptions.DontRequireReceiver);            //receiver not required

        OpponentHealthDepletedCheck();                          //Call OpponentHealthDepletedCheck function
    }

    public void OpponentLeftPunchDamage(int _damageDealtToOpponent)
    {
        Debug.Log("OpponentLeftPunchDamage");

        if (_isOpponentDefeated == true)                        //if is opponent defeated equal to true
            return;                                             //then do nothing and return

        _currentOpponentHealth -= _damageDealtToOpponent;       //Minus damage dealt from the opponents current health

        SendMessageUpwards("OpponentHitByLeftPunch",            //Send message "OpponentHitByLeftPunch" to call that function
            SendMessageOptions.DontRequireReceiver);            //receiver not required

        OpponentHealthDepletedCheck();                          //Call OpponentHealthDepletedCheck function
    }

    public void OpponentRightPunchDamage(int _damageDealtToOpponent)
    {
        Debug.Log("OpponentRightPunchDamage");

        if (_isOpponentDefeated == true)                        //if is opponent defeated equal to true
            return;                                             //then do nothing and return

        _currentOpponentHealth -= _damageDealtToOpponent;       //Minus damage dealt from the opponents current health

        SendMessageUpwards("OpponentHitByRightPunch",           //Send message "OpponentHitByRightPunch" to call that function
            SendMessageOptions.DontRequireReceiver);            //receiver not required

        OpponentHealthDepletedCheck();                          //Call OpponentHealthDepletedCheck function
    }

    public void OpponentHealthDepletedCheck()
    {
        //        Debug.Log("PlayerOneHealthDepletedCheck");

        if (_currentOpponentHealth < _minimumOpponentHealth)    //if opponents current health is less than zero
            _currentOpponentHealth = _minimumOpponentHealth;    //then make current opponent health equal to zero

        if (_currentOpponentHealth == _minimumOpponentHealth)   //if opponents current health is equal to zero
        {
            _isOpponentDefeated = true;                         //Set is opponent defeated to true

            SendMessage("SetOpponentDefeated",                  //Send message "SetOpponentDefeated" to call that function
                SendMessageOptions.DontRequireReceiver);        //receiver not required
        }
    }
}
