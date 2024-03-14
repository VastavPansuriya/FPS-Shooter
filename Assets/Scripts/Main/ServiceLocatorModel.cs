

using FPSShooter.Player;
using FPSShooter.Weapon;
using System;

namespace FPSShooter.Main
{
    [Serializable]
    public class ServiceLocatorModel
    {
        //Here add variable of service related ScriptableObjects
        public PlayerModel PlayerModel;
        public WeaponModel WeaponModel;
    }
}