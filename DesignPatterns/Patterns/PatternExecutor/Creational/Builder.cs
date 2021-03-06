﻿using System;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Common.Base;

namespace DesignPatterns.Patterns.PatternExecutor.Creational
{
    public class Builder : IPatternExecutor
    {
        public string Description()
        {
            return string.Format("Separate the construction of a complex object {0}from its representation so that the same construction process {0}can create different representations. ", Environment.NewLine);
        }

        public string DescriptionPL()
        {
            return string.Empty;
        }

        public void Execute()
        {
            VehicleBuilderBase builder;

            Shop shop = new Shop();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
        }

        public void Message(string message)
        {
            throw new NotImplementedException();
        }
    }
}
