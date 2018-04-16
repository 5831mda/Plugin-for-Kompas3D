using NUnit.Framework;
using Plugin_Kernel;
using Kompas6API5;
using System;
using System.Threading.Tasks;

namespace Plugin_KernelTests
{
    [TestFixture]
    class LoadTest
    {
        public KompasObject kompas;

        [TestCase(199, TestName = "Тестирование при построении 1 документа-модели")]
        /*[TestCase(2, TestName = "Тестирование при построении 2 документа-модели")]
        [TestCase(3, TestName = "Тестирование при построении 3 документа-модели")]
        [TestCase(4, TestName = "Тестирование при построении 4 документа-модели")]
        [TestCase(5, TestName = "Тестирование при построении 5 документа-модели")]
        [TestCase(6, TestName = "Тестирование при построении 6 документа-модели")]
        [TestCase(7, TestName = "Тестирование при построении 7 документа-модели")]
        [TestCase(8, TestName = "Тестирование при построении 8 документа-модели")]
        [TestCase(9, TestName = "Тестирование при построении 9 документа-модели")]
        [TestCase(10, TestName = "Тестирование при построении 10 документа-модели")]
        [TestCase(11, TestName = "Тестирование при построении 5 документа-модели")]
        [TestCase(12, TestName = "Тестирование при построении 6 документа-модели")]
        [TestCase(13, TestName = "Тестирование при построении 7 документа-модели")]
        [TestCase(14, TestName = "Тестирование при построении 8 документа-модели")]
        [TestCase(15, TestName = "Тестирование при построении 9 документа-модели")]
        [TestCase(16, TestName = "Тестирование при построении 10 документа-модели")]*/
        public void CreateTestLoad(int count)
        {
            var param = new Parameters();
            param.Radios1 = 20;
            param.Radios2 = 15;
            param.Lenght1 = 70;
            param.Lenght2 = 100;
            param.Angle1 = 6;
            param.Angle2 = 45;

            if (kompas == null)
            {
                Type t = Type.GetTypeFromProgID("KOMPAS.Application.5");
                kompas = (KompasObject)Activator.CreateInstance(t);

            }
            if (kompas != null)
            {
                kompas.Visible = true;
                kompas.ActivateControllerAPI();
            }

            for (int i = 1; i <= count; i++)
            {
                var product = new CreatorDetail(kompas);
                product.DownCircle(param);
                product.MiddleCircle(param);
                product.UpCircle(param);
                product.CreateChamfer(param);
                product.FlatPart(param);
            }
        }
    }
}
    

