﻿
using System;
using Laboratorio7;

public class Program
{
    public static void Main(string[] args)
    {
        Banco banco1 = new Banco();
        banco1.Operar();
        banco1.DepositosTotales();
        Console.ReadKey();
    }
}