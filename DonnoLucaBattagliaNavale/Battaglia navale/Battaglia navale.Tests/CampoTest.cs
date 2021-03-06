// <copyright file="CampoTest.cs">Copyright ©  2018</copyright>

using System;
using Battaglia_navale;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Battaglia_navale.Tests
{
    [TestClass]
    [PexClass(typeof(Campo))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CampoTest
    {

        [PexMethod]
        [PexAllowedException(typeof(NullReferenceException))]
        public bool ciSta(
            [PexAssumeUnderTest]Campo target,
            Nave n,
            int x,
            int y
        )
        {
            bool result = target.ciSta(n, x, y);
            return result;
            // TODO: aggiungere asserzioni a metodo CampoTest.ciSta(Campo, Nave, Int32, Int32)
        }

        [PexMethod]
        public bool InserisciNave(
            [PexAssumeUnderTest]Campo target,
            Nave naveSelezionata,
            int x,
            int y
        )
        {
            bool result = target.InserisciNave(naveSelezionata, x, y);
            return result;
            // TODO: aggiungere asserzioni a metodo CampoTest.InserisciNave(Campo, Nave, Int32, Int32)
        }
    }
}
