namespace InterviewQuestions.Common
{
    public struct BitVector
    {
        private const ulong LongOne = 1;

        public ulong Value { get; private set; }

        public bool HasExactlyOneSet
        {
            get
            {
                return Value != 0 && (Value & (Value - 1)) == 0;
            }
        }

        public bool ZeroOrOneSet
        {
            get
            {
                return Value == 0 || HasExactlyOneSet;
            }
        }

        public bool IsOn(int index)
        {
            if (index < 0)
            {
                return false;
            }

            ulong mask = LongOne << index;
            bool on = (Value & mask) != 0;
            return on;
        }

        public void SetOn(int index)
        {
            if (index < 0)
            {
                return;
            }

            ulong mask = LongOne << index;
            Value |= mask;
        }

        public void SetOff(int index)
        {
            if (index < 0)
            {
                return;
            }

            ulong mask = LongOne << index;
            Value &= ~mask;
        }

        public void Toggle(int index)
        {
            if(index < 0)
            {
                return;
            }

            ulong mask = LongOne << index;
            bool on = (Value & mask) != 0;

            if(on)
            {
                Value &= ~mask;
            }
            else
            {
                Value |= mask;
            }
        }
    }
}