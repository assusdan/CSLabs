﻿namespace CSLabs.Operations
{
    public class SaveNumber : IOperation
    {
        public char OperatorChar => '\0';
        public bool Run(MathBuffer mathBuffer)
        {
            mathBuffer.AccValue = mathBuffer.TempValue;
            return true;
        }
    }
}