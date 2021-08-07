﻿using Calculator;
using NUnit.Framework;
using System;
using System.Linq;

namespace CalculatorTests
{
    public class BitConverterHexHelperTest
    {
        [Test]
        public void TestHexConverter()
        {
            Assert.Throws(Is.TypeOf<ArgumentNullException>(), () => BitConverterHelper.ConvertArrayToBigEndian(null));
            
            byte[] arr = new byte[4] { 0x0, 0x0, 0x0, 0x1 };

            Assert.AreEqual(arr.Reverse(), BitConverterHelper.ConvertArrayToBigEndian(arr));
        }
    }
}