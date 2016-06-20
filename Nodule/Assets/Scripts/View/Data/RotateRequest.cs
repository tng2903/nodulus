using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts.Core.Data;

namespace Assets.Scripts.View.Data
{
    public struct RotateRequest
    {
        public readonly Direction Direction;
        public readonly Action OnComplete;

        public RotateRequest(Direction direction, Action action)
        {
            Direction = direction;
            OnComplete = action;
        }
    }
}
