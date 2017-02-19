using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TAMKShooter
{
    public class InputManager : MonoBehaviour
    {

        public Vector3 ReceiveMovement(string playerPrefix, Vector3 input)
        {
            float horizontal = Input.GetAxis(playerPrefix + "Horizontal");
            float vertical = Input.GetAxis(playerPrefix + "Vertical");

            input = new Vector3(horizontal, 0, vertical);

            return input;
        }

        public bool ReceiveShoot(string playerPrefix, bool shoot)
        {
            shoot = Input.GetButton(playerPrefix + "Shoot");

            return shoot;
        }
    }
}