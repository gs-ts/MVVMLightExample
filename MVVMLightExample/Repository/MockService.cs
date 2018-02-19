using System;
using MVVMLightExample.Model;

namespace MVVMLightExample.Repository
{
    class MockService
    {

        public MockService() { }

        public Section1Model GenerateModel()
        {
            Section1Model model = new Section1Model();
            Random random = new Random();

            model.Value1 = random.Next(-100, 100);
            if (model.Value1 > 0)
                model.LightIndicator1 = true;
            else
                model.LightIndicator1 = false;

            model.Value2 = random.Next(-100, 100);
            if (model.Value2 > 0)
                model.LightIndicator2 = true;
            else
                model.LightIndicator2 = false;

            model.Value3 = random.Next(-100, 100);
            if (model.Value3 > 0)
                model.LightIndicator3 = true;
            else
                model.LightIndicator3 = false;

            model.Value4 = random.Next(-100, 100);
            if (model.Value4 > 0)
                model.LightIndicator4 = true;
            else
                model.LightIndicator4 = false;

            model.Value5 = random.Next(-100, 100);
            if (model.Value5 > 0)
                model.LightIndicator5 = true;
            else
                model.LightIndicator5 = false;

            model.Value6 = random.Next(-100, 100);
            if (model.Value6 > 0)
                model.LightIndicator6 = true;
            else
                model.LightIndicator6 = false;

            model.Value7 = random.Next(-100, 100);
            if (model.Value7 > 0)
                model.LightIndicator7 = true;
            else
                model.LightIndicator7 = false;

            model.Value8 = random.Next(-100, 100);
            if (model.Value8 > 0)
                model.LightIndicator8= true;
            else
                model.LightIndicator8 = false;

            return model;
        }
    }
}
