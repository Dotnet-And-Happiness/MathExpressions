﻿using System;
using System.Linq.Expressions;

namespace MathEpxressions.Parsing.AST
{
    public class VariableExpression : IExpression
    {
        public string VariableName { get; private set; }

        public VariableExpression(string variableName)
        {
            VariableName = variableName;
        }
 
 
        public override string ToString()
        {
            return VariableName;
        }
    }
}
