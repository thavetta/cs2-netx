﻿using System;
using NetTopologySuite;
using NetTopologySuite.Geometries;

namespace Auta
{
    public class Auto
    {
        public string Model { get; set; }
        public int MistNaSezeni { get; set; }
        public string Barva { get; set; }
        
        public double Rychlost { get; set; }
        public bool MotorFunkcni { get; set; }
        public Point PoziceAktualni { get; set; }

        public void NastartujMotor() => MotorFunkcni = true;

        public void VypniMotor() => MotorFunkcni = false;


    }
}
