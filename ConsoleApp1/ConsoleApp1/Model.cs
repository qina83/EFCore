using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public enum StateEnum { State1 = 1, State2 = 2};

    public class Model
    {
        public int Id { get; set; }
        public string Text { get; private set; }
        public StateEnum State { get; private set; }

        private Model() { }
        public Model(StateEnum state, string text)
        {
            State = state;
            Text = text;
        }
    }
}
