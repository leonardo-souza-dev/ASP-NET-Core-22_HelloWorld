using AloMundo.Controllers;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class Tests
    {
        private ValuesController valuesController;

        [SetUp]
        public void Setup()
        {
            valuesController = new ValuesController();
        }

        [Test]
        public void DeveRetornarDoisValores()
        {
            var result = valuesController.Get();

            Assert.AreEqual(2, result.Value.Count());
        }
    }
}