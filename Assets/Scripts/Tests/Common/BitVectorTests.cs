using NUnit.Framework;

namespace InterviewQuestions.Common.Tests
{
    public class BitVectorTests
    {
        BitVector bitVector;

        [SetUp]
        public void SetUp()
        {
            bitVector = new BitVector();
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(64)]
        [TestCase(64, 1, 0, 2)]
        public void SetOn_ValidIndex_SetsBitOn(params int[] indices)
        {
            foreach(var index in indices)
            {
                bitVector.SetOn(index);
                Assert.That(bitVector.IsOn(index));
            }
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(64)]
        [TestCase(64, 1, 0, 2)]
        public void SetOff_ValidIndex_SetsBitOff(params int[] indices)
        {
            foreach (var index in indices)
            {
                bitVector.SetOn(index);
            }

            foreach (var index in indices)
            {
                bitVector.SetOff(index);
                Assert.That(!bitVector.IsOn(index));
            }
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(64)]
        [TestCase(32, 1, 0, 2)]
        public void Toggle_ValidIndex_TogglesBit(params int[] indices)
        {
            for(var i = 0; i < indices.Length; ++i)
            {
                if(i % 2 == 0)
                {
                    int index = indices[i];
                    bitVector.SetOn(index);
                }
            }

            for(var i = 0; i < indices.Length; ++i)
            {
                int index = indices[i];
                bitVector.Toggle(index);

                if(i % 2 == 0)
                {
                    Assert.That(!bitVector.IsOn(index));
                }
                else
                {
                    Assert.That(bitVector.IsOn(index));
                }
            }
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(64)]
        public void HasExactlyOneSet_OneEntry_ReturnsTrue(int index)
        {
            bitVector.SetOn(index);
            Assert.That(bitVector.HasExactlyOneSet);
        }

        [Test]
        public void HasExactlyOneSet_Zero_ReturnsFalse()
        {
            Assert.That(!bitVector.HasExactlyOneSet);
        }

        [TestCase(64, 1, 0, 2)]
        [TestCase(64, 1, 0)]
        [TestCase(64, 1)]
        public void HasExactlyOneSet_MoreThanOne_ReturnsFalse(params int[] indices)
        {
            foreach (var index in indices)
            {
                bitVector.SetOn(index);
            }

            Assert.That(!bitVector.HasExactlyOneSet);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(64)]
        public void ZeroOrOneSet_OneEntry_ReturnsTrue(int index)
        {
            bitVector.SetOn(index);
            Assert.That(bitVector.ZeroOrOneSet);
        }

        [Test]
        public void ZeroOrOneSet_Zero_ReturnsTrue()
        {
            Assert.That(bitVector.ZeroOrOneSet);
        }

        [TestCase(64, 1, 0, 2)]
        [TestCase(64, 1, 0)]
        [TestCase(64, 1)]
        public void ZeroOrOneSet_MoreThanOne_ReturnsFalse(params int[] indices)
        {
            foreach (var index in indices)
            {
                bitVector.SetOn(index);
            }

            Assert.That(!bitVector.ZeroOrOneSet);
        }
    }
}
