using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern.LionCreature
{
    public interface ILion
    {
        string Roar();
    }

    public class Lion : ILion
    {
        public string Roar()
        {
            return "ROAR";
        }
    }

    public class LoudLionDecorator : ILion
    {
        private readonly ILion _lion;

        public LoudLionDecorator(ILion lion)
        {
            this._lion = lion;
        }
        public string Roar()
        {
           return this._lion.Roar() + "loudly";
        }
    }

    public class LouderLionDecorator : ILion
    {
        private readonly ILion _lion;

        public LouderLionDecorator(ILion lion)
        {
            this._lion = lion;
        }
        public string Roar()
        {
            return this._lion.Roar() + "loudlier";
        }
    }

    public class SilentLionDecorator : ILion
    {
        private readonly ILion _lion;

        public SilentLionDecorator(ILion lion)
        {
            this._lion = lion;
        }
        public string Roar()
        {
            return "Meow";
        }
    }
}
